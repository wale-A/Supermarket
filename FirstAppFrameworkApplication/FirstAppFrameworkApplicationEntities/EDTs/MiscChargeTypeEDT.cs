using AppFramework.AppClasses;
using FirstAppFrameworkApplicationEntities.EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppFrameworkApplicationEntities.EDTs
{
    class MiscChargeTypeEDT : ExtendedDataType
    {
        public override Type EnumType
        {
            get { return typeof(DeductionType); }
        }

        public override FormDataType FormDataType
        {
            get { return AppFramework.AppClasses.FormDataType.Enum; }
        }

        public override string Label
        {
            get { return "Deduction Type"; }
        }

        public override int Length
        {
            get { return -1; }
        }

        public override LookupInfo LookupInfo
        {
            get { return new LookupInfo(typeof(MiscCharge), "DeductionType", ""); }
        }
    }
    public enum DeductionType
    {
        FIXED,
        PERCENTAGE
    }
}
