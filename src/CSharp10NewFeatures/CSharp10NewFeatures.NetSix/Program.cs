
using CSharp10NewFeatures.NetSix._11AllowBothAssignmentAndDeclarationDeconstruction;

//2. ImprovementsOfStructureTypes

// **** Improvement 1:
//var m1 = new Measurement();
//Console.WriteLine(m1);  // output: NaN (Undefined)
//var m2 = default(Measurement);
//Console.WriteLine(m2);  // output: 0 ()
//var ms = new Measurement[2];
//Console.WriteLine(string.Join(", ", ms));  // output: 0 (), 0 ()
//var ms3 = new Measurement(51, "Gökhan Atay");
//Console.WriteLine(ms3);


//***Improvement 2 ***
//var p1 = new Coords(0, 0);
//Console.WriteLine(p1);  // output: (0, 0)
//var p2 = p1 with { X = 3 };
//Console.WriteLine(p2);  // output: (3, 0)
//var p3 = p1 with { X = 1, Y = 4 };
//Console.WriteLine(p3);  // output: (1, 4)


//4. Global Usign Directives
//StringBuilder sb = new StringBuilder();

//6. ExtendedPropertyPatterns
//Developer developer = new Developer();
//if (developer is Developer { Team: { Title: "DT-Phoenix" } })
//{
//    Console.WriteLine("Developer!");
//}

//if (developer is Developer { Team.Title: "DT-Phoenix" })
//{
//    Console.WriteLine("Developer!");
//}

// 8. Const Interpolated Strings
//Console.WriteLine(AllowConstInterpolatedStrings.FullProductName);

//10. Improved Definite Assignment

Employee employee = new Employee
{
    FirstName = "Gökhan",
    LastName = "Atay"
};

(string firstname1, string lastname1) = employee;

string firstname2 = string.Empty;
string lastname2 = string.Empty;
(firstname2, lastname2) = employee;
Console.WriteLine($"{firstname2} {lastname2}");

// New syntax comes with C# 10.
string firstname = string.Empty;
(firstname, string lastname) = employee;
