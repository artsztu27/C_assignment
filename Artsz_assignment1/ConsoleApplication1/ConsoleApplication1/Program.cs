using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {

            string firstName = "Mary";
            string lastName = "Wang";
            string fullName = firstName+" "+lastName;
            string year = "1994";
            string date = "23";
            string Month = "December";
            string Birthday = Month + " " + date + "," + year;
            string Address1  ="2400 Cammino Ramon";
            string Address2  ="Suite 375";
            string City = "Sam Ramon";
            string State= "Pingtung";
            int Zip = 90076;
            string country = "Taiwan";
            string Professor = "Chunhung Lin";
            string pertinent = "Compuer Science";
            string U_degree = "Master of Computer Science";
            string  P_name ="Computer Science ";
            string  D_offered = "Master";
            string  D_Head = "NSYSU CSE";
            string  course = "JAVA";
            Console.WriteLine("Student information");
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("Birthdate: on {0}", Birthday);
            Console.WriteLine("Address Line 1: {0}" ,Address1);
            Console.WriteLine("Address Line 2: {0}" ,Address2);
            Console.WriteLine("City: {0}", City);
            Console.WriteLine("State/Province:{0}",State);
            Console.WriteLine("Zip/Postal: {0}",Zip);
            Console.WriteLine("Country:{0}",country);
            Console.WriteLine("Professor information: {0} with {1}", Professor, pertinent);
            Console.WriteLine("university degree: {0}  ", U_degree);
            Console.WriteLine("Program name {0}  ", P_name);
            Console.WriteLine("Degrees offered: {0}  ", D_offered);
            Console.WriteLine("Department Head: {0}  ", D_Head);
            Console.WriteLine("course: {0}  ", course);
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
