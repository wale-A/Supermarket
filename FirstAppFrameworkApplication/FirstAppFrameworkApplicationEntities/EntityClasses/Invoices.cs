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
    public partial class Invoices : EntityBase
    {
        const string INVOICESEQUENCE = "InvoiceIDSequence";
        protected override string Caption
        {
            get { return "Invoices"; }
        }

        protected override Type FormType
        {
            get { return typeof(Forms.Invoices); }
        }

        protected override Type ListFormType
        {
            get { throw new NotImplementedException(); }
        }

        public override string TableName
        {
            get { return "invoices"; }
        }

        protected override string TitleColumn1
        {
            get { return "InvoiceID"; }
        }

        protected override string TitleColumn2
        {
            get { return "CustomerID"; }
        }

        protected override void setupEntityInfo()
        {
            FieldInfoList["InvoiceID"] = new FieldInfo(true, true, true, new InvoiceEDT());
            FieldInfoList["CustomerID"] = new FieldInfo(true, true, true, "Customer", new CustomerEDT());

            TableInfo.KeyInfoList["InvoiceID"] = new KeyInfo(KeyType.PrimaryField, "InvoiceID");
            TableInfo.KeyInfoList["CustomerID"] = new KeyInfo(KeyType.Key, "CustomerID");

            FieldGroups["grid"] = new String[] { "InvoiceID", "CustomerID", "CreatedBy", "CreatedDateTime" };
        }

       
    }
}
