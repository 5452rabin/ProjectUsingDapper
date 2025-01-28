using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Assignment.DataAccess
{
    public class SQLDataAccess: ISQLDataAccess
    {
        private readonly IConfiguration _config;
        public SQLDataAccess(IConfiguration config) { 
            _config = config;
        }

        public async Task<bool> DeleteData<T>(string spname, T param, string connectionid = "defaultconnection")
        {
            try
            {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionid));
            await connection.QueryAsync<T>(spname, param, commandType: CommandType.StoredProcedure);
            return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public async Task<IEnumerable<T>> GetData<T, P>(string spname,P param, string connectionid= "defaultconnection")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionid));
            return await connection.QueryAsync<T>(spname,param,commandType:CommandType.StoredProcedure);
        }
        public async Task SaveData<T>(string spname,T param,string connectionid= "defaultconnection")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionid));
            await connection.QueryAsync<T>(spname,param,commandType:CommandType.StoredProcedure);
        }

    }
}
