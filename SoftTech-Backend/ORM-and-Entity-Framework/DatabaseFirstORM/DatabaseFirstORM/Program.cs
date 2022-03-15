using DatabaseFirstORM.Data.Models;

public class Program
{

    static void Main()
    {
        var context = new SoftUniContext();
    }

    //Problem 03
    public static string FindEmployeesWithJobTitle(SoftUniContext context)
    {
        return string.Join(Environment.NewLine, employees);
    }

    //Problem 04
    public static string FindProjectWithId(SoftUniContext context)
    {
        return project.Name;
    }

    //Problem 05
    public static void CreateNewProject(SoftUniContext context)
    {

    }

    //Problem 06
    public static string UpdateFirstEmployee(SoftUniContext context)
    {
        if (employee != null)
        {
            return employee.FirstName;
        }
        return "";
    }

    //Problem 07
    public static string DeleteFirstProject(SoftUniContext context)
    {
        return project.Name;
    }

    //Problem 08
    public static string UpdateAddresses(SoftUniContext context)
    {
        return addresses.Count.ToString();
    }

}