using Excel.Data_Access_layer.Entity;

public interface IExcel_Data_Repo
{
    Task<List<Excel_Data>> GetAllAsync();
    Task AddAsync(Excel_Data data);
}
