using System.Threading.Tasks;

namespace FranchiseePortal.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}