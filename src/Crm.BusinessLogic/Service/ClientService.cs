using Crm.DataAccess;
namespace Crm.BusinessLogic;


public sealed class ClientService : IClientService
{
    public readonly IClientRepository _clientRepository;

    
    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }



    public bool Create(Client client)
    {
        return _clientRepository.Create(client);
    }

    public bool GetClient(string firstName, string lastName)
    {  
        return _clientRepository.GetClient(firstName, lastName);
    }

    public bool DeleteClient(long clientid)
    {
        return _clientRepository.DeleteClient(clientid);
    }

    public bool EditClient(long Id, string NewFirstName, string NewLastName)
    {
        return _clientRepository.EditClient(Id, NewFirstName, NewLastName);
    }
}
