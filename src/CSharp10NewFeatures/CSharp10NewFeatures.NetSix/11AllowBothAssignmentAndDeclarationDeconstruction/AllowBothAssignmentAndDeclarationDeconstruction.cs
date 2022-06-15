namespace CSharp10NewFeatures.NetSix._11AllowBothAssignmentAndDeclarationDeconstruction
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void Deconstruct(out string firstName, out string lastName) =>
            (firstName, lastName) = (this.FirstName, this.LastName);
    }
}
