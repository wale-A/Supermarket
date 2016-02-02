using AppFramework.AppClasses;
using AppFramework.AppClasses.EDTs;
using AppFramework.Linq;
using FirstAppFrameworkApplicationEntities.EDTs;
using FirstAppFrameworkApplicationEntities.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppFrameworkApplicationEntities.EntityClasses
{
    partial class OrderMiscCharges : EntityBase
    {
        protected override string Caption
        {
            get { return "Order Deductions"; }
        }

        protected override Type FormType
        {
            get { return typeof(OrderDeductions); }
        }

        protected override Type ListFormType
        {
            get { return typeof(OrderDeductions); }
        }

        public override string TableName
        {
            get { return "orderdeductions"; }
        }

        protected override string TitleColumn1
        {
            get { return "OrderID"; }
        }

        protected override string TitleColumn2
        {
            get { return "DeductionID"; }
        }

        protected override void setupEntityInfo()
        {
            FieldInfoList["OrderID"] = new FieldInfo(true, false, true, new OrderEDT());
            FieldInfoList["DeductionID"] = new FieldInfo(true, false, true, new MiscChargeEDT());
            FieldInfoList["Amount"] = new FieldInfo(false, false, true, new AmountEDT());

            TableInfo.KeyInfoList["DeductionID"] = new KeyInfo(KeyType.Key, "DeductionID");
            TableInfo.KeyInfoList["OrderID"] = new KeyInfo(KeyType.Key, "OrderID");
            TableInfo.KeyInfoList["PrimaryKey"] = new KeyInfo(KeyType.PrimaryField, "DeductionID", "OrderID");
        }

        protected override long insert(bool forceWrite, bool callSaveMethod)
        {
            var deduction = (from d in new QueryableEntity<MiscCharge>()
                             where d.DeductionID == this.DeductionID
                             select d).AppFirst();
            var order = (from o in new QueryableEntity<Order>()
                         where o.OrderID == this.OrderID
                         select o).AppFirst();
            if (deduction.DeductionType == DeductionType.FIXED)
                this.Amount = deduction.Value ;
            else if (deduction.DeductionType == DeductionType.PERCENTAGE)
                this.Amount = (order.Amount * deduction.Value) / 100;

            return base.insert(forceWrite, callSaveMethod);
        }
    }
}
