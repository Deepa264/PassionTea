using EnumsNET;
using PassionTea.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.Utilities
{
    static class EnumHelper
    {
        public static String GetnumDescription(CardType value)
        {
        var fieldInfo = value.GetType().GetField(value.ToString());
        DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
        if(attributes!=null && attributes.Length>0 )
            {

            return attributes[0].Description;
             }
    else
        {
    return value.ToString();
        }
}

}

}



