using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net;
using System.Net.Mail;

namespace MandandoEmails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoEnviaEmail_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.office365.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true; //Questões de segurança
                smtpClient.Credentials = new NetworkCredential("mbdemmer@furb.br", "naofuiproITAf4zroq");
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("mbdemmer@furb.br");
                mailMessage.To.Add(new MailAddress("mbdemmer@furb.br"));
                mailMessage.Subject = "Meu primeiro email";
                mailMessage.Body = "Olá. Este é o meu primeiro email enviado pelo c#!";
                mailMessage.IsBodyHtml = false;

                smtpClient.Send(mailMessage);
            }catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);   
            }

        }

        private void botaoEnviaAnexo_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.office365.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true; //Questões de segurança
                smtpClient.Credentials = new NetworkCredential("mbdemmer@furb.br", "naofuiproITAf4zroq");
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("mbdemmer@furb.br");
                mailMessage.To.Add(new MailAddress("mbdemmer@furb.br"));
                mailMessage.Subject = "Meu primeiro email";
                mailMessage.Body = "Olá. Este é o meu primeiro email enviado pelo c#!";
                mailMessage.IsBodyHtml = false;

                Attachment arquivoAnexo = new Attachment(@"d:\Teste2.txt");
                mailMessage.Attachments.Add(arquivoAnexo);

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void botaoEnviaImagem_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.office365.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true; //Questões de segurança
                smtpClient.Credentials = new NetworkCredential("mbdemmer@furb.br", "naofuiproITAf4zroq");
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("mbdemmer@furb.br");
                mailMessage.To.Add(new MailAddress("mbdemmer@furb.br"));
                mailMessage.Subject = "Meu primeiro email";
                string body = "Olá. Este é o meu primeiro email enviado pelo c#!";
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = false;

                string caminhoImagem = @"D:\C-Course\source\repos\Image&MediaElementWPF\mirage.jpg";
                LinkedResource imagemLinkada = new LinkedResource(caminhoImagem);
                imagemLinkada.ContentId = "Simbolo";

                AlternateView html = AlternateView.CreateAlternateViewFromString
                    ($"{body}<br><img src=cid:Simbolo>", null, "text/html");
                html.LinkedResources.Add(imagemLinkada);
                mailMessage.AlternateViews.Add(html);

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
