namespace Crm.DataAccess;

public sealed class PosgresqlClientRepository : IClientRepository
{
    public int ClientCount()
    {
        throw new NotImplementedException();
    }

    public bool Create(Client client)
    {
        throw new NotImplementedException();
    }

    public bool DeleteClient(long clientId)
    {
        throw new NotImplementedException();
    }

    public bool EditClient(long Id, string NewFirstName, string NewLastName)
    {
        throw new NotImplementedException();
    }

    public bool GetClient(string firstName, string lastName)
    {
        throw new NotImplementedException();
    }
}