using Microsoft.AspNetCore.SignalR;
using RealPromo.Web.Models;
using System.Threading.Tasks;

namespace RealPromo.Web.Hubs
{
    public class PromoHub : Hub
    {
        public async Task CreatePromotion(Promotion promotion)
        {
            await Clients.Caller.SendAsync("createdSuccessfully");
            await Clients.Others.SendAsync("receivedPromotion", promotion);
        }
    }
}
