using System.Threading.Tasks;

namespace TaskList.Services.EmailService
{
    public interface IEmailService
    {
        Task SendEmailAsync(string ToEmail, string FromName, string Subject, string Message);//
    }
}
