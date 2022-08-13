using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitwareLib
{
    internal class Employee
    {
        private int     EmpNo;
        private string  EmpName;
        private double  Salary;
        private double  HRA;
        private double  TA;
        private double  DA;
        private double  PF;
        private double  TDS;
        private double  NetSalary;
        private double  GrossSalary;

        public Employee(int EmpNo, string EmpName, double Salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.Salary = Salary;

        }


        public int empNo
        {
            get
            {
                return this.EmpNo;
            }
            set
            {
                this.EmpNo = value;
            }
        }
        public string empName
        {
            get
            {
                return this.EmpName;
            }
            set
            {
                this.EmpName = value;
            }
        }
        public double salary
        {
            get
            {
                return this.Salary;
            }
            set
            {
                this.Salary = value;
            }
        }

        public void Calculate()
        {
            if (salary < 5000)
            {
                HRA = 0.1 * Salary;
                TA = 0.05 * Salary;
                DA = 0.15 * Salary;
            }
            else if (salary < 10000)
            {
                HRA = 0.15 * Salary;
                TA = 0.1 * Salary;
                DA = 0.2 * Salary;
            }
            else if (Salary < 15000)
            {
                HRA = 0.2 * Salary;
                TA = 0.15 * Salary;
                DA = 0.25 * Salary;
            }
            else if (Salary < 20000)
            {
                HRA = 0.25 * Salary;
                TA = 0.2 * Salary;
                DA = 0.3 * Salary;
            }
            else
            {
                HRA = 0.3 * Salary;
                TA = 0.25 * Salary;
                DA = 0.35 * Salary;
            }

            GrossSalary = salary + HRA + TA + DA;

            PF = 0.1 * GrossSalary;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF + TDS);

            Console.WriteLine("Employee Details: ");
            Console.WriteLine("EmpNo: {0} \nEmpName: {1} \nSalary: {2}", empNo, empName, salary);     
            Console.WriteLine("GrossSalary : {0}", GrossSalary);
            Console.WriteLine("PF : {0}", PF);
            Console.WriteLine("TDS : {0}", TDS);
            Console.WriteLine("NetSalary : {0}", NetSalary);
        }
        static void Main()
        {
            Employee emp = new Employee(120, "Jass", 19099);
            emp.Calculate();
            Console.ReadLine();
        }
    }
}
