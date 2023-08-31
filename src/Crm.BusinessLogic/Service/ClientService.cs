using Crm.DataAccess;
namespace Crm.BusinessLogic;


public sealed class ClientService : IClientService
{
        //Инициализация объектов класса должна происходить в конструкторе, а удаление в деструкторах.
    public ClientService() 
    {
        _clientsList = new();
    }
    
    public ClientInfo CreateClient(ClientInfo clientInfo)
    {
        Client newClient = new()
        
            {
                Id = _id++,
                FirstName = clientInfo.FirstName,
                LastName = clientInfo.LastName,
                MiddleName = clientInfo.MiddleName,
                Age = clientInfo.Age,
                PassportNumber = clientInfo.PassportNumber,
                Email = clientInfo.Email,
                Phone = clientInfo.Phone,
                Password = clientInfo.Password,
                Gender = clientInfo.Gender.TogenderEnum(),
            };

    return clientInfo with {Id = newClient.Id};
    }

    public ClientInfo GetClient(string firstName, string lastName)
    {
        if (firstName is not {Length: > 0})
            throw new ArgumentNullException(nameof(firstName));
        if (lastName is not {Length: > 0})
            throw new ArgumentNullException(nameof(lastName));

        Client? client = _clientsList.Find(c => c.FirstName.Equals(firstName) && c.LastName.Equals(lastName)) ?? throw new NotFoundClient();
        return client.ToClientInfo();

    }

        public bool DeleteClient(long clientid)
    {
        int clientIndex = _clientsList.FindIndex(item => item.FirstName.Equals(clientid)); //item - переменная перебора цикла
        if (clientIndex < 0)
            return false;

        _clientsList.RemoveAt(clientIndex);
        
        return true;
    }

    public bool EditClient(long Id, string NewFirstName, string NewLastName)
    {
        Client? client = _clientsList.Find(item => item.Id.Equals(Id));
        if (client is null) return false;

        client.FirstName = NewFirstName;
        client.LastName = NewLastName;
        return true;
    }
}
