using Excel.Data_Access_layer.DataBase;
using Excel.Data_Access_layer.Entity;
using Ganss.Excel;
using NPOI.SS.Formula.Functions;

public class Excel_Data_Service : IExcel_Data_Service
{
    private readonly Excel_Data_Repo _repo;

    public Excel_Data_Service()
    {
       
        var dbContext = new ApplicationDbContext();
        _repo = new Excel_Data_Repo(dbContext);
    }

    public List<Excel_Data> ReadExcelData(string filePath)
    {
        var excel = new ExcelMapper(filePath);
        var data = excel.Fetch<Excel_Data>().ToList();

        Console.WriteLine($"Found {data.Count} records in the Excel file.");
        return data;
    }

    public async Task ImportDataFromExcel(string filePath)
    {
        var data = ReadExcelData(filePath);
        Console.WriteLine($" Number of records read from Excel: {data.Count}");
        if (data.Count > 0)
        {
            foreach (var item in data)
            {
            Console.WriteLine($" {item.Id}");
            }
           
        }
        else
        {
            Console.WriteLine("No data found in the Excel file.");
        }

       
    }
   

    public async Task<List<Excel_Data>> GetAllAsync()
    {
        return await _repo.GetAllAsync();
    }
}