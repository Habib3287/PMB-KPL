using System;

public class Department
{
    public string name { get; set; }
    public string kode { get; set; }
    public string fakultas { get; set; }
    public int kuota { get; set; }

    public Department(string name, string kode, string fakultas, int kuota)
    {
        this.name = name;
        this.kode = kode;
        this.fakultas = fakultas;
        this.kuota = kuota;
    }
}
