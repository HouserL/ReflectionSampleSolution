namespace ReflectionSample.Logic;

public class LoadDataLogic
{
    public static Person CreatePerson()
    {
        var output = new Person
        {
            Id = 1,
            FirstName = "First",
            LastName= "Last",
            Age= 30,
            PhoneNumber = CreatePhoneNumber(),
            Addresses = {CreateAddressOne(), CreateAddressTwo()},
            ints = CreateIntList(),
        };
        return output;
    }
    public static Address CreateAddressOne() 
    {
        var output = new Address
        {
            State = "Oklahoma",
            StreetAddress = "12345 S Test Street",
            City = "Tulsa",
            PostalCode = "12345",
            Country = "United States"
        };
        return output;
    }
    public static Address CreateAddressTwo()
    {
        var output = new Address
        {
            State = "Texas",
            StreetAddress = "204 W Main Street",
            City = "Dallas",
            PostalCode = "58401-3456",
            Country = "United States",
            AddressType = AddressTypeEnum.Home
        };
        return output;
    }
    public static PhoneNumber CreatePhoneNumber()
    {
        var output = new PhoneNumber
        {
            PhoneNumberType = PhoneNumberType.Home,
            Number = "918-555-1234"
        };
        return output;
    }
    public static List<int> CreateIntList()
    {
        return new List<int> { 10, 23, 345 };
    }

}
