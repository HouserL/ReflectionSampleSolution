namespace ReflectionSample.Models;

public class PhoneNumber
{
    public PhoneNumberType PhoneNumberType { get; set; } = PhoneNumberType.Home;
    public string Number { get; set; } = string.Empty;
    public PhoneNumber() { }
}

public enum PhoneNumberType { Home,Work,Cell,WorkCell}
