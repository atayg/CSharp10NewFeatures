namespace CSharp10NewFeatures.NetSix._1RecordStructs
{
    //Definition of Record Types in C# 9.
    public record Person(string FirstName, string LastName);

    public record Person2
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }

    //Definition of Record Types in C# 10
    public record class Person3(string FirstName, string LastName);

    public record struct Person4
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }


}
