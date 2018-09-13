using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WritersWeb.Data;

namespace WritersWeb.Controller
{
    class Account
    {
        public static int AuthenticateUser(Authenticates.CriteriaInfo criteriaInfo)
        {
            Authenticates authenticate = Authenticates.GetData(criteriaInfo);
            List<object> res = new List<object>((IEnumerable<object>)authenticate);

            if (authenticate.Count > 0)
                return authenticate.Count;
            else
                return 0;
        }

        //public static Authenticates Result(Authenticates.CriteriaInfo criteriaInfo)
        //{
        //    Authenticates authenticate = Authenticates.GetData(criteriaInfo);
        //    return authenticate;
        //}
    }
}
