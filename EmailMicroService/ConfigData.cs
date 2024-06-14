namespace EmailMicroService
{
    public class Config
    {
        public ConnectionStrings ConnectionStrings { get; set; }
        public SMTP SMTP { get; set; }
    }

    public class ConnectionStrings
    {
        public string DefaultConnection { get; set; }
    }

    public class SMTP
    {
        public string Server { get; set; }
        public string Port { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
