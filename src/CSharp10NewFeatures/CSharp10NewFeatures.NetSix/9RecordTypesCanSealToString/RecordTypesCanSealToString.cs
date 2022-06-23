namespace CSharp10NewFeatures.NetSix._9RecordTypesCanSealToString
{
    public class RecordTypesCanSealToString
    {

    }

    public record Lead
    {
        public string Title { get; init; }

        public override string ToString()
        {
            return $"Title of Lead: {Title}!";
        }
    }

    public record TeamLead : Lead
    {
        public string TeamName { get; set; }
        public  override string ToString() // Error CS0239 'Student.ToString()': cannot override inherited member 'Person.ToString()' because it is sealed
        {
            return $"I am responsible for team, {TeamName}";
        }
    }

    public record TechLead : Lead
    {
        public string TechName { get; set; }
        public override string ToString() // Error CS0239 'Student.ToString()': cannot override inherited member 'Person.ToString()' because it is sealed
        {
            return $"I am responsible for tech, {TechName}";
        }
    }
}
