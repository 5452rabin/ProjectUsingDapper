namespace Assignment.DataAccess
{
    public interface ISQLDataAccess
    {
        Task<IEnumerable<T>> GetData<T, P>(string spname, P param, string connectionid = "defaultconnection");
        Task SaveData<T>(string spname, T param, string connectionid = "defaultconnection");
        Task<bool> DeleteData<T>(string spname, T param, string connectionid = "defaultconnection");

    }
}