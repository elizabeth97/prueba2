using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Usuer
/// </summary>
public class User
{
    protected String name { get; set; }
    protected String lastName { get; set; }
    protected String email { get; set; }
    protected String birthday { get; set; }
    protected int level { get; set; }
    protected String userName { get; set; }
    protected String password { get; set; }

    public User (String name, String lastName, String email, String birthday, int level, String userName, String password)
    {
        name = this.name;
        lastName = this.lastName;
        email = this.email;
        birthday = this.birthday;
        level = this.level;
        userName = this.userName;
        password = this.password;
    }
}