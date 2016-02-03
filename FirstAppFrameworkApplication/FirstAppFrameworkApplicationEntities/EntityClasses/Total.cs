using AppFramework.AppClasses;
using AppFramework.AppClasses.EDTs;
using FirstAppFrameworkApplicationEntities.EDTs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppFrameworkApplicationEntities.EntityClasses
{
    partial class Total : EntityBase
    {
        protected override string Caption
        {
            get { return "Total"; }
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
            get { return "total"; }
        }

        protected override string TitleColumn1
        {
            get { return "Description"; }
        }

        protected override string TitleColumn2
        {
            get { return "Amount"; }
        }

        protected override void setupEntityInfo()
        {
            FieldInfoList["OrderID"] = new FieldInfo(false, false, true, new OrderEDT());
            FieldInfoList["Description"] = new FieldInfo(false, false, true, new ShortDescriptionEDT());
            FieldInfoList["Amount"] = new FieldInfo(false, false, true, new AmountEDT());

            TableInfo.KeyInfoList["OrderID"] = new KeyInfo(KeyType.Key, "OrderID");
            TableInfo.KeyInfoList["PrimaryKey"] = new KeyInfo(KeyType.PrimaryField, "OrderID", "Description", "Amount");

            FieldGroups["grid"] = new String[] { "OrderID", "Description", "CreatedBy", "CreatedDateTime", "Amount"};
        }
    }
}
