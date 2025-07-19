using System.Reflection;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;

using System.ComponentModel;
using System.Drawing;

namespace Assignment_01_OOP
{
    //==============Part01========================//
    #region Q"1 Struct


    //struct Point
    //{

    //    public double X { get; set; }
    //    public double Y { get; set; }


    //    public Point(double x, double
    //        y)
    //    {
    //        X = x;
    //        Y = y;
    //    }


    //    public double DistanceTo(Point other)
    //    {
    //        double dx = other.X - this.X;
    //        double dy = other.Y - this.Y;
    //        return Math.Sqrt(dx * dx + dy * dy);
    //    }

    //    public override string ToString()
    //    {
    //        return $"({X}, {Y})";
    //    }
    //}

    #endregion

    #region Q"2 Struct
    //struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Person(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //} 
    #endregion


    //Part 02//

    #region Q1" Enum & Class

    //enum SecurityLevel
    //{
    //    Guest,
    //    Developer,
    //    Secretary,
    //    DBA
    //}

    //class Employee
    //{

    //    private int id;
    //    private string name;
    //    private SecurityLevel securityLevel;
    //    private double salary;
    //    private DateTime hireDate;
    //    private char gender;


    //    public Employee(int id, string name, SecurityLevel securityLevel, double salary, DateTime hireDate, char gender)
    //    {
    //        this.Id = id;
    //        this.Name = name;
    //        this.SecurityLevel = securityLevel;
    //        this.Salary = salary;
    //        this.HireDate = hireDate;
    //        this.Gender = gender;
    //    }


    //    public int Id
    //    {
    //        get { return id; }
    //        set { id = value; }
    //    }

    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }

    //    public SecurityLevel SecurityLevel
    //    {
    //        get { return securityLevel; }
    //        set { securityLevel = value; }
    //    }

    //    public double Salary
    //    {
    //        get { return salary; }
    //        set { salary = value > 0 ? value : 0; }
    //    }

    //    public DateTime HireDate
    //    {
    //        get { return hireDate; }
    //        set { hireDate = value; }
    //    }

    //    public char Gender
    //    {
    //        get { return gender; }
    //        set
    //        {
    //            if (value == 'M' || value == 'F')
    //                gender = value;
    //            else
    //                throw new ArgumentException("Gender must be 'M' or 'F'.");
    //        }
    //    }


    //    public override string ToString()
    //    {
    //        return $"ID: {Id}, Name: {Name}, Security: {SecurityLevel}, Salary: {String.Format("{0:C}", Salary)}, Hire Date: {HireDate.ToShortDateString()}, Gender: {Gender}";
    //    }
    //}

    //0. Develop a Class to represent the Hiring Date Data:
    //● Consisting of fields to hold the day, month and Years.

    //class HiringDate
    //{
    //    public int Day;
    //    public int Month;
    //    public int Year;

    //    public HiringDate(int day, int month, int year)
    //    {
    //        Day = day;
    //        Month = month;
    //        Year = year;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Day}/{Month}/{Year}";
    //    }
    //}

    #endregion


    #region 0.Develop 0.Create  an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
    //Notes:
    //● Implement All the Necessary Member Functions on the Class(Getters, Setters)
    //● Define all the Necessary Constructors for the Class
    //● Allow NO RUNTIME errors if the user inputs any data
    //● Write down all the necessary Properties(Instead of setters and getters)

    //enum Role
    //{
    //    Guest,
    //    DBA,
    //    SecurityOfficer
    //}

    //[Flags]
    //enum Permissions
    //{
    //    None = 0,
    //    Read = 1,
    //    Write = 2,
    //    Execute = 4,
    //    Full = Read | Write | Execute
    //}

    //struct Employeee
    //{
    //    public string Name { get; set; }
    //    public Role EmpRole { get; set; }
    //    public Permissions EmpPermissions { get; set; }

    //    public Employeee(string name, Role role, Permissions permissions)
    //    {
    //        Name = name;
    //        EmpRole = role;
    //        EmpPermissions = permissions;
    //    }

    //    public void PrintInfo()
    //    {
    //        Console.WriteLine($"Name: {Name}, Role: {EmpRole}, Permissions: {EmpPermissions}");
    //    }
    //} 
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            //==============  Part01  ========================//

            #region Q"1 1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y".Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.Write("Enter X for Point 1: ");
            //double x1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter Y for Point 1: ");
            //double y1 = double.Parse(Console.ReadLine());

            //Point p1 = new Point(x1, y1);


            //Console.Write("Enter X for Point 2: ");
            //double x2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter Y for Point 2: ");
            //double y2 = double.Parse(Console.ReadLine());

            //Point p2 = new Point(x2, y2);


            //double distance = p1.DistanceTo(p2);

            //Console.WriteLine($"\nPoint 1: {p1}");
            //Console.WriteLine($"Point 2: {p2}");
            //Console.WriteLine($"Distance between them: {distance:F2}");


            #endregion


            #region Q"2 2.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //    Person[] people = new Person[3];


            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.WriteLine($"\nEnter details for person {i + 1}:");

            //        Console.Write("Name: ");
            //        string name = Console.ReadLine();

            //        Console.Write("Age: ");
            //        int age = int.Parse(Console.ReadLine());

            //        people[i] = new Person(name, age);
            //    }


            //    Person oldest = people[0];

            //    for (int i = 1; i < people.Length; i++)
            //    {
            //        if (people[i].Age > oldest.Age)
            //        {
            //            oldest = people[i];
            //        }
            //    }

            //    Console.WriteLine($"\nThe oldest person is: {oldest.Name}, Age: {oldest.Age}");
            //} 
            #endregion


            //***************************** Part 02 *********************************//


            #region Q"1 1. Design and implement a Class for the employees in a company:
            //Notes:
            //● Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            //● We need to restrict the Gender field to be only M or F[Male or Female]
            //● Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum.
            //● We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), display employee salary in a currency format. [Use String.Format() Function].
            //try
            //{

            //    Employee emp1 = new Employee(1, "Ahmed", SecurityLevel.Developer, 15000.5, new DateTime(2020, 5, 15), 'M');

            //    Console.WriteLine(emp1.ToString());
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //} 
            #endregion


            #region 0. Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee[] EmpArr;)
            //Notes:
            //● Implement All the Necessary Member Functions on the Class(Getters, Setters)
            //● Define all the Necessary Constructors for the Class
            //● Allow NO RUNTIME errors if the user inputs any data
            //● Write down all the necessary Properties(Instead of setters and getters)

            //Employeee[] EmpArr = new Employeee[3];

            //EmpArr[0] = new Employeee("Ali", Role.DBA, Permissions.Read | Permissions.Write);
            //EmpArr[1] = new Employeee("Sarah", Role.Guest, Permissions.Read);
            //EmpArr[2] = new Employeee("Omar", Role.SecurityOfficer, Permissions.Full);

            //Console.WriteLine("Employeee Info:");
            //foreach (var emp in EmpArr)
            //{
            //    emp.PrintInfo();
            //} 
            #endregion

        }
    }
}