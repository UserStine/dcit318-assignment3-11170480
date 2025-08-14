using Assignment_3;
using Assignment_3.Question_2;
using Assignment_3.Question_3;
using Assignment_3.Question_4; 


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

        Console.WriteLine("\n============================\n");

        // --- Question 3 ---
        var manager = new WareHouseManager();
        manager.SeedData();

        Console.WriteLine("\n--- Grocery Items ---");
        manager.PrintAllItems(manager.GroceriesRepo);

        Console.WriteLine("\n--- Electronic Items ---");
        manager.PrintAllItems(manager.ElectronicsRepo);

        Console.WriteLine("\n--- Testing Exceptions ---");
        try
        {
            manager.ElectronicsRepo.AddItem(new ElectronicItem(1, "Tablet", 5, "Apple", 12)); // duplicate
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        manager.RemoveItemById(manager.GroceriesRepo, 99); // non-existent
        manager.IncreaseStock(manager.GroceriesRepo, 1, -5); // invalid quantity

        Console.WriteLine("\n============================\n");

        // --- Question 4 ---
        var processor = new StudentResultProcessor();
        try
        {
            string inputPath = "students.txt";  // Place file in project bin/Debug/netX folder
            string outputPath = "report.txt";

            var students = processor.ReadStudentsFromFile(inputPath);
            processor.WriteReportToFile(students, outputPath);

            Console.WriteLine("Student report generated successfully! Check 'report.txt'.");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (InvalidScoreFormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (MissingFieldExceptionn ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
