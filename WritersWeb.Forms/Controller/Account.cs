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
        public static bool AuthenticateUser(Authenticates.CriteriaInfo criteriaInfo)
        {
            Authenticates authenticate = Authenticates.GetData(criteriaInfo);

            if (authenticate.Count > 0)
                return true;
            else
                return false;
        }

        public static List<object> AuthResult(Authenticates.CriteriaInfo criteriaInfo)
        {
            Authenticates authenticate = Authenticates.GetData(criteriaInfo);
            List<object> res = new List<object>((IEnumerable<object>)authenticate);
            return res;
        }
    }
}
    