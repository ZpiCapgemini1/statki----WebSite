using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using ZpiCapgeminiProduction5.Models;

namespace ZpiCapgeminiProduction5.Hubs
{


    public class ChatHub : Hub
    {
        public static List<UserDetail> ConnectedUsers = new List<UserDetail>();


        public void SendPrivateMessage(string toUserName, string message)
        {

            string fromUserId = Context.ConnectionId;
            var userDetail = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == fromUserId);
            var firstOrDefault = ConnectedUsers.FirstOrDefault(x => x.UserName == toUserName);

            if (userDetail != null)
            {
                var fromUserName = userDetail.UserName;

                if (firstOrDefault != null)
                {
                    var toUserId = firstOrDefault.ConnectionId;

                    // send to 
                    Clients.Client(toUserId).addNewMessageToPage(fromUserName, message);
                }
            }
        }




        public void Send(string name, string message)
        {
            // for all users
            Clients.All.addNewMessageToPage(name, message);
        }



        public void AddUser(string name)
        {
            var newUser = new UserDetail
            {
                UserName = name,
                ConnectionId = Context.ConnectionId
            };
            ConnectedUsers.Add(newUser);
        }

        public override Task OnConnected()
        {


            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            var item = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == Context.ConnectionId);
            if (item != null)
            {
                ConnectedUsers.Remove(item);

                var id = Context.ConnectionId;
                Clients.All.onUserDisconnected(id, item.UserName);

            }
            return base.OnDisconnected(stopCalled);
        }
    }
}