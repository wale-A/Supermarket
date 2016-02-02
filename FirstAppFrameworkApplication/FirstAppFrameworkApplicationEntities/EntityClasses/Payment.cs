using AppFramework.AppClasses;
using AppFramework.AppClasses.EDTs;
using AppFramework.Linq;
using FirstAppFrameworkApplicationEntities.EDTs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppFrameworkApplicationEntities.EntityClasses
{
    partial class Payment : EntityBase
    {
        protected override string Caption
        {
            get { return "Payment"; }
        }

        protected override Type FormType
        {
            get { return typeof(Forms.Payment); }
        }

        protected override Type ListFormType
        {
            get { return typeof(Forms.Payment); }
        }

        public override string TableName
        {
            get { return "payments"; }
        }

        protected override string TitleColumn1
        {
            get { return "PaymentID"; }
        }

        protected override string TitleColumn2
        {
            get { return "OrderID"; }
        }

        protected override void setupEntityInfo()
        {
            FieldInfoList["PaymentID"] = new FieldInfo(false, false, true, new PaymentEDT());
            FieldInfoList["OrderID"] = new FieldInfo(true, false, true, new OrderEDT());
            FieldInfoList["Description"] = new FieldInfo(true, false, true, new ShortDescriptionEDT());
            FieldInfoList["Amount"] = new FieldInfo(true, false, true, "Amount", new AmountEDT());

            TableInfo.KeyInfoList["PaymentID"] = new KeyInfo(KeyType.PrimaryField, "PaymentID");
            TableInfo.KeyInfoList["OrderID"] = new KeyInfo(KeyType.Key, "OrderID");

            FieldGroups["grid"] = new String[] { "PaymentID", "OrderID", "Amount", "Description", "CreatedBy", "CreatedDateTime" };
        }

        protected override long insert(bool forceWrite, bool callSaveMethod)
        {
            this.PaymentID = AppFramework.AppClasses.AppEntities.NumberSequences.getNumber("PaymentIDSequence");
            var order = (from o in new QueryableEntity<Order>()
                         where o.OrderID == this.OrderID
                         select o).ToList();
            order[0].Amount += this.Amount;
            order[0].update();
   
            return base.insert(forceWrite, callSaveMethod);
        }
    }
}
