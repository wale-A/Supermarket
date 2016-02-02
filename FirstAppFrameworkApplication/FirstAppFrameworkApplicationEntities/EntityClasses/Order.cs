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
    public partial class Order : EntityBase
    {
        const string OrderSEQUENCE = "OrderIDSequence";
        protected override string Caption
        {
            get { return "Orders"; }
        }

        protected override Type FormType
        {
            get { return typeof(Forms.Orders); }
        }

        protected override Type ListFormType
        {
            get { return typeof(Forms.Orders); }
        }

        public override string TableName
        {
            get { return "orders"; }
        }

        protected override string TitleColumn1
        {
            get { return "OrderID"; }
        }

        protected override string TitleColumn2
        {
            get { return "CustomerID"; }
        }

        protected override void setupEntityInfo()
        {
            FieldInfoList["OrderID"] = new FieldInfo(false, false, true, new OrderEDT());
            FieldInfoList["CustomerID"] = new FieldInfo(true, false, true, "Customer", new CustomerEDT());
            FieldInfoList["OrderStatus"] = new FieldInfo(false, false, false, new OrderStatusEDT());
            FieldInfoList["Amount"] = new FieldInfo(false, false, true, new AmountEDT());

            TableInfo.KeyInfoList["OrderID"] = new KeyInfo(KeyType.PrimaryField, "OrderID");
            TableInfo.KeyInfoList["CustomerID"] = new KeyInfo(KeyType.Key, "CustomerID");

            FieldGroups["grid"] = new String[] { "OrderID", "CustomerID", /*"CreatedBy", "CreatedDateTime",*/ "OrderStatus", "Amount" };
        }
        protected override long insert(bool forceWrite, bool callSaveMethod)
        {
            this.Amount = 0;
            this.OrderID = AppFramework.AppClasses.AppEntities.NumberSequences.getNumber("OrderIDSequence");
            this.OrderStatus = EDTs.OrderStatus.NULL;
            return base.insert(forceWrite, callSaveMethod);
        }

        protected override long update(bool forceWrite, bool callSaveMethod)
        {
            if (this.Amount < 0)
                this.OrderStatus = EDTs.OrderStatus.OWING;
            else if (this.Amount == 0)
                this.OrderStatus = EDTs.OrderStatus.SETTLED;
            else if (this.Amount > 0)
                this.OrderStatus = EDTs.OrderStatus.OVERPAYED;
            return base.update(forceWrite, callSaveMethod);
        }
                
    }
}
