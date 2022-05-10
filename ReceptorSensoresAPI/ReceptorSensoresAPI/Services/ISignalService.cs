using ReceptorSensoresAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptorSensoresAPI.Services
{
    public interface ISignalService
    {
        Task<bool> SaveSignalAsync(SignalInputModel inputModel);
    }
}
