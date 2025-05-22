using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using EsportManager.Models;
using Npgsql;

namespace EsportManager.Repository;

public class TrainingRepository : ITrainingRepository
{
    private readonly string _connectionString;

    public TrainingRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<Training>> GetAllAsync()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            await connection.OpenAsync();
            return await connection.QueryAsync<Training>("SELECT * FROM trainings");
        }
    }

    public async Task<Training> GetByIdAsync(int id)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            await connection.OpenAsync();
            return await connection.QueryFirstOrDefaultAsync<Training>("SELECT * FROM trainings WHERE id = @id", new { id = trainingId });
        }
    }
}