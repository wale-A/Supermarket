using AppFramework.AppClasses;
using FirstAppFrameworkApplicationEntities.EDTs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppFrameworkApplicationEntities.EntityClasses
{
    partial class ItemCategory : EntityBase
    {
        protected override string Caption
        {
            get { return "Item Category"; }
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
            get { return "itemcategory"; }
        }

        protected override string TitleColumn1
        {
            get { return "ItemCategoryID"; }
        }

        protected override string TitleColumn2
        {
            get { return "ItemCategoryName"; }
        }

        protected override void setupEntityInfo()
        {
            FieldInfoList["ItemCategoryID"] = new FieldInfo(true, false, true, new ItemCategoryEDT());
            FieldInfoList["ItemQuantity"] = new FieldInfo(false, false, false, "Quantity", FormDataType.Integer);
            FieldInfoList["ItemCategoryName"] = new FieldInfo(true, true, true, "Category Name", FormDataType.String);

            TableInfo.KeyInfoList["ItemCategoryID"] = new KeyInfo(KeyType.PrimaryField, "ItemCategoryID");
            TableInfo.KeyInfoList["ItemCategoryName"] = new KeyInfo(KeyType.Unique, "ItemCategoryName");
        }

        protected override long insert(bool forceWrite, bool callSaveMethod)
        {
            //this.ItemCategoryID = AppFramework.AppClasses.AppEntities.NumberSequences.getNumber("ItemTypeIDSequence");
            this.ItemQuantity = 0;

            return base.insert(forceWrite, callSaveMethod);
        }
    }
}
