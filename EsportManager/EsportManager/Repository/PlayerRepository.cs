using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using EsportManager.Models;
using Npgsql;

namespace EsportManager.Repository;

public class PlayerRepository : IPlayerRepository
{
    private readonly string _connectionString;

    public PlayerRepository(string connectionString)
    {
        _connectionString = connectionString;
    }
}