using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ProblemSolving.Tasks.TaskNo2.Models
{
    public class Employee
    {
        public string Name { get; set; }

        public AddressInfo address { get; set; }
        public InsuranceInfo? insurance { get; set; }
        public double Salary { get; set; }

        // overload constructor to avoid updating all instances when property is added to the class
        public Employee(string name, string street, string city, int region) : 
            this(name, street, city, region, 5000) // pass params to this original constructor
        {}

        public Employee(string name, string street, string city, int region, double salary)
        {
            Name = name;
            AddressInfo _address = new AddressInfo()
            {
                Street = street,
                City = city,
                Region = region,
            };
            this.address = _address;
            Salary = salary;
        }

        public virtual string DoWork()
        {
            return "Employee do work";
        }

        public virtual string DoWork(string msg)
        {
            return msg;
        }

        public override string ToString()
        {
            string retVal = Name + ' ' +
                address.City + ' ' +
                address.Street + ' ' +
                address.Region.ToString() +
                "\t" + "Salary : " + Salary.ToString() + "\t";

            if (insurance != null)
            {
                retVal += ' ' + insurance.PolicyName + ' ' + insurance.PolicyId.ToString();
            }

            return retVal;
        }
    }
}
