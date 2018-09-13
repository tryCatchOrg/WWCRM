using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WritersWeb.Base;

namespace WritersWeb.Data
{
    public class Authenticates : WorkingListBase<Authenticates, Authenticate>
    {
        #region Constructor

        private Authenticates() { }

        #endregion

        #region Factory Methods

        public static Authenticates CreateInstance()
        {
            return new Authenticates();
        }

        public static Authenticates GetData(CriteriaInfo criteriaInfo)
        {
            Authenticates obj = new Authenticates();
            obj.DataFetch(new Criteria(criteriaInfo));
            return obj;
        }

        #endregion

        #region Criteria/CriteriaInfo Class

        private class Criteria
        {
            public CriteriaInfo CriteriaInfo { get; set; }

            public Criteria(CriteriaInfo criteriaInfo)
            {
                CriteriaInfo = criteriaInfo;
            }

            public Criteria() { }
        }

        public class CriteriaInfo
        {
            public string Username { get; set; }
            public string Password { get; set; }

            public static CriteriaInfo NewCriteriaInfo()
            {
                return new CriteriaInfo();
            }

            public CriteriaInfo() { }
        }

        #endregion

        #region Data Access

        private void DataFetch(Criteria criteria)
        {
            using (SqlConnection con = new SqlConnection(DatabaseManager.GetConnectionString("WWConString")))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spWWAuthenticateUser";
                    cmd.CommandTimeout = DatabaseManager.SqlCommandTimeout();

                    cmd.Parameters.AddWithValue("@username", criteria.CriteriaInfo.Username);
                    cmd.Parameters.AddWithValue("@password", criteria.CriteriaInfo.Password);

                    using (Csla.Data.SafeDataReader dr = new Csla.Data.SafeDataReader(cmd.ExecuteReader()))
                    {
                        while (dr.Read())
                        {
                            this.Add(Authenticate.GetData(dr));
                        }
                    }
                }
            }
        }

        private bool HandleNullValue(string value)
        {
            return (!string.IsNullOrEmpty(value)) ? true : false;
        }

        protected override void DataUpdate()
        {
            throw new NotImplementedException();
        }

        protected override void DataDelete()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
