using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    enum Numbers : long
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3
    }

    enum EmpType : byte
    {
        Manager = 10, Grunt = 1,
        Contractor = 100, VP = 9
    }
    struct Employee
    {
        // Конструктор
        public Employee(EmpType et, string n, short d)
        {
            title = et; name = n; deptID = d;
        }
        
        public EmpType title;   // Поле – перечисление
        public string name;
        public short deptID; 
    }

     
  
class Program
    {
        static void Main(string[] args)
        {

            Employee fred;           //Создание структурной переменной
            fred.deptID = 40;
            fred.name = "Fred";
            fred.title = EmpType.Grunt;
           

            Employee jain = new Employee(EmpType.Contractor, "Jain", 50);

            Console.WriteLine("{0}-{1}({2})", fred.name, fred.title, fred.deptID);
            Console.WriteLine("{0}-{1}({2})", jain.name, jain.title, jain.deptID);
            Console.ReadKey();
        }
    }
}
