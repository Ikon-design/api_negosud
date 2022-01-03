namespace api_negosud.Models;

public class Contact
{
    public long Id { get; set; }
    public string FName { get; set; } = "";
    public string LName { get; set; } = "";
    public string Mail { get; set; } = "";
    public string Phone { get; set; } = "";

    //public ContactClass(string fName, string lName, string mail, string phone)
    //{
    //    Id = Guid.NewGuid();
    //    FName = fName;
    //    LName = lName;
    //    Mail = mail;
    //    Phone = phone;
    //}
}
