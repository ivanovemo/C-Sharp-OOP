﻿namespace PersonsInfo;

public class Person
{
    public Person(string firstName, string lastName, int age, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }
    public decimal Salary { get; private set; }

    public void IncreaseSalary(decimal percentage)
    {
        decimal increase = Salary * percentage / 100;
        if (Age < 30)
        {
            increase /= 2;
        }

        Salary += increase;
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName} receives {Salary:f2} leva.";
    }
}
