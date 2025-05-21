using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EsportManager.Models;
using EsportManager.Repository;

namespace EsportManager.Services;

public class PlayerService: IPlayerService
{
    private readonly IPlayerRepository _playerRepository;
    private readonly ITournamentService _tournamentRepository;
    private readonly ITrainingService _trainingRepository;
    private readonly Random _random = new Random();

    public PlayerService(IPlayerRepository playerRepository, ITournamentService tournamentRepository,
        ITrainingService trainingRepository)
    {
        _playerRepository = playerRepository;
        _tournamentRepository = tournamentRepository;
        _trainingRepository = trainingRepository;
    }

    public async Task<IEnumerable<Player>> GetAllPlayersAsync()
    {
        return await _playerRepository.GetAllAsync();
    }

    public async Task<Player> GetPlayerAsync(int id)
    {
        return await _playerRepository.GetByIdAsync(id);
    }
}