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
    public partial class CompanyDetails : EntityBase
    {
        //const string OrderSEQUENCE = "OrderIDSequence";
        protected override string Caption
        {
            get { return "Companies"; }
        }

        protected override Type FormType
        {
            get { return typeof(Forms.CompanyDetails); }
        }

        protected override Type ListFormType
        {
            get { return typeof(Forms.CompanyDetails); }
        }

        public override string TableName
        {
            get { return "companydetails"; }
        }

        protected override string TitleColumn1
        {
            get { return "Company"; }
        }

        protected override string TitleColumn2
        {
            get { return "CreatedBy"; }
        }

        protected override void setupEntityInfo()
        {
            //FieldInfoList["CompanyID"] = new FieldInfo(true, true, true, new CompanyEDT());
            //FieldInfoList["CompanyName"] = new FieldInfo(true, true, true, new NameEDT());
            FieldInfoList["CompanyAddress"] = new FieldInfo(true, true, true, new AddressEDT());

            TableInfo.KeyInfoList["Company"] = new KeyInfo(KeyType.Unique, "Company");
            //TableInfo.KeyInfoList["CustomerID"] = new KeyInfo(KeyType.Key, "CustomerID");

            FieldGroups["grid"] = new String[] { "Company", "CompanyAddress", "CreatedBy", "CreatedDateTime" };
        }


    }
}
