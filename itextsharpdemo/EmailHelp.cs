using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace itextsharpdemo
{
    public class EmailHelp
    {        
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="mailTo">要发送的邮箱</param>
        /// <param name="mailSubject">邮箱主题</param>
        /// <param name="mailContent">邮箱内容</param>
        /// <returns>返回发送邮箱的结果</returns>
        public static bool SendEmail(string mailTo, string mailSubject, string mailContent,string attachmentPath="")
        {            
            // 邮件服务设置
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Host = "mail.l1y.com"; //指定SMTP服务器  
            smtpClient.Port = 25;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new System.Net.NetworkCredential("tww24098", "Tangweiwei1234567");//用户名和密码

            // 发送邮件设置       
            MailMessage mailMessage = new MailMessage(); // 发送人和收件人
            mailMessage.From = new MailAddress("tww24098@l1y.com");
            mailMessage.To.Add(mailTo);
            mailMessage.Subject = mailSubject;//主题
            mailMessage.Body = mailContent;//内容
            mailMessage.BodyEncoding = Encoding.UTF8;//正文编码
            mailMessage.IsBodyHtml = true;//设置为HTML格式
            mailMessage.Priority = MailPriority.Low;//优先级               
            if (!string.IsNullOrEmpty(attachmentPath))
            {
                System.Net.Mail.Attachment myAttachment = new System.Net.Mail.Attachment(attachmentPath);
                mailMessage.Attachments.Add(myAttachment);
            }
            
            try
            {
                smtpClient.Send(mailMessage); // 发送邮件
                return true;
            }
            catch (SmtpException ex)
            {
                return false;
            }
        }
    }
}