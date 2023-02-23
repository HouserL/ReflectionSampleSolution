namespace ReflectionSample.Models;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; } = 0;
    public PhoneNumber PhoneNumber { get; set; } = new();
    public List<Address> Addresses { get; set; } = new();
    public List<int> ints { get; set; } = new();
    public Person() { }

}
