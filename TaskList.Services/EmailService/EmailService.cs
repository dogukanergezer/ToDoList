using System;
using System.Threading.Tasks;

namespace TaskList.Services.EmailService
{
    public class EmailService : IEmailService
    {
        public Task SendEmailAsync(string ToEmail, string FromName, string Subject, string Message)
        {
            throw new NotImplementedException();//
        }
    }
}
