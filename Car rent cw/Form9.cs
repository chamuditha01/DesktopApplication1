using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Car_rent_cw
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string accountSid = "your_account_sid";
            const string authToken = "your_auth_token";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Hello, this is a test message!",
                from: new PhoneNumber("whatsapp:+740459715"),  
                to: new PhoneNumber("whatsapp:+714230951")   
            );
        }
    }
}
