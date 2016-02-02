using AppFramework.AppClasses;
using AppFramework.AppClasses.EDTs;
using AppFramework.Linq;
using FirstAppFrameworkApplicationEntities.EDTs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppFrameworkApplicationEntities.EntityClasses
{
    partial class Items : EntityBase
    {
        protected override string Caption
        {
            get { return "Items"; }
        }

        protected override Type FormType
        {
            get { return typeof(Forms.Items); }
        }

        protected override Type ListFormType
        {
            get { return typeof(Forms.Items); }
        }

        public override string TableName
        {
            get { return "items"; }
        }

        protected override string TitleColumn1
        {
            get { return "ItemID"; }
        }

        protected override string TitleColumn2
        {
            get { return "ItemName"; }
        }

        protected override void setupEntityInfo()
        {
            FieldInfoList["ItemID"] = new FieldInfo(false, false, true, new ItemEDT());
            FieldInfoList["ItemName"] = new FieldInfo(true, true, true, "Item Name", new NameEDT());
            FieldInfoList["ItemDescription"] = new FieldInfo(true, true, true, "Description", new ShortDescriptionEDT());
            FieldInfoList["ItemQuantity"] = new FieldInfo(true, true, true, "Quantity", FormDataType.Integer);
            FieldInfoList["Price"] = new FieldInfo(true, true, true, "Price", new AmountEDT());

            FieldInfoList["ItemCategoryID"] = new FieldInfo(false, false, true, "Category", new ItemCategoryEDT());

            TableInfo.KeyInfoList["ItemID"] = new KeyInfo(KeyType.PrimaryField, "ItemID");
            TableInfo.KeyInfoList["ItemCategoryID"] = new KeyInfo(KeyType.Key, "ItemCategoryID");
        }

        protected override long insert(bool forceWrite, bool callSaveMethod)
        {            
            this.ItemID = AppFramework.AppClasses.AppEntities.NumberSequences.getNumber("ItemIDSequence");

            var category = (from itemCategory in new QueryableEntity<ItemCategory>() where itemCategory.ItemCategoryID == this.ItemCategoryID select itemCategory).AppFirst();
            category.ItemQuantity += this.ItemQuantity;
            category.update();

            return base.insert(forceWrite, callSaveMethod);
        }

        protected override long update(bool forceWrite, bool callSaveMethod)
        {
            var category = (from itemCategory in new QueryableEntity<ItemCategory>() where itemCategory.ItemCategoryID == this.ItemCategoryID select itemCategory).AppFirst();
            var itemQuantity = (from i in new QueryableEntity<Items>() where i.ItemID == this.ItemID select i.ItemQuantity).ToList();
            category.ItemQuantity += (itemQuantity[0] - this.ItemQuantity);
            category.update();

            return base.update(forceWrite, callSaveMethod);
        }
    }
}
