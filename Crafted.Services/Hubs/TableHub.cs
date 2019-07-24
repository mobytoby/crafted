using Crafted.Data;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Crafted.Services.Hubs
{
    public class TableHub : Hub
    {
        public async Task SendOrder(Order order)
        {
        }
    }
}
