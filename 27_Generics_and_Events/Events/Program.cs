namespace EventDemo;

class Program
{
    public static void Main(string[] args)
    {
        CollegeClassModel history = new CollegeClassModel("History 101", 3);
        CollegeClassModel math = new CollegeClassModel("Calculus 201", 3);

        // Step 2a, We should take note of this instance
        history.EnrollmentFull += CollegeClass_EnrollmentFull;

        history.SignUpStudents("Muyiwa Dosunmu").PrintToConsole();
        history.SignUpStudents("Victor David").PrintToConsole();
        history.SignUpStudents("Dada Joshua").PrintToConsole();
        history.SignUpStudents("Olawumi Grace").PrintToConsole();
        history.SignUpStudents("Atef Emmanuel").PrintToConsole();
        Console.WriteLine();

        math.EnrollmentFull += CollegeClass_EnrollmentFull;
        math.SignUpStudents("John Doe").PrintToConsole();
        math.SignUpStudents("Joe Bi den").PrintToConsole();
        math.SignUpStudents("Don Jazzy").PrintToConsole();
        math.SignUpStudents("Donald Trump").PrintToConsole();

        Console.ReadLine();

    }

    private static void CollegeClass_EnrollmentFull(object? sender, string e)
    {
        CollegeClassModel model = (CollegeClassModel)sender;
        Console.WriteLine();
        Console.WriteLine($"{model.CourseTitle}: Full ");
        Console.WriteLine();
    }

    // private static void Math_EnrollmentFull(object? sender, string e)
    // {
    //     Console.WriteLine();

    //     Console.WriteLine("The Enrollment is full for maths");
    //     Console.WriteLine();
    // }


    // Step 2b -> Wired from 2a above
    // private static void History_EnrollmentFull(object? sender, string e)
    // {
    //     Console.WriteLine();

    //     Console.WriteLine("The Enrollment is full for history");
    //     Console.WriteLine();

    // }
}