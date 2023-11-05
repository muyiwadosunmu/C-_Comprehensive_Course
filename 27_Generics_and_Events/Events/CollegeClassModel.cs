namespace EventDemo;

public class CollegeClassModel
{
    // Step 1 -> Actual declaration of the Handler, the glue  in the middle
    public event EventHandler<string> EnrollmentFull;
    private List<string> enrolledStudents = new List<string>();
    private List<string> waitingList = new List<string>();

    public string CourseTitle { get; private set; }
    public int MaximumStudents { get; private set; }
    public CollegeClassModel(string title, int maximumStudents)
    {
        CourseTitle = title;
        MaximumStudents = maximumStudents;

    }

    public string SignUpStudents(string studentName)

    {
        string? output = "";


        if (enrolledStudents.Count < MaximumStudents)
        {

            enrolledStudents.Add(studentName);
            output = $"{studentName} was enrolled in {CourseTitle}";
            // Step 3 Invocation/Firing of the Event
            if (enrolledStudents.Count == MaximumStudents)
            {
                EnrollmentFull?.Invoke(this, $"{CourseTitle} enrolment is now full");
            }

        }
        // Check to see if we are maxed out
        else
        {
            waitingList.Add(studentName);
            output = $"{studentName} was added to the waitlist in {CourseTitle}";
        }
        return output;
    }

}