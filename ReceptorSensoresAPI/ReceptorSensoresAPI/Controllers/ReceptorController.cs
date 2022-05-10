using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using ReceptorSensoresAPI.Hubs;
using ReceptorSensoresAPI.Models;
using ReceptorSensoresAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptorSensoresAPI.Controllers
{
    [Route("api/receptor")]
    [ApiController]
    public class SignalController : ControllerBase
    {
        private readonly ISignalService _signalService;
        private readonly IHubContext<SignalHub> _hubContext;
        public SignalController(ISignalService signalService, IHubContext<SignalHub> hubContext)
        {
            _signalService = signalService;
            _hubContext = hubContext;
        }

        [HttpPost]
        [Route("receiver")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(bool))]

        public async Task<IActionResult> SignalArrived(SignalInputModel inputModel)
        {


            var saveResult = await _signalService.SaveSignalAsync(inputModel);

            if (saveResult)
            {
                SignalViewModel signalViewModel = new SignalViewModel
                {
                    Time_stamp = inputModel.Time_stamp,
                    Tag = inputModel.Tag,
                    Valor = inputModel.Valor
                };

                await _hubContext.Clients.All.SendAsync("SignalMessageReceived", signalViewModel);
            }

            return StatusCode(200, saveResult);

        }

    }
}
