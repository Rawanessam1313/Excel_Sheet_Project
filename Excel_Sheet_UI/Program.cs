class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            Console.Write("Enter the Excel file path: ");
            string filePath = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(filePath))
            {
                Console.WriteLine("Invalid path. Please try again.");
                return;
            }

           
            var excelService = new Excel_Data_Service();

           
            await excelService.ImportDataFromExcel(filePath);

           
            Console.WriteLine("Data in the database:");
            var data = await excelService.GetAllAsync();
            foreach (var item in data)
            {
                Console.WriteLine($"ID: {item.Id}, Country: {item.Country_or_region}, Score: {item.Score}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}