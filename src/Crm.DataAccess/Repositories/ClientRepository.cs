using System.Security.Cryptography.X509Certificates;

namespace Crm.DataAccess;

public class ClientRepository : IClientRepository
{
    private readonly List<Client> _clients;
    private long _id = 0;

    public ClientRepository()
    {
        _clients = new List<Client>();
    }


    //Main Methods
    public bool Create(Client client)
    {
        Client newClient = new()
        {
            Id = _id++,
            FirstName = firstName,
            LastName = lastName,
            MiddleName = middleName,
            Age = age,
            PassportNumber = passportNumber,
            Email = email,
            Phone = phone,
            Password = password,
            Gender = gender
        };
      return true;
    }

    public bool GetClient(string firstName, string lastName)
    {
        Client? client = _clients.Find(item => item.FirstName.Equals(firstName) && item.LastName.Equals(lastName));
        return client.ToClientInfo();
    }

    public bool DeleteClientnt(long clientId)
    {
        int clientIndex = _clients.FindIndex(item => item.FirstName.Equals(clientId));
        if (clientIndex < 0)
            return false;

        _clients.RemoveAt(clientIndex);
        return true;
    }

    public bool EditClient(long clientId, string NewFirstName, string NewLastName)
    {
        Client? client = _clients.Find(item => item.Id.Equals(clientId));
        if (client is null) return false;

        client.FirstName = NewFirstName;
        client.LastName = NewLastName;
        return true;
    }

    //Stat service
    public int ClientCount() => _clients.Count;
}