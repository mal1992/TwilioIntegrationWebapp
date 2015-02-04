using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using Twilio;
namespace TwilioWebAPP_SMS
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void SendMessage_OnClick()
        {
            string ACCOUNT_ID = "AC0fe6b30e4caba008476174e49fb868af";
            string AUTH_TOKEN = "e0b98f8ab5c8df323b4cc277d9ff5340";

            TwilioRestClient client = new TwilioRestClient(ACCOUNT_ID, AUTH_TOKEN);
            client.SendSmsMessage("(650) 651-4864", ToNumberr.ToString(), Messagetxt.ToString());
        }
    }
}