using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDAL
    {
        private static AccountDAL instance;

        public static AccountDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private AccountDAL() { }

        public bool Login(string userName, string passWord)
        {
           

            string query = "UserLogin @UserName , @Password ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord});

            return result.Rows.Count >0;

        }


       public Account GetAccountUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from ACCOUNT where UserName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public bool UpdatePassword(string userName,string pass, string newpass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec UpdatePassword @UserName , @Password , @newPassword ",new object[] { userName, pass, newpass});
            return result > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC GetListAccount");
        }

        public DataTable GetListAccountByTen(string name)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC GetListAccountByTen @TEN", new object[] { name });
        }


        public bool InsertAccount(string username, string ten, string chucvu, int makhoa,  int type)
        {
          
            string query ="EXEC AddAccount @USERNAME , @TEN , @CHUCVU , @MAKHOA , @type";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, ten, chucvu, makhoa, type });

            return result > 0;
        }

        public bool UpdateAccount(string username ,string ten, string chucvu, int makhoa , int type)
        {
            string query = "Exec UpdateAccount @USERNAME , @TEN , @CHUCVU , @MAKHOA , @type";
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[] { username, ten, chucvu, makhoa, type});

            return result > 0;
        }

        public bool DeleteAccount(string id)
        {
            string query = "Exec DeleteAccount @USERNAME";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id});

            return result > 0;
        }

        public bool ResetPassword(string name)
        {
            string query = "Exec ResetPassword @USERNAME";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name });
            return result > 0;
        }
       
      
    }
}
