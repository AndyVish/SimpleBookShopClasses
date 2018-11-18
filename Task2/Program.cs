using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Employee
    {
        private string fullName;
        private int empID;
        private float currPay;
        public Employee() { }
        public Employee(string fullName, int empID, float currPay)
        {
            this.fullName = fullName; this.empID = empID;
            this.currPay = currPay;
        }
        // Метод для увеличения зарплаты сотрудника
        public void GiveBonus(float amount)
        { currPay += amount; }
        // Метод для вывода сведений о текущем состоянии объекта
        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", fullName);
            Console.WriteLine("Pay: {0}", currPay);
            Console.WriteLine("ID: {0}", empID);
        }
    }


    class Program
    {
        static void Main()
        {
            Employee e = new Employee("Joe", 80, 30000);
            e.GiveBonus(200);
            Employee e2;
            e2 = new Employee("Goose", 81, 50000);
            e2.GiveBonus(1000);
            e2.DisplayStats();
            Console.ReadKey();
        }
    }
}
