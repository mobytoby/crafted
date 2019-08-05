using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Crafted.Services.Hubs
{
    public class TableHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
