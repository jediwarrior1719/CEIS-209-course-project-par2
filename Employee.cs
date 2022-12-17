using Johnston_CourseProject_CEIS209;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Johnston_CourseProject_Part2
{
    [Serializable]
    public abstract class Employee
    {
        // attributes 
        private string firstName;
        private string lastName;
        private string ssn;
        private DateTime hireDate;
        private Benefits benefits;
        // constructors
        public Employee()
        {
            this.firstName = "N/A";
            this.lastName = "N/A";
            this.ssn = "N/A";
            this.hireDate = new DateTime();
            this.benefits = new Benefits();
        }
        public Employee(string firstName, string lastName, string ssn,
            DateTime hireDate, Benefits benefits)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.hireDate = hireDate;
            this.benefits = benefits;
        }
        // behaviors
        public override string ToString()
        {
            return "firstName=" + firstName
                + ", lastName=" + lastName
                + ", ssn=" + ssn
                + ", hireDate=" + hireDate.ToShortDateString()
                + ", healthInsurance=" + benefits.HealthInsurance
                + ", lifeInsurance+" + benefits.LifeInsurance
                + ", vacation=" + benefits.Vacation;

        }

        public abstract double CalculatePay();


        // Properties
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
        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }
        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }
        public Benefits BenefitsEmp
        {
            get { return benefits; }
            set { benefits = value; }

        }
    }
}
