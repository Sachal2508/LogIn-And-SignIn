namespace logsign.Models
{
    public class SignData
    {
        private string name = "";
        private string id = "";
        private string password = "";

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }
    }
}
