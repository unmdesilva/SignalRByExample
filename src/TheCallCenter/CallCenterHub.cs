using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using TheCallCenter.Data.Entities;

namespace TheCallCenter
{
  public class CallCenterHub:Hub
  {
    public async Task NewCallReceived(Call newcall)
    {
      await Clients.All.SendAsync("NewCallRecived", newcall);
    }
  }
}