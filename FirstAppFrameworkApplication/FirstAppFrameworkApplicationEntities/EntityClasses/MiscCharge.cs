using AppFramework.AppClasses;
using AppFramework.AppClasses.EDTs;
using FirstAppFrameworkApplicationEntities.EDTs;
using FirstAppFrameworkApplicationEntities.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppFrameworkApplicationEntities.EntityClasses
{
    partial class MiscCharge : EntityBase
    {
        protected override string Caption
        {
            get { return "Deductions"; }
        }

        protected override Type FormType
        {
            get { return typeof(MiscCharges); }
        }

        protected override Type ListFormType
        {
            get { return typeof(MiscCharges); }
        }

        public override string TableName
        {
            get { return "deductions"; }
        }

        protected override string TitleColumn1
        {
            get { return "DeductionID"; }
        }

        protected override string TitleColumn2
        {
            get { return "Description"; }
        }

        protected override void setupEntityInfo()
        {
            FieldInfoList["DeductionID"] = new FieldInfo(true, false, true, new MiscChargeEDT());
            FieldInfoList["Description"] = new FieldInfo(true, true, true, new ShortDescriptionEDT());
            FieldInfoList["DeductionType"] = new FieldInfo(true, true, true, new MiscChargeTypeEDT());
            FieldInfoList["Value"] = new FieldInfo(true, true, true, "Value", new AmountEDT());

            TableInfo.KeyInfoList["DeductionID"] = new KeyInfo(KeyType.PrimaryField, "DeductionID");
        }

        protected override long insert(bool forceWrite, bool callSaveMethod)
        {
            //this.DeductionID = AppFramework.AppClasses.AppEntities.NumberSequences.getNumber("DeductionIDSequence");
            
            return base.insert(forceWrite, callSaveMethod);
        }
    }
}
