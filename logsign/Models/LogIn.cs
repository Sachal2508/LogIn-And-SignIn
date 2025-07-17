using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace logsign.Models
{
    public class LogIn : SignData
    {
        private string email = "";
        private string password = "";

        public string Email { get => email; set => email = value; }
        public string Password1 { get => password; set => password = value; }
    }
}
