using AppFramework.AppClasses;
using FirstAppFrameworkApplicationEntities.EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppFrameworkApplicationEntities.EDTs
{
    internal class OrderStatusEDT : ExtendedDataType
    {
        public override Type EnumType
        {
            get { return typeof(OrderStatus); }
        }

        public override FormDataType FormDataType
        {
            get { return AppFramework.AppClasses.FormDataType.Enum; }
        }

        public override string Label
        {
            get { return "Order Status"; }
        }

        public override int Length
        {
            get { return -1; }
        }

        public override LookupInfo LookupInfo
        {
            get { return new LookupInfo(typeof(Order), "OrderStatus", ""); }
        }
    }
    public enum OrderStatus
    {
        SETTLED,
        OWING,
        NULL,
        OVERPAYED
    }
}
