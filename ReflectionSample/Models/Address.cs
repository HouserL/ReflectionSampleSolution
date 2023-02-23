namespace ReflectionSample.Models;

public class Address
{
    public AddressTypeEnum AddressType { get; set; } = AddressTypeEnum.Home;
    public string StreetAddress { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public Address() { }
}
public enum AddressTypeEnum { Home, Work, Rental, Vacation}
