using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using EsportManager.Models;

namespace EsportManager.Services;

public interface ITrainingService
{
    Task<IEnumerable<Training>> GetAllTrainingAsync();
    Task<Training> GetTrainingByIdAsync(int id);
}