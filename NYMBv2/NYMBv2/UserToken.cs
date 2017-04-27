using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NYMBv2
{ 

public class UserToken
{

    public string UserName { get; set; }

    public string Password { get; set; }

    public int UserLevel { get; set; }
    

    public bool IsValid()
    {
        using (SqlConnection cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Aloquin\Source\Repos\NYMBv2\NYMBv2\NYMBv2\NYMBv2_DB.mdf; Integrated Security = True"))
        {
            string _sql = @"SELECT [UserLevel] FROM [dbo].[USER_TABLE] " +
                   @"WHERE [UserName] = @u AND [Password] = @p";
            SqlCommand cmd = new SqlCommand(_sql, cn);
            cmd.Parameters
                .Add(new SqlParameter("@u", SqlDbType.NVarChar))
                .Value = UserName;
            cmd.Parameters
                .Add(new SqlParameter("@p", SqlDbType.NVarChar))
                .Value = Password;
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                    
                UserLevel = reader.GetInt32(0);
                reader.Dispose();
                cmd.Dispose();
                return true;
            }
            else
            {
                reader.Dispose();
                cmd.Dispose();
                return false;
            }
        }
    }

    public UserToken(String un, String Pw)
	{

        UserName = un;
        Password = Pw;
	}
}
}
