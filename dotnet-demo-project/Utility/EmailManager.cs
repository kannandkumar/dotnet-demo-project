using System.Text.RegularExpressions;

namespace dotnet_demo_project.Utility
{
    public class EmailManager
    {
        public bool IsValidAddress(string emailAddress)
        {
            Regex regex = new Regex(@"^[\w0-9._%+-]+@[\w0-9.-]+\.[\w]{2,6}$");
            return regex.IsMatch(emailAddress);
        }
    }
}
