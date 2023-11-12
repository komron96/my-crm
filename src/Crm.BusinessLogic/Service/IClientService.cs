using Crm.DataAccess;
namespace Crm.BusinessLogic;

public interface IClientService
{
    ClientInfo Create(Client cleint);
    bool GetClient(string firstName, string lastName);
    bool DeleteClient(long clientid);
    bool EditClient(long clientId, string NewFirstName, string NewLastName);
}
