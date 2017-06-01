namespace poc_backend.Models
{
    public class User
    {
        public long id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public virtual Address Address { get; set; }
        

    }
}
