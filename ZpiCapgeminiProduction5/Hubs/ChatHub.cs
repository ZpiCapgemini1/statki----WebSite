using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ZpiCapgeminiProduction5.Hubs
{
    public static class UserHandler
    {
        public static HashSet<string> ConnectedIds = new HashSet<string>();
    }

    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // for all users
            Clients.All.addNewMessageToPage(name, message);
        }


        public override Task OnConnected()
        {
            UserHandler.ConnectedIds.Add(Context.ConnectionId);
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            UserHandler.ConnectedIds.Remove(Context.ConnectionId);
            return base.OnDisconnected(stopCalled);
        }
    }
}