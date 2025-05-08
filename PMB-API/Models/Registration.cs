using System;

public class Registration
{
    public string name { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string address { get; set; }
    public string birthdate { get; set; }
    public string password { get; set; }
    
    publlic Registration(string name, string email, string phone, string address, string birthdate, string password)
    {
        this.name = name;
        this.email = email;
        this.phone = phone;
        this.address = address;
        this.birthdate = birthdate;
        this.password = password;
    }

}
