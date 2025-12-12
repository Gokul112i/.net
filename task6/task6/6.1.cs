using System;

public class Person
{
    private string FirstName;
    private string LastName;
    private string EmailAddress;
    private DateTime DateOfBirth;

    public Person(string firstName, string lastName, string email, DateTime dob)
    {
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = email;
        DateOfBirth = dob;
    }

    public bool IsAdult
    {
        get
        {
            int age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now < DateOfBirth.AddYears(age)) age--;
            return age >= 18;
        }
    }

    public string SunSign
    {
        get
        {
            int d = DateOfBirth.Day;
            int m = DateOfBirth.Month;

            if ((m == 3 && d >= 21) || (m == 4 && d <= 19)) return "Aries";
            if ((m == 4 && d >= 20) || (m == 5 && d <= 20)) return "Taurus";
            if ((m == 5 && d >= 21) || (m == 6 && d <= 20)) return "Gemini";
            if ((m == 6 && d >= 21) || (m == 7 && d <= 22)) return "Cancer";
            if ((m == 7 && d >= 23) || (m == 8 && d <= 22)) return "Leo";
            if ((m == 8 && d >= 23) || (m == 9 && d <= 22)) return "Virgo";
            if ((m == 9 && d >= 23) || (m == 10 && d <= 22)) return "Libra";
            if ((m == 10 && d >= 23) || (m == 11 && d <= 21)) return "Scorpio";
            if ((m == 11 && d >= 22) || (m == 12 && d <= 21)) return "Sagittarius";
            if ((m == 12 && d >= 22) || (m == 1 && d <= 19)) return "Capricorn";
            if ((m == 1 && d >= 20) || (m == 2 && d <= 18)) return "Aquarius";
            return "Pisces";
        }
    }

    public bool IsBirthDay => DateTime.Now.Month == DateOfBirth.Month &&
                              DateTime.Now.Day == DateOfBirth.Day;

    public string ScreenName
    {
        get
        {
            string fn = FirstName.Length > 2 ? FirstName.Substring(0, 2).ToLower() : FirstName.ToLower();
            string ln = LastName.Length > 2 ? LastName.Substring(0, 2).ToLower() : LastName.ToLower();
            return fn + ln + DateOfBirth.ToString("MMddyy");
        }
    }
}

public class Employee : Person
{
    public double Salary { get; set; }

    public Employee(string first, string last, string email, DateTime dob, double salary)
        : base(first, last, email, dob)
    {
        Salary = salary;
    }
}

public class HourlyEmployee : Person
{
    public double HoursWorked { get; set; }
    public double PayPerHour { get; set; }

    public HourlyEmployee(string first, string last, string email, DateTime dob,
                          double hours, double rate)
        : base(first, last, email, dob)
    {
        HoursWorked = hours;
        PayPerHour = rate;
    }

    public double TotalPay => HoursWorked * PayPerHour;
}

public class PermanentEmployee : Person
{
    public double HRA { get; set; }
    public double DA { get; set; }
    public double Tax { get; set; }
    public double TotalPay { get; set; }
    public double NetPay => TotalPay - Tax;

    public PermanentEmployee(string first, string last, string email, DateTime dob,
                             double hra, double da, double tax, double totalPay)
        : base(first, last, email, dob)
    {
        HRA = hra;
        DA = da;
        Tax = tax;
        TotalPay = totalPay;
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee("Hari", "Doe", "hari@gmail.com",
                                     new DateTime(1980, 5, 25), 50000);

        Console.WriteLine(emp.IsAdult);
        Console.WriteLine(emp.SunSign);
        Console.WriteLine(emp.IsBirthDay);
        Console.WriteLine(emp.ScreenName);
        Console.WriteLine(emp.Salary);

        HourlyEmployee hEmp = new HourlyEmployee("Max", "Joe", "max@gmail.com",
                                                 new DateTime(1995, 10, 10), 40, 200);
        Console.WriteLine(hEmp.TotalPay);

        PermanentEmployee pEmp = new PermanentEmployee("John", "Smith", "john@gmail.com",
                                                       new DateTime(1990, 8, 15), 5000, 3000, 2000, 40000);
        Console.WriteLine(pEmp.NetPay);
    }
}
