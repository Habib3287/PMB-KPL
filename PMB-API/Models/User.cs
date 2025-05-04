using System;

public class User
{
    public string name { get; set; }
    public string email { get; set; }
    public string phoneNumber { get; set; }
    public string address { get; set; }
    public Date tglLahir { get; set; }

    public User(string name, string email, string phoneNumber, string address, Date tglLahir)
    {
        this.name = name;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.address = address;
        this.tglLahir = tglLahir;
    }
}
