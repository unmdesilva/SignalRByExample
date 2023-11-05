using System.Threading.Tasks;
using TheCallCenter.Data.Entities;

namespace TheCallCenter
{
  public interface ICallCenterHub
  {
    Task NewCallReceived(Call newcall);
  }
}