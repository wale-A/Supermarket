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
    public partial class Customers : EntityBase
    {
        const string NUMBERSEQUENCE = "CustomerIDSequence";
        protected override string Caption
        {
            get { return "Customers"; }
        }
        protected override Type FormType
        {
            get { return typeof(Forms.Customers); }
        }
        protected override Type ListFormType
        {
            get { throw new NotImplementedException(); }
        }
        public override string TableName
        {
            get { return "customers"; }
        }
        protected override string TitleColumn1
        {
            get { return "CustomerID"; }
        }
        protected override string TitleColumn2
        {
            get { return "Name"; }
        }
        protected override void setupEntityInfo()
        {
            FieldInfoList["CustomerID"] = new FieldInfo(false, false, true, new CustomerEDT());
            FieldInfoList["Name"] = new FieldInfo(true, true, true, "Name", new ShortDescriptionEDT());
            FieldInfoList["Money"] = new FieldInfo(false, true, true, "Money", new AmountEDT());

            TableInfo.KeyInfoList["CustomerID"] = new KeyInfo(KeyType.PrimaryField, "CustomerID");
        }
        protected override long insert(bool forceWrite, bool callSaveMethod)
        {
            this.CustomerID = AppFramework.AppClasses.AppEntities.NumberSequences.getNumber(NUMBERSEQUENCE);
            this.Money = 0;

            return base.insert(forceWrite, callSaveMethod);
        }
    }
}