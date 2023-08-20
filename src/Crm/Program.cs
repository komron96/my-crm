using Crm.DataAccess;
using Crm.BusinessLogic;

IClientService clientService = new ClientService();
CreateClient();

void CreateClient()
{   string firstName = Console.ReadLine();
    string lastName = Console.ReadLine();
    string middleName = Console.ReadLine();
    string ageInputStr = Console.ReadLine();
    string passportNumber = Console.ReadLine();
    string genderInputStr = Console.ReadLine();
    string email = Console.ReadLine();
    string phone = Console.ReadLine();
    string password = Console.ReadLine();

    if(!ValidateClient(
        firstName,
        lastName,
        middleName,
        ageInputStr,
        passportNumber,
        genderInputStr,
        email,
        phone,
        password
    )) return;

    Gender gender = (Gender)int.Parse(genderInputStr);
    short age = short.Parse(ageInputStr);


bool ValidateClient( 
    string firstName,
    string lastName, 
    string middleName,
    string ageStr,
    string passportNumber,
    string genderStr,
    string phone,
    string email,
    string password) 

{  List<string> errors = new();

    if (firstName is { Length: 0 })
        errors.Add("First Name field is required!");

    if (lastName is { Length: 0 })
        errors.Add("Last Name field is required!");

    if (middleName is { Length: 0 })
        errors.Add("Middle Name field is required!");
    
    if (phone is { Length: 0 })
        errors.Add("Phone field is required!");

    if (email is { Length: 0 })
        errors.Add("Email adress field is required!");

    if (password is { Length: 0 })
        errors.Add("Password field is required nigga!");

    bool isAgeCorrect = short.TryParse(ageStr, out short age);
    if (!isAgeCorrect)
        errors.Add("Please input correct value for age field!");

    if (passportNumber is { Length: 0 })
        errors.Add("Passport Number field is required!");

    bool isGenderCorrect = int.TryParse(genderStr, out int genderIndex);
    if (!isGenderCorrect)
        errors.Add("Please input correct value for gender field!");
    
    bool isEnumGenderCorrect = genderIndex.TryParse(out Gender gender);
    if (!isEnumGenderCorrect)
        errors.Add("Please input correct value for gender field (0 - Male, 1 - Female)!");

    if (errors is { Count: > 0 })
    {
        foreach(string errorMessage in errors)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
        }

        Console.ForegroundColor = ConsoleColor.White;
        return false;
    }
    return true;
}
    Client newClient = clientService.CreateClient(
            firstName,
            lastName,
            middleName,
            age,
            passportNumber,
            password,
            email,
            phone,
            gender
    );
}






//OrderCreation Part
IOrderService clientOrder = new ClientOrder();
CreateOrder();
void CreateOrder()
{   
    string ID = Console.ReadLine();
    string Description= Console.ReadLine();
    string Price = Console.ReadLine();
    short Date = short.Parse(Console.ReadLine());
    string Delivery = Console.ReadLine();
    string Adress = Console.ReadLine();
    string orderStateInput = Console.ReadLine();
    
    Order newOrder = clientOrder.CreateOrder
    (
        ID,
        Description,
        Price,
        Date,
        Delivery,
        Adress,
        orderStateInput
    );
    
    OrderState orderStateInput = (OrderState)int.Parse(orderStateInput);

}
