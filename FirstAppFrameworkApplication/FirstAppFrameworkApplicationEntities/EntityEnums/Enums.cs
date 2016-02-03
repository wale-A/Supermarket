using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppFrameworkApplicationEntities.EntityEnums
{
    internal enum Payment
    {
        Cash,
        Card,
        Credit
    };

    public enum DeductionType
    {
        Fixed,
        Percentage
    }

    public enum MiscChargeOrder
    {
        One,
        Two,
        Three,
        Four
    }
}
