using Newtonsoft.Json;
using RestSharp;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace SingleResponsibilityPrinciple
{
    public class Email_DoesALot
    {
        public static async void DoesALot(string message, string emailAddress)
        {
            //get credentials and obtain auth
            var cred = System.Environment.GetEnvironmentVariable("emailCredential");
            var base64EncodedBytes = System.Convert.FromBase64String(cred);
            var encondedString = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            var client = new RestClient("https://someAuthEndPoint");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "...", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var auth = JsonConvert.DeserializeObject<Auth>(response.Content);
            //validate email address
            //this validation is obviously just nonsense
            bool IsValid = true;
            if (string.IsNullOrWhiteSpace(emailAddress)) IsValid = false;
            if (!emailAddress.Contains("@")) IsValid = false;
            if (IsValid)
            {
                //send the email
                var apiKey = System.Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
                var sgclient = new SendGridClient(apiKey);
                var from = new EmailAddress("noreply@nowhere.net", "Example User");
                var subject = "Sending an Email";
                var to = new EmailAddress(emailAddress, "Example User");
                var plainTextContent = message;
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, null);
                await sgclient.SendEmailAsync(msg).ConfigureAwait(false);
            }
        }
    }

    public class Email_SRP
    {
        //get credentials and obtain auth
        public static Auth GetAuth()
        {
            var cred = System.Environment.GetEnvironmentVariable("emailCredential");
            var base64EncodedBytes = System.Convert.FromBase64String(cred);
            var encondedString = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            var client = new RestClient("https://someAuthEndPoint");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "...", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<Auth>(response.Content);
        }

        //validate the email address
        public static bool ValidateEmail(string emailAddress)
        {
            //validate email address
            //this validation is obviously just nonsense
            if (string.IsNullOrEmpty(emailAddress)) return false;
            if (!emailAddress.Contains("@")) return false;
            return true;
        }

        //send the email
        public static async void SendEmail(string emailAddress, string message)
        {
            var apiKey = System.Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var sgclient = new SendGridClient(apiKey);
            var from = new EmailAddress("noreply@nowhere.net", "Example User");
            var subject = "Sending an Email";
            var to = new EmailAddress(emailAddress, "Example User");
            var plainTextContent = message;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, null);
            await sgclient.SendEmailAsync(msg).ConfigureAwait(false);
        }
    }

    public class Auth
    {
        public string token { get; set; }
    }
}