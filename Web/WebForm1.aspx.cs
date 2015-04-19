using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnstuff.Click += (s, args) => {
                var melClient = new SmtpClient();
                melClient.Send("postman@tygogoz.apphb.com", "glebars@jadeworld.com; glebars@gmail.com", "Bienvenue tygogoz", "contenu de test");
            };
        }
    }
}