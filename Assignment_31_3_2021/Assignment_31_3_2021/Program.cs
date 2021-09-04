using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_31_3_2021
{
    class Course
    {
        private string title;
        private string stream;
        private string type;
        private string start_date;
        private string end_date;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Stream
        {
            get { return stream; }
            set { stream = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string StartDate
        {
            get { return start_date; }
            set { start_date = value; }
        }

        public string EndDate
        {
            get { return end_date; }
            set { end_date = value; }
        }
    }
    class Trainer : Human
    {
        private string subject;
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
    class Student : Human
    {
        private string tuitionFees;
        public string Fees
        {
            get { return tuitionFees; }
            set { tuitionFees = value; }
        }
    }
    class Assignment : School
    {
        private string title;
        private string description;
        private string subDateTime;
        private string oralMark;
        private string totalMark;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string SubDateTime
        {
            get { return subDateTime; }
            set { subDateTime = value; }
        }

        public string OralMark
        {
            get { return oralMark; }
            set { oralMark = value; }
        }

        public string TotalMark
        {
            get { return totalMark; }
            set { totalMark = value; }
        }
    }
    class Human: School
    {
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
    }
    class School
    {
        public virtual string AddStudents()
        {
            Console.Write("Add a student: ");
            return Console.ReadLine();
        }
        public virtual string AddTrainers()
        {
            Console.Write("Add a trainer: ");
            return Console.ReadLine();
        }
        public virtual string AddAssignments()
        {
            Console.Write("Add an assignment: ");
            return Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("WELCOME TO CODING BOOTCAMP # 13");
            Console.WriteLine("===============================");
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("dddd dd MMMM yyyy"));
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Student Selection");
            Console.WriteLine("2) Input Your Data");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    StudentSelection();
                    return true;
                case "2":
                    InputYourData();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
        private static void StudentSelection()
        {
            Console.Clear();

            List<string> students = new List<string> { "Antonios Ioannou","Christiana Bakali", "Dimitra Kamni", "Elina Zafeiri", 
                                                       "Evanthia Basagianni", "George Tzavellas", "Giannis Kabouris",
                                                       "Giorgos Kalokyris", "Giorgos Karagiorgos","Giorgos Kavvadias" };

            List<string> trainers = new List<string> { "Konstantinos Takakis", "Georgios Pasparakis" };

            List<string> assignments = new List<string> { "Individual Project", "Team Project" };

            List<string> courses = new List<string> { "C#", "Java" };

            for (int i = 0; i <= 10; i++)
            {
                foreach (string a in students)
                {
                    i = i + 1;
                    Console.WriteLine($"Student {i}: {a}");
                }
            }

            Console.WriteLine();

            Studs(students, trainers, assignments, courses);
        }
        private static string Studs(List<string> students, List<string> trainers, List<string> assignments,
                                    List<string> courses)
        {
            Console.Write("Choose The Number Of The Student: ");
            int stud = int.Parse(Console.ReadLine());
            string _student = "";
            string _trainers = "";
            string _assignments = "";
            string _courses = "";

            if (stud == 1)
            {
                _student = students[0];
                _trainers = trainers[1];
                _assignments = assignments[0];
                _courses = courses[0];
            }
            else if (stud == 2)
            {
                _student = students[1];
                _trainers = trainers[0];
                _assignments = assignments[1];
                _courses = courses[0];
            }
            else if (stud == 3)
            {
                _student = students[2];
                _trainers = trainers[0];
                _assignments = assignments[1];
                _courses = courses[0];
            }
            else if (stud == 4)
            {
                _student = students[3];
                _trainers = trainers[0];
                _assignments = assignments[0];
                _courses = courses[1];
            }
            else if (stud == 5)
            {
                _student = students[4];
                _trainers = trainers[0];
                _assignments = assignments[1];
                _courses = courses[0];
            }
            else if (stud == 6)
            {
                _student = students[5];
                _trainers = trainers[0];
                _assignments = assignments[0];
                _courses = courses[1];
            }
            else if (stud == 7)
            {
                _student = students[6];
                _trainers = trainers[0];
                _assignments = assignments[1];
                _courses = courses[0];
            }
            else if (stud == 8)
            {
                _student = students[7];
                _trainers = trainers[0];
                _assignments = assignments[0];
                _courses = courses[0];
            }
            else if (stud == 9)
            {
                _student = students[8];
                _trainers = trainers[1];
                _assignments = assignments[0];
                _courses = courses[0];
            }
            else if (stud == 10)
            {
                _student = students[9];
                _trainers = trainers[1];
                _assignments = assignments[0];
                _courses = courses[0];
            }

            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Student: {_student}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Trainer: {_trainers}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Assignments: {_assignments}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Courses: {_courses}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.Write("Press Enter to return to Main Menu");
            return Console.ReadLine();
        }
        private static void InputYourData()
        {
            Console.Clear();
            Console.WriteLine("Input Your Data");
            Console.WriteLine();
            Console.Write("Enter firstname: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter lastname: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter birthday: ");
            string dateOfBirth = Console.ReadLine();
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.Write("Enter stream: ");
            string stream = Console.ReadLine();
            Console.Write("Enter type: ");
            string type = Console.ReadLine();
            Console.Write("Enter starting date: ");
            string startDate = Console.ReadLine();
            Console.Write("Enter ending date: ");
            string endDate = Console.ReadLine();
            Console.Clear();
            Console.Write("Enter Trainer's firstname: ");
            string trainerFirstName = Console.ReadLine();
            Console.Write("Enter Trainer's lastname: ");
            string trainerLasttName = Console.ReadLine();
            Console.Clear();

            UserOutput(firstName, lastName, dateOfBirth, title, stream, type, startDate, endDate, trainerFirstName, trainerLasttName);
        }

        private static void UserOutput(string firstName, string lastName, string dateOfBirth, string title, string stream, string type, string startDate, string endDate, string trainerFirstName, string trainerLasttName)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Student's name: {firstName} {lastName}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Date of birth: {dateOfBirth}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Bootcamp's title: {title}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Stream: {stream}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Starting date: {startDate}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Ending date: {endDate}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Trainer's name: {trainerFirstName} {trainerLasttName}");
            Console.WriteLine("---------------------------------------------------");
            DateTime date = DateTime.Now;
            Console.WriteLine($"Date and time of input: {date}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.Write("Press Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}

