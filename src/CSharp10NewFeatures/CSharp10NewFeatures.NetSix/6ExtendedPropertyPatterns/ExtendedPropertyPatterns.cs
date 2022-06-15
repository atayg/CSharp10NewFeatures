namespace CSharp10NewFeatures.NetSix._6ExtendedPropertyPatterns
{
    public class ExtendedPropertyPatterns
    {
        public Person Person { get; set; }

    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Developer : Person
    {
        public ScrumTeam Team { get; set; }
    }

    public class ScrumTeam
    {
        public string Title { get; set; }
    }

}