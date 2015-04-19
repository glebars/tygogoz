using Enyim.Caching;
using Enyim.Caching.Memcached;
using Enyim.Caching.Memcached.Results;
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
        static DateTime LastTime = DateTime.MinValue;

        protected void Page_Load(object sender, EventArgs e)
        {
            btnstuff.Click += (s, args) =>
            {
                var melClient = new SmtpClient();
                melClient.Send("postman@tygogoz.apphb.com", "glebars@gmail.com", "Bienvenue tygogoz", "contenu de test");
            };

            btnTestCache.Click += (s, args) =>
            {
                MemcachedClient mc = new MemcachedClient();
                if((DateTime.Now - LastTime) > TimeSpan.FromSeconds(10))
                {
                    LastTime = DateTime.Now;
                    StoreOperationResult storeResults = (StoreOperationResult)mc.ExecuteStore(StoreMode.Set, "foo", LastTime.ToLongTimeString());
                }
                GetOperationResult getResults = (GetOperationResult)mc.ExecuteGet("foo");

                lblTestCache.Text = getResults.Value.ToString();

            };
        }
    }
}