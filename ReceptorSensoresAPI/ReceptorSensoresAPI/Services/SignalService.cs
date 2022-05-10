using ReceptorSensoresAPI.Models;
using ReceptorSensoresAPI.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptorSensoresAPI.Services
{
    public class SignalService : ISignalService
    {
        private readonly MainDbContext _mainDbContext;

        public SignalService(MainDbContext mainDbContext)
        {
            _mainDbContext = mainDbContext;
        }
        public async Task<bool> SaveSignalAsync(SignalInputModel inputModel)
        {
            try
            {
                //map input model to data model
                //at this point we assume a signal arrives only one time and it's unique
                SignalData signalModel = new SignalData();

                signalModel.Time_stamp = inputModel.Time_stamp;
                signalModel.Tag = inputModel.Tag;
                signalModel.Valor = inputModel.Valor;


                //execute some business rules according to your cases.

                //if you decide to save signal add it to the db context
                _mainDbContext.Signals.Add(signalModel);

                //save changes and if the signal has stored in db return true.
                return await _mainDbContext.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                //log the exception or take some actions

                return false;
            }
        }
    }
}
