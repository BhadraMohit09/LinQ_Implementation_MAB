// See https://aka.ms/new-console-template for more information
public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public string Branch { get; set; }
    public int Semester { get; set; }
    public double CPI { get; set; }

    public static List<Student> GetAllStudents()
    {
        List<Student> students = new List<Student>
        {
            new Student { StudentID = 101, StudentName = "Jaiswal", Branch = "CSE", Semester = 5, CPI = 9.55 },
            new Student { StudentID = 102, StudentName = "Ruturaj", Branch = "Civil", Semester = 6, CPI = 8.75 },
            new Student { StudentID = 103, StudentName = "Abhishek", Branch = "Electrical", Semester = 5, CPI = 7.89 },
            new Student { StudentID = 104, StudentName = "Virat", Branch = "CSE", Semester = 5, CPI = 10.00 },
            new Student { StudentID = 105, StudentName = "Samson", Branch = "Mechanical", Semester = 7, CPI = 6.93 },
            new Student { StudentID = 106, StudentName = "Rinku", Branch = "Chemical", Semester = 7, CPI = 7.45 },
            new Student { StudentID = 107, StudentName = "Washington", Branch = "Yoga", Semester = 5, CPI = 8.45 },
            new Student { StudentID = 108, StudentName = "Shivam", Branch = "IT", Semester = 5, CPI = 9.42 },
            new Student { StudentID = 109, StudentName = "Siraj", Branch = "DSP", Semester = 7, CPI = 8.66 },
            new Student { StudentID = 110, StudentName = "Yuzi Chahal", Branch = "Chemical", Semester = 6, CPI = 9.99 }
        };
        return students;
    }

    public static void Main(string[] args)
    {
        List<Student> students = Student.GetAllStudents();

        // LINQ Method Syntax to get all Students.
        Console.WriteLine("All Students::");
        var studentList = GetAllStudents();
        foreach (var item in studentList)
        {
            Console.WriteLine("Student ID: " + item.StudentID + " Student Name: " + item.StudentName + " Branch: " + item.Branch + " Semester: " + item.Semester + " CPI: " + item.CPI);
        }

        Console.WriteLine();

        // LINQ Query Syntax to find out student names whose CPI is greater than 8
        var studentNames = from student in students
                           where student.CPI > 8
                           select student.StudentName;
        Console.WriteLine("Student Names whose CPI is greater than 8:: ");
        foreach (var studentName in studentNames)
        {
            Console.WriteLine(studentName);
        }

        // LINQ Query Syntax to combine Student ID and Student Name fields.
        var combineList = Student.GetAllStudents().Select(x => new
        {
            StudentIDAndStudentName = x.StudentID + " => " + x.StudentName,
            Branch = x.Branch,
            Semester = x.Semester,
            CPI = x.CPI
        });

        Console.WriteLine();

        Console.WriteLine("Student ID and Student Name: ");

        foreach (var item in combineList)
        {
            Console.WriteLine("Student ID and Student Name: " + item.StudentIDAndStudentName);
        }

        Console.WriteLine();

        // LINQ Method Syntaxt to find out sort Students based on CPI

        var sortedStudents = students.OrderByDescending(x => x.CPI);

        Console.WriteLine("Students sorted based on CPI:: ");

        foreach (var student in sortedStudents)
        {
            Console.WriteLine("Student ID: " + student.StudentID + " Student Name: " + student.StudentName + " Branch: " + student.Branch + " Semester: " + student.Semester + " CPI: " + student.CPI);
        }
        Console.WriteLine();


        //  LINQ Method Syntax to get Students based on Semester

        Console.WriteLine("Enter Semester to get Students:: ");
        var userInput = Convert.ToInt32(Console.ReadLine());

        var semesterStudents = students.Where(x => x.Semester == userInput);

        Console.WriteLine("Students based on Semester:: ");

        foreach (var student in semesterStudents)
        {
            Console.WriteLine("Student ID: " + student.StudentID + " Student Name: " + student.StudentName + " Branch: " + student.Branch + " Semester: " + student.Semester + " CPI: " + student.CPI);
        }

        Console.WriteLine();

        //LINQ Method Syntax to get Students based on Branch

        Console.WriteLine("Enter Branch to get Students:: ");
        var userInputBranch = Console.ReadLine();

        var branchStudents = students.Where(x => x.Branch == userInputBranch);

        Console.WriteLine("Students based on Branch:: ");

        foreach (var student in branchStudents)
        {
            Console.WriteLine("Student ID: " + student.StudentID + " Student Name: " + student.StudentName + " Branch: " + student.Branch + " Semester: " + student.Semester + " CPI: " + student.CPI);
        }
        Console.WriteLine();

        // LINQ Method Syntax to get Students with distinct Branches

        var distinctBranches = students.Select(x => x.Branch).Distinct();

        Console.WriteLine("Distinct Branches:: ");

        foreach (var branch in distinctBranches)
        {
            Console.WriteLine(branch);
        }

        Console.WriteLine();
    }
}