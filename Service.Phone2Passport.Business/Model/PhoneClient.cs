using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Phone2Passport.Business.Model
{
    internal class PhoneClient
    {
        public string Number 
        {
            get
            {
                return Number;
            }
            set
            {
                // ФОРМАЛИЗУЕМ номер телефона к стандартному типу
                string KK = value.ToString();
                KK = KK.Replace("+", "");
                KK = KK.Replace("(", "");
                KK = KK.Replace(")", "");
                KK = KK.Replace("-", "");
                KK = KK.Replace(".", "");
                KK = KK.Trim(' ');
                Number = KK;
            } 
        }
    }
}
