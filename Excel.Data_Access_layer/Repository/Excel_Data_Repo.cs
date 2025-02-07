using Excel.Data_Access_layer.DataBase;
using Excel.Data_Access_layer.Entity;
using Microsoft.EntityFrameworkCore;

public class Excel_Data_Repo : IExcel_Data_Repo
{
    private readonly ApplicationDbContext _context;

    public Excel_Data_Repo(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Excel_Data data)
    {
        _context.ExcelData.Add(data);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Excel_Data>> GetAllAsync()
    {
        return await _context.ExcelData.ToListAsync();
    }
}