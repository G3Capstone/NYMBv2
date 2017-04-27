using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NYMBv2
{ 

public class UserToken
{

    [Required]
    [Display(Name = "User name")]
    public string UserName { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }
    

    public bool IsValid(string _username, string _password)
    {
        using (var cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Aloquin\Source\Repos\NYMBv2\NYMBv2\NYMBv2\NYMBv2_DB.mdf; Integrated Security = True"))
        {
            string _sql = @"SELECT [Username] FROM [dbo].[USER_TABLE] " +
                   @"WHERE [Username] = @u AND [Password] = @p";
            var cmd = new SqlCommand(_sql, cn);
            cmd.Parameters
                .Add(new SqlParameter("@u", SqlDbType.NVarChar))
                .Value = _username;
            cmd.Parameters
                .Add(new SqlParameter("@p", SqlDbType.NVarChar))
                .Value = _password;
            cn.Open();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
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
