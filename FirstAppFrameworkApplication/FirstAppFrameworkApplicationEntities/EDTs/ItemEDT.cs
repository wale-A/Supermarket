using AppFramework.AppClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppFrameworkApplicationEntities.EDTs
{
    class ItemEDT : ExtendedDataType
    {
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
            get { return "Item"; }
        }

        public override int Length
        {
            get { return -1; }
        }

        public override LookupInfo LookupInfo
        {
            get { return new LookupInfo(typeof(EntityClasses.Items), "ItemID", ""); }
        }
    }
}
