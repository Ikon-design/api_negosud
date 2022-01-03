namespace api_negosud.Models
{
    public class Client
    {
        public long Id { get; set; }
        public string LName { get; set; } = "";
        public string FName { get; set; } = "";
        public string Mail { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
        public string DeliveryAddress { get; set; } = "";

       /* public Client(string lName, string fName, string mail, string phone, string address, string delivryAddress)
        {
            Id = Guid.NewGuid();
            LName = lName;
            FName = fName;
            Mail = mail;
            Phone = phone;
            Address = address;
            DeliveryAddress = delivryAddress;
        }*/
    }
}
