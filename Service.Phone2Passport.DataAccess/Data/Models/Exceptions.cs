using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Phone2Passport.DataAccess.Data.Models
{
    public class MyExceptions
    {
        public Client client;
        public string DescriptionException;
        public bool isFatal;
        public MyExceptions(Client _client, string _DescriptionException, bool _isFatal)
        {
            client = _client;
            DescriptionException = _DescriptionException;
            isFatal = _isFatal; 

        }
    }
}
