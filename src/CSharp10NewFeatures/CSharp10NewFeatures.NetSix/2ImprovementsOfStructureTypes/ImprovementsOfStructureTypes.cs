namespace CSharp10NewFeatures.NetSix._2ImprovementsOfStructureTypes
{
    public class ImprovementsOfStructureTypes
    {
        /*Improvement 1: You can declare an instance parameterless constructor in a structure type
        and initialize an instance field or property at its declaration. */
        public readonly struct Measurement
        {
            public Measurement()
            {
                Value = double.NaN;
                Description = "Undefined";
            }

            public Measurement(double value, string description)
            {
                Value = value;
                Description = description;
            }

            public double Value { get; init; }
            public string Description { get; init; }

            public override string ToString() => $"{Value} ({Description})";
        }

        /* Improvement 2: A left-hand operand of the with expression can be of any structure type
           or an anonymous (reference) type. */
        public readonly struct Coords
        {
            public Coords(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; init; }
            public double Y { get; init; }

            public override string ToString() => $"({X}, {Y})";
        }


    }
}
