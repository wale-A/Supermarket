using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFramework.AppClasses;

namespace FirstAppFrameworkApplicationEntities.EDTs
{
    class InvoiceEDT : ExtendedDataType
    {
        private LookupInfo lookupInfo = new LookupInfo(typeof(EntityClasses.Invoices), "InvoiceID", "");
        public override Type EnumType
        {
            get { return null; }
        }

        public override FormDataType FormDataType
        {
            get { return AppFramework.AppClasses.FormDataType.String; }
        }

        public override string Label
        {
            get { return "Invoice ID"; }
        }

        public override int Length
        {
            get { return -1; }
        }

        public override LookupInfo LookupInfo
        {
            get { return lookupInfo; }
        }
    }
}
