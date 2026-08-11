using BaseProject.Shared.Responses;

namespace BaseProject.Backend.Helpers;

public interface IMailHelper
{
    ActionResponse<string> SendMail(string toName, string toEmail, string subject, string body);
}