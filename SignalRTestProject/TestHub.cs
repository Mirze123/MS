﻿using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRTestProject
{
    public class TestHub:Hub
    {
        public void Send(string message)
        {
            Clients.All.Send(message);
        }
    }
}