namespace Crm.DataAccess;
public interface IClientRepository
{   
    bool Create(Client client);
    bool GetClient(string firstName, string lastName);
    bool DeleteClient(long clientId);
    bool EditClient(long Id, string NewFirstName, string NewLastName);

    //Stat service
    int ClientCount();
}