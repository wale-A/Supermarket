//DO NOT MODIFY THIS FILE
//Instead, override the this[] indexer in your entity base class
using System;
using AppFramework.AppClasses;
namespace FirstAppFrameworkApplicationEntities.EntityClasses
{
    partial class MiscCharge
    {
        [System.ComponentModel.DataAnnotations.Display(Name = "Charge ID", Order = 0)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please fill in Charge ID")]
        [System.ComponentModel.DataAnnotations.Editable(false, AllowInitialValue = true)]
        [AppFramework.AppClasses.Autogenerated]
        public virtual String DeductionID
        {
            get
            {
                return this.getString("DeductionID");
            }
            set
            {
                this["DeductionID"] = value;
            }
        }

        [System.ComponentModel.DataAnnotations.Display(Name = "Short Description", Order = 1)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please fill in Short Description")]
        [System.ComponentModel.DataAnnotations.Editable(true, AllowInitialValue = true)]
        [AppFramework.AppClasses.Autogenerated]
        public virtual String Description
        {
            get
            {
                return this.getString("Description");
            }
            set
            {
                this["Description"] = value;
            }
        }

        [System.ComponentModel.DataAnnotations.Display(Name = "Charge Type", Order = 2)]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please fill in Charge Type")]
        [System.ComponentModel.DataAnnotations.Editable(true, AllowInitialValue = true)]
        [AppFramework.AppClasses.Autogenerated]
        public virtual FirstAppFrameworkApplicationEntities.EntityEnums.DeductionType DeductionType
        {
            get
            {
                return (FirstAppFrameworkApplicationEntities.EntityEnums.DeductionType)this.getEnum("DeductionType");
            }
            set
            {
                this["DeductionType"] = value;
            }
        }

        [System.ComponentModel.DataAnnotations.Display(Name = "Value", Order = 3)]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please fill in Value")]
        [System.ComponentModel.DataAnnotations.Editable(true, AllowInitialValue = true)]
        [AppFramework.AppClasses.Autogenerated]
        public virtual decimal Value
        {
            get
            {
                return this.getReal("Value");
            }
            set
            {
                this["Value"] = value;
            }
        }

        [System.ComponentModel.DataAnnotations.Display(Name = "Default", Order = 4)]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please fill in Default")]
        [System.ComponentModel.DataAnnotations.Editable(true, AllowInitialValue = true)]
        [AppFramework.AppClasses.Autogenerated]
        public virtual bool Default
        {
            get
            {
                return this.getBoolean("Default");
            }
            set
            {
                this["Default"] = value;
            }
        }

        [System.ComponentModel.DataAnnotations.Display(Name = "Charge Index", Order = 5)]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please fill in Charge Index")]
        [System.ComponentModel.DataAnnotations.Editable(true, AllowInitialValue = true)]
        [AppFramework.AppClasses.Autogenerated]
        public virtual int ChargeOrder
        {
            get
            {
                return this.getInteger("ChargeOrder");
            }
            set
            {
                this["ChargeOrder"] = value;
            }
        }

    }
}
