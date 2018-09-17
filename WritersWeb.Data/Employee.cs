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
    public class Employee : WorkingBase<TestTemplate>
    {
        #region Properties
        
        public int IdEmployee { get; set; }
        public string EmpFirstname { get; set; }
        public string EmpLastname { get; set; }
        public string EmpMiddlename { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Usertype { get; set; }
        public string PhoneName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int IdSecGroupRights { get; set; }
        public string ModifiedBy { get; set; }
        
        public bool IsActive { get; set; }
        public bool IsResigned { get; set; }


        #endregion

        #region Factory Methods

        private Employee(Csla.Data.SafeDataReader dr)
        {
            Fetch(dr);
        }

        static internal Employee GetData(Csla.Data.SafeDataReader dr)
        {
            return new Employee(dr);
        }

        public Employee() { }

        #endregion

        #region Data Access

        private void Fetch(Csla.Data.SafeDataReader dr)
        {
            //IdTest = dr.GetInt32("");       //  inside "" is from sp column returned
            //TestName = dr.GetString("");

            //Mark this data as persisted in the data store
            MarkOld();
        }

        internal void Insert(SqlConnection con)
        {
            // Create command object for fetching of data from the datastore
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spWWEmployeeInsertUpdate";
                cmd.CommandTimeout = DatabaseManager.SqlCommandTimeout();

                // Add parameters to the executing command object
                cmd.Parameters.AddWithValue("@isNew", true);
                cmd.Parameters.AddWithValue("@isNew", true);
                cmd.Parameters.AddWithValue("@isNew", true);
                cmd.Parameters.AddWithValue("@isNew", true);
                cmd.Parameters.AddWithValue("@isNew", true);
                cmd.Parameters.AddWithValue("@isNew", true);
                cmd.Parameters.AddWithValue("@isNew", true);
                cmd.Parameters.AddWithValue("@isNew", true);
                cmd.Parameters.AddWithValue("@isNew", true);


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
