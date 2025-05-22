using System.Collections.Generic;
using System.Threading.Tasks;
using EsportManager.Models;
using EsportManager.Repository;

namespace EsportManager.Services;

public class TrainingService : ITrainingService
{
    private readonly ITrainingRepository _trainingRepository;

    public TrainingService(ITrainingRepository trainingRepository)
    {
        _trainingRepository = trainingRepository;
    }

    public async Task<IEnumerable<Training>> GetAllTrainingAsync()
    {
        return await _trainingRepository.GetAllAsync();
    }

    public async Task<Training> getTrainingByIdAsync(int id)
    {
        return await _trainingRepository.GetByIdAsync(id);
    }
}