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
    public class TestTemplate : WorkingBase<TestTemplate>
    {
        #region Properties

        public int IdTest { get; set; }
        public string TestName { get; set; }

        #endregion

        #region Factory Methods

        private TestTemplate(Csla.Data.SafeDataReader dr)
        {
            Fetch(dr);
        }

        static internal TestTemplate GetData(Csla.Data.SafeDataReader dr)
        {
            return new TestTemplate(dr);
        }

        public TestTemplate() { }

        #endregion

        #region Data Access

        private void Fetch(Csla.Data.SafeDataReader dr)
        {
            IdTest = dr.GetInt32("");       //  inside "" is from sp column returned
            TestName = dr.GetString("");

            //Mark this data as persisted in the data store
            MarkOld();
        }

        internal void Insert(SqlConnection con)
        {
            // Create command object for fetching of data from the datastore
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spInsert";
                cmd.CommandTimeout = DatabaseManager.SqlCommandTimeout();

                // Add parameters to the executing command object
                cmd.Parameters.AddWithValue("Id", 0);

                // execute the commad object
                cmd.ExecuteNonQuery();

                // mark this data as persisted in the datastore
                MarkOld();
            }
        }

        internal void Update(SqlConnection con)
        {
            // Create command object for fetching of data from the datastore
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spUpdate";
                cmd.CommandTimeout = DatabaseManager.SqlCommandTimeout();

                // Add parameters to the executing command object
                cmd.Parameters.AddWithValue("Id", 0);

                // execute the commad object
                cmd.ExecuteNonQuery();

                // mark this data as persisted in the datastore
                MarkOld();
            }
        }

        internal void Delete(SqlConnection con)
        {
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spDelete";
                cmd.CommandTimeout = DatabaseManager.SqlCommandTimeout();

                // execute the commad object
                cmd.ExecuteNonQuery();
            }
        }

        #endregion
    }
}
