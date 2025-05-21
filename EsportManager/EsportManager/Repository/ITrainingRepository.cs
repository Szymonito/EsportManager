using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using EsportManager.Models;

namespace EsportManager.Repository;

public interface ITrainingRepository
{
    Task<IEnumerable<Training>> GetAllAsync();
    Task<Training> GetByIdAsync(int id);
}