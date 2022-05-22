namespace TestDapper.Controller
{
    public class JsonModel
    {
        public JsonModel(string Source = "SQL5104.site4now.net", 
            string Port = "1433",
            string DatabaseName = "db_a8501a_dima",
            string UserId = "db_a8501a_dima_admin", string Password = "qwerty123")
        {
            this.Source = Source;
            this.Port = Port;
            this.DatabaseName = DatabaseName;
            this.UserId = UserId;
            this.Password = Password;
        }

        public string? Source { get; set; }
        public string? Port { get; set; }
        public string? DatabaseName { get; set; }
        public string? UserId { get; set; }
        public string? Password { get; set; }

        public override string ToString()
        {
            return $"Source: {Source}, Port: {Port}, DatabaseName: {DatabaseName}, UserId: {UserId}, Password: {Password}";
        }
    }
}