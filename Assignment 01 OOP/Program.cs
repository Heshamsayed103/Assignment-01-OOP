//1. Class 
//2. Struct 
//3. Interface 
//4. Enum


//internal Struct Point {

//    public int X = default ; // 4
//    public int Y = default ; // 4

// Constructor : Special Methods
//    1. Named Like Struct
//    1. Has No Return Type

// CLR :Will Generate Parameterless Contractor
// This Constructor will Initialized The Attributes With The Default Values


// Constructor
//public Point()
//{
//}


//public Point(int x, int y)
//{
//    X = x;
//    Y = y;

//}


//}
internal class Program
{
    static void Main(string[] args)
    {
        #region Struct
        // Struct : Value Types : STACK 

        // Employee
        //Id, Name , Salary


        // Point 

        //Point P01;
        // Declare For Object From Type 'Point'
        // P01: Object
        // Allocate UnInitialized 8 Bytes at STACK

        //Console.WriteLine(P01.X);
        //Console.WriteLine(P01.Y);

        //P01.X = 12;
        //P01.Y = 12;
        //Console.WriteLine(P01.X);
        //Console.WriteLine(P01.Y);

        //P01 = new Point();
        // new : Used For Select The Constructor


        //Console.WriteLine(P01.X);
        //Console.WriteLine(P01.Y);



        //Console.WriteLine(P@1); // C_ooP@16@7.Point
        //P@1.PrintPoint();

        //Console.WriteLine(P@1.ToString()); // C_ooP@16@7.Point
        //Console.WriteLine(P@1); // C_ooP@16@7.Point

        //Point[] points = new Point[10];

        #endregion

        #region OOP Overview
        // OOP : Object Oriented Programming
        // Programming Paradigm 
        // OOP : The Paradigm Use For Build Any Business

        // Class : Blueprint Of The Object
        // Object : Specific Instance From Class

        // 4 pillars
        // ---
        // 1. Encapsulation
        // 2. Inheritance
        // 3. Ploymorphism
        // 4. Abstraction    I 
        #endregion

        // 1. Encapsulation :
        // Class Or Struct
        // Separate The Data(Attributes) Definition From Its Use
        //[Setter Getter Method - properties]

        // Employee    I
        // Id Name salary


        // 1. End User Access data itself
        // 2. No Data Validation
        // 3. No Read Only Filed

        // Apply Encapsulation : 
        // 1. Make All Data(Attributes) Private
        //2. Access Data Through :
        //2.1. Setter Getter Method 
        //2.2. Properties
        //            Employee E01 = new Employee();
        //            E01.id = 1;
        //            E01.name = "Ahmed";
        //            E01.salary = -12000;

        //            Console.WriteLine(E01.id);
        //            Console.WriteLine(E01.name);
        //            Console.WriteLine(E01.salary);


        //            // Apply Encapsulation User Setter Getter Method

        //            // Setter

        //         public void SetId(int id)
        //        {
        //            this.id = id;
        //        }

        //         // Getter

        //        public int GetId()
        //        {
        //            return id;
        //        }

        //        // Setter Name


        //public void SetName(string name)
        //        {
        //            if (name.Length >=)
        //                this.name = name;
        //        }

        //        public Employee(int id, string name, double salary)
        //        {
        //            SetId(id);
        //            SetName(name);
        //            SetSalary(salary);
        //        }


        //public override string ToString()
        //        {
        //            return $"Id: {id} :: Name: {name}";
        //        }

        //    }
        //    }
    }
}