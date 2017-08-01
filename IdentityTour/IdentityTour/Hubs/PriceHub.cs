using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using IdentityTour.TestDB;

namespace IdentityTour.Hubs
{
    public class PriceHub : Hub
    {
        private TestDbContext DB = new TestDbContext();

        public void Send(string userID, string lotID, string amount)
        {
            /** /
            Betting betting = new Betting() { UserID = userID, LotID = lotID, Amount = amount };
            DB.Bettings.Add(betting);
            DB.SaveChanges();
    /**/
            Clients.All.addNewMessageToPage(userID,  lotID,  amount);
        }
    }
}