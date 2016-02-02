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
    partial class InvoiceDetails : EntityBase
    {
        protected override string Caption
        {
            get { return "Invoice Details"; }
        }

        protected override Type FormType
        {
            get { throw new NotImplementedException(); }
        }

        protected override Type ListFormType
        {
            get { throw new NotImplementedException(); }
        }

        public override string TableName
        {
            get { return "invoicedetails"; }
        }

        protected override string TitleColumn1
        {
            get { return "InvoiceDetailID"; }
        }

        protected override string TitleColumn2
        {
            get { return "Invoice"; }
        }

        protected override void setupEntityInfo()
        {
            FieldInfoList["InvoiceID"] = new FieldInfo(true, true, true, new InvoiceEDT());
            FieldInfoList["ItemCategoryID"] = new FieldInfo(true, true, true, new ItemCategoryEDT());
            FieldInfoList["ItemID"] = new FieldInfo(true, true, true, new ItemEDT());
            FieldInfoList["Quantity"] = new FieldInfo(true, false, true, "Quantity", new IntEDT());
            FieldInfoList["Amount"] = new FieldInfo(false, false, true, "Amount", new AmountEDT());

            TableInfo.KeyInfoList["InvoiceID"] = new KeyInfo(KeyType.Key, "InvoiceID");
            TableInfo.KeyInfoList["ItemCategory"] = new KeyInfo(KeyType.Key, "ItemCategory");
            TableInfo.KeyInfoList["Item"] = new KeyInfo(KeyType.Key, "Item");
            TableInfo.KeyInfoList["CompositeKey"] = new KeyInfo(KeyType.Unique, "InvoiceID", "ItemCategory", "Item");
        }

        protected override long insert(bool forceWrite, bool callSaveMethod)
        {
            //var unitPrice = (from item in new QueryableEntity<Items>()
            //                 where item.ItemId == this.ItemID
            //                 select item.Price).AppFirst();

            //this.Amount = unitPrice * this.Quantity;
            return base.insert(forceWrite, callSaveMethod);
        }
    }
}
