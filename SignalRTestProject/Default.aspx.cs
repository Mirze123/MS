using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SignalRTestProject
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            var notificationHubContext = GlobalHost.ConnectionManager.GetHubContext<TestHub>();
            string message = "New notification for everyone!";
            notificationHubContext.Clients.All.receiveNotification(message);
        }
    }
}