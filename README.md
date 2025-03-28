# ChsharpPractise


``` Csharp
internal class LanguageDetails
{
    private string language;
    private double version;
    private string Company;

    static void Main(string[] args)
    {
      LanguageDetails csharpLanguageDetails = new LanguageDetails();
        Console.WriteLine("Language Details");
        Console.WriteLine("----------------------------------");
        csharpLanguageDetails.language = "Chsarp";
        csharpLanguageDetails.version = 4.7;
        csharpLanguageDetails.Company = "Microsoft";
        Console.WriteLine($"Lanague name is {csharpLanguageDetails.language}");
        Console.WriteLine($"{csharpLanguageDetails.language} version name is {csharpLanguageDetails.version} and Company name is {csharpLanguageDetails.Company}");
        Console.WriteLine("----------------------------------");
        //python programing details

        LanguageDetails pythonProgramDetails = new LanguageDetails();
        pythonProgramDetails.language = "Python";
        pythonProgramDetails.version = 3.5;
        pythonProgramDetails.Company = "Oracle";
        Console.WriteLine($"Lanague name is {pythonProgramDetails.language}");
        Console.WriteLine($"{pythonProgramDetails.language} version name is {pythonProgramDetails.version} and Company name is {pythonProgramDetails.Company}");
        Console.WriteLine("----------------------------------");
        Console.ReadLine();
    }
}
```
``` Csharp
internal class EmployeeFileds
{ //fields are declared inside the class. 
    //accessmodifier datatype variablename;
    private string employeeName; //default value is null
    private int employeeId;//default value is 0.
    private double employeeSalary = 20000;
    private int employeeAge = 34;
    static void Main(string[] args)
    {
        Console.WriteLine("Employees Data");
        EmployeeFileds laxmanEmployeeFileds = new EmployeeFileds();//object creation. ClassName objectname=new ClassnName();
        laxmanEmployeeFileds.employeeId = 1;
        laxmanEmployeeFileds.employeeName = "Laxman";
        laxmanEmployeeFileds.employeeSalary = 21000;
        laxmanEmployeeFileds.employeeAge = 30;
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine($"{laxmanEmployeeFileds.employeeName} employee id is " + laxmanEmployeeFileds.employeeId);
        Console.WriteLine("employee name is " + laxmanEmployeeFileds.employeeName);
        Console.WriteLine($"{laxmanEmployeeFileds.employeeName} employee salary is " + laxmanEmployeeFileds.employeeSalary);
        Console.WriteLine($"{laxmanEmployeeFileds.employeeName} employee age is " + laxmanEmployeeFileds.employeeAge);
        EmployeeFileds praveenEmployee = new EmployeeFileds();
        praveenEmployee.employeeId = 2;
        praveenEmployee.employeeName = "Praveen";
        praveenEmployee.employeeSalary = 30000;
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Praveen employee id is " + praveenEmployee.employeeId);
        Console.WriteLine("Praveen employee name is " + praveenEmployee.employeeName);
        Console.WriteLine("Praveen employee salary is " + praveenEmployee.employeeSalary);
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------");
        Console.ReadLine();
    }
} 
```
