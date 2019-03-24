using AdvertAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertAPI.Services
{
    public interface IAdvertStorageService
    {
        Task<string> AddAsync(AdvertModel model);
        Task ConfirmAsync(ConfirmAdvertModel model);
        Task<AdvertModel> GetByIdAsync(string id);
        Task<bool> CheckHealthAsync();
        Task<List<AdvertModel>> GetAllAsync();
    }
}
