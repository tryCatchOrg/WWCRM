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
    public class TestTemplates : WorkingListBase<TestTemplates, TestTemplate>
    {
        #region Constructor

        private TestTemplates() { }

        #endregion

        #region Factory Methods

        public static TestTemplates CreateInstance()
        {
            return new TestTemplates();
        }

        public static TestTemplates GetData(CriteriaInfo criteriaInfo)
        {
            TestTemplates obj = new TestTemplates();
            obj.DataFetch(new Criteria(criteriaInfo));
            return obj;
        }

        public static int UpdateData(CriteriaInfo criteriaInfo, bool isNew)
        {
            var criteria = new Criteria(criteriaInfo);

            using (SqlConnection con = new SqlConnection(DatabaseManager.GetConnectionString("WWConString")))
            {
                con.Open();

                TestTemplate newItem = new TestTemplate();

                newItem.IdTest = criteria.CriteriaInfo.IdTest;
                newItem.TestName = criteria.CriteriaInfo.TestName;

                if (isNew)
                {
                    newItem.Insert(con);
                    return newItem.IdTest;
                }
                else
                {
                    newItem.IdTest = criteria.CriteriaInfo.IdTest;
                    newItem.Update(con);
                    return 0;
                }
            }
        }

        public static void DeleteData(CriteriaInfo criteriaInfo)
        {
            TestTemplates obj = new TestTemplates();

            var criteria = new Criteria(criteriaInfo);
            using (SqlConnection con = new SqlConnection(DatabaseManager.GetConnectionString("")))
            {
                con.Open();
                TestTemplate itemToDelete = new TestTemplate();
                itemToDelete.IdTest = criteria.CriteriaInfo.IdTest;
                itemToDelete.Delete(con);
            }
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
            public int IdTest { get; set; }
            public string TestName { get; set; }

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
                    cmd.CommandText = "spDataFetch";
                    cmd.CommandTimeout = DatabaseManager.SqlCommandTimeout();

                    cmd.Parameters.AddWithValue("@Id", criteria.CriteriaInfo.IdTest);
                    cmd.Parameters.AddWithValue("@Name", criteria.CriteriaInfo.TestName);

                    using (Csla.Data.SafeDataReader dr = new Csla.Data.SafeDataReader(cmd.ExecuteReader()))
                    {
                        while (dr.Read())
                        {
                            this.Add(TestTemplate.GetData(dr));
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
            //throw new NotImplementedException();
            using (SqlConnection con = new SqlConnection(DatabaseManager.GetConnectionString("WWConString")))
            {
                // Open Connection
                con.Open();

                // loop through the object to add and update, calling the Insert and Update method
                foreach (TestTemplate item in this)
                {
                    if (item.IsNew)
                        item.Insert(con);
                    else
                        item.Update(con);
                }
            }
        }

        protected override void DataDelete()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
