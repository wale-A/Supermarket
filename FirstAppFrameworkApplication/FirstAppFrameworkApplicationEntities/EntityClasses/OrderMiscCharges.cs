using AppFramework.AppClasses;
using AppFramework.AppClasses.EDTs;
using AppFramework.Linq;
using FirstAppFrameworkApplicationEntities.EDTs;
using FirstAppFrameworkApplicationEntities.EntityEnums;
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
        public decimal TempValue { get; set; }
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
            FieldInfoList["Amount"] = new FieldInfo(false, false, true, new AmountEDT());
            FieldInfoList["MiscChargeID"] = new FieldInfo(true, false, true, new MiscChargeEDT());
            FieldInfoList["ItemID"] = new FieldInfo(true, false, true, new ItemEDT());
            
            TableInfo.KeyInfoList["OrderID"] = new KeyInfo(KeyType.Key, "OrderID");
            TableInfo.KeyInfoList["MiscChargeID"] = new KeyInfo(KeyType.Key, "MiscChargeID");
            TableInfo.KeyInfoList["ItemID"] = new KeyInfo(KeyType.Key, "ItemID");
            TableInfo.KeyInfoList["PrimaryKey"] = new KeyInfo(KeyType.PrimaryField, "MiscChargeID", "OrderID", "ItemID");
        }

        protected override long insert(bool forceWrite, bool callSaveMethod)
        {
            var order = (from o in new QueryableEntity<Order>()
                         where o.OrderID == this.OrderID
                         select o).AppFirst();
            order.Amount -= this.Amount;
            order.update();

            var miscCharge = (from m in new QueryableEntity<MiscCharge>()
                              where m.DeductionID == this.MiscChargeID
                              select m).AppFirst();
            var totalObj = (from t in new QueryableEntity<Total>()
                            where t.OrderID == this.OrderID && t.Description == miscCharge.Description
                            select t).AppFirst();
            if (totalObj == null)
            {
                totalObj = new Total
                {
                    OrderID = this.OrderID,
                    Description = miscCharge.Description,
                    Amount = this.Amount
                };
                totalObj.insert();
            }
            else
            {
                totalObj.Amount += this.Amount;
                totalObj.update();
            }
            return base.insert(forceWrite, callSaveMethod);
        }

        public override long delete(bool forceWrite)
        {
            var order = (from o in new QueryableEntity<Order>()
                         where o.OrderID == this.OrderID
                         select o).AppFirst();
            order.Amount -= this.Amount;
            order.update();

            var miscCharge = (from m in new QueryableEntity<MiscCharge>()
                              where m.DeductionID == this.MiscChargeID
                              select m).AppFirst();
            var totalObj = (from t in new QueryableEntity<Total>()
                            where t.OrderID == this.OrderID && t.Description == miscCharge.Description
                            select t).AppFirst();
            if (totalObj != null)
                totalObj.Amount -= this.Amount;

            return base.delete(forceWrite);
        }
    }
}