using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using EsportManager.Models;

namespace EsportManager.Services;

public interface ITournamentService
{
    Task<IEnumerable<Tournament>> GetAllTournamentAsync();
    Task<Tournament> GetTournamentByIdAsync(int id);
}