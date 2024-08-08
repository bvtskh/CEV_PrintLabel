using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLabel.Common
{
    public static class Common
    {
        public static Int32 ConvertDefaultINT(object value)
        {
            Int32 result;
            if (value == null) return 0;
            if(Int32.TryParse(value.ToString(), out result))
            {
                return result;
            }
            return 0;
        }
    }
}
