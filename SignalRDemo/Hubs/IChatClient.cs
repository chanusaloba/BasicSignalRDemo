using System.Threading.Tasks;

namespace SignalRDemo.Hubs
{
    public interface IChatClient
    {
        Task ReceiveMessage(string user, string message);
    }
}
