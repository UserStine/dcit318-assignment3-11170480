using Assignment_3;
using Assignment_3.Question_2;

class Program
{
    static void Main(string[] args)
    {
        // --- Question 1 ---
        var app = new FinanceApp();
        app.Run();

        Console.WriteLine("\n============================\n");

        // --- Question 2 ---
        var healthApp = new HealthSystemApp();
        healthApp.SeedData();
        healthApp.BuildPrescriptionMap();
        healthApp.PrintAllPatients();

        Console.Write("\nEnter a Patient ID to view prescriptions: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            healthApp.PrintPrescriptionsForPatient(id);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
