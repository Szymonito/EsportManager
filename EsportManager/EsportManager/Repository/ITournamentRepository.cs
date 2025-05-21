using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using EsportManager.Models;

namespace EsportManager.Repository;

public interface ITournamentRepository
{
    Task<IEnumerable<Tournament>> GetAllAsync();
    Task<Tournament> GetAsync(int id);
    Task AddAsync(Tournament tournament);
    Task UpdateAsync(Tournament tournament);
    Task DeleteAsync(Tournament tournament);
}