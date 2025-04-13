using Microsoft.AspNetCore.Mvc;
using Application.Dtos;
using Application.Interfaces;
using System;

namespace CSharpAreaCalculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AreaController : ControllerBase
    {
        private readonly IFormaGeometrica _formaGeometricaService;

        public AreaController(IFormaGeometrica formaGeometricaService)
        {
            _formaGeometricaService = formaGeometricaService;
        }

        [HttpPost("calcular-area")]
        public IActionResult CalcularArea([FromBody] CalculoAreaRequest request)
        {
            try
            {
                var area = _formaGeometricaService.CalcularArea(request);
                return Ok(new AreaResponseDto { Area = area });
                
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
