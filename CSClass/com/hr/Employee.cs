using System;
using MongoDB.Bson;


namespace com.hr
{
    class Employee
    {
        public string First
        { get; set; }
        
        public string Last
        { get; set; }

        public decimal Salary
        { get; set; }

        public ObjectId id
        { get; set; }

        public override string ToString() =>
        "Employee [id =" + Id + ", Firstname=" + First + ", Lastname=" + Last + ", salary=" + Salary + "]";

    }
}