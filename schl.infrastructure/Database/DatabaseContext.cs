using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace schl.infrastructure.Database
{
    public class DatabaseContext
    {
        private readonly string _connectionString;  
        public DatabaseContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<T> QueryFirstOrDefaultAsync<T>(string sql, object parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                return await connection.QueryFirstOrDefaultAsync<T>(sql, parameters);
            }
        }
        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                return await connection.QueryAsync<T>(sql, parameters);
            }
        }
        public async Task ExecuteAsync(string sql, object parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                await connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}
