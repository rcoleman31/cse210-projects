using System;

public abstract class Employee
{
    protected string _name;

    public Employee(string name)
    {
        _name = name;
    }

    public abstract float CalculatePay();

    public void DisplayName()
    {
        Console.WriteLine($"Employee: {_name}");
    }
}

public class SalaryEmployee : Employee
{
    private float _salary;

    public SalaryEmployee(string name, float salary) : base(name)
    {
        _salary = salary;
    }

    public override float CalculatePay()
    {
        return _salary;
    }
}

public class HourlyEmployee : Employee
{
    private float _rate;
    private float _hours;

    public HourlyEmployee(string name, float rate, float hours) : base(name)
    {
        _rate = rate;
        _hours = hours;
    }

    public override float CalculatePay()
    {
        return _rate * _hours;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        employees.Add(new SalaryEmployee("Alice", 1200f));
        employees.Add(new HourlyEmployee("Bob", 10, 40f));
        employees.Add(new HourlyEmployee("Charlie", 18f, 35f));

        foreach (Employee employee in employees)
        {
            employee.DisplayName();

            float pay = employee.CalculatePay();

            Console.WriteLine($"Paycheck Amount: {pay}");
            Console.WriteLine();
        }
    }
}