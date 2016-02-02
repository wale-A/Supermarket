using AppFramework.AppClasses;
using AppFramework.AppClasses.EDTs;
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
    partial class Discount : EntityBase
    {
        protected override string Caption
        {
            get { return "Discount"; }
        }

        protected override Type FormType
        {
            get { return typeof(Discounts); }
        }

        protected override Type ListFormType
        {
            get { return typeof(Discounts); }
        }

        public override string TableName
        {
            get { return "discount"; }
        }

        protected override string TitleColumn1
        {
            get { return "DiscountID"; }
        }

        protected override string TitleColumn2
        {
            get { return "Description"; }
        }

        protected override void setupEntityInfo()
        {
            FieldInfoList["DiscountID"] = new FieldInfo(true, false, true, new DiscountEDT());
            FieldInfoList["Description"] = new FieldInfo(true, true, true, new ShortDescriptionEDT());
            FieldInfoList["DiscountType"] = new FieldInfo(true, true, true, "DiscountType", typeof(DeductionType));
            FieldInfoList["Value"] = new FieldInfo(true, true, true, "Value", new AmountEDT());
        }
    }
}
