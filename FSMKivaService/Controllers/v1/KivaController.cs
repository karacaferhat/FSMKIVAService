using FSMKivaService.Data;
using FSMKivaService.Entities;
using FSMKivaService.Entities.Requests;
using FSMKivaService.Entities.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSMKivaService.Controllers.v1
{
    [Route("v1/api/[controller]")]
    [ApiController]
    public class KivaController : ControllerBase
    {
        private readonly BasicDataContext _context;
        public KivaController(BasicDataContext context)
        {
            _context = context; 
        }
         

        [HttpPost("getSerialState")]
        public ActionResult<GetSerialStateResponse> GetSerialState(GetSerialStateRequest request)
        {
            if(!ModelState.IsValid)
                return BadRequest("Model State Is Not Valid");

            var model = _context.GetSerialState(request);

            if(model == null)
                return NoContent();

            return Ok(new GetSerialStateResponse{Code = model.Code, Name = model.Name, State = model.State });
        }

        [HttpPost("setSerialServiceState")]
        public ActionResult<SetSerialServiceStateResponse> SetSerialServiceState(SetSerialServiceStateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest("Model State Is Not Valid");

            var response = _context.SetSerialServiceState(request);
         

            return Ok(response);
        }

        [HttpPost("getDeliveryInfo")]
        public ActionResult<GetDeliveryInfoResponse> GetDeliveryInfo(GetDeliveryInfoRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest("Model State Is Not Valid");

            var model = _context.GetDeliveryInfos(request);

            if (model == null)
                return NoContent();

            return Ok(new GetDeliveryInfoResponse {DeliveryInfos = model});
        }


        [HttpPost("getSerialInfo")]
        public ActionResult<GetSerialInfoResponse> GetSerialInfo(GetSerialInfoRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest("Model State Is Not Valid");

            var model = _context.GetSerialInfo(request);

            if (model == null)
                return NoContent();

            return Ok(new GetSerialInfoResponse{
                Code = model.Code,
                Name = model.Name,
                Power = model.Power,
                Rpm = model.Rpm,
                Body = model.Body,
                ProdectionDate = model.ProdectionDate, 
                EfficencyClass = model.EfficencyClass,
                StructureType = model.StructureType,
                Frequency = model.Frequency,
                Voltage = model.Voltage

            });
        }

    }
}
