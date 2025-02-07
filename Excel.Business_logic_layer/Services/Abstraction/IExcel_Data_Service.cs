using Excel.Data_Access_layer.Entity;

public interface IExcel_Data_Service
{
    Task ImportDataFromExcel(string filePath);// This method will import data from excel file to database 
    Task<List<Excel_Data>> GetAllAsync();// This method will return all data from database

    public List<Excel_Data> ReadExcelData(string filePath);// This method will read data from excel file



}