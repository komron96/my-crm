namespace Crm.DataAccess;
public interface IClientRepository
{   
    //Main methods of Client
    bool Create(Client client);
    bool GetClient(string firstName, string lastName);
    bool DeleteClient(long ClientId);
    bool EditClient(long Id, string NewFirstName, string NewLastName);

    //Stat service
    int ClientCount();
}