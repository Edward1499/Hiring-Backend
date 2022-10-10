using BLL.DTOs.Candidate;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hiring_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService candidateService;

        public CandidateController(ICandidateService candidateService)
        {
            this.candidateService = candidateService;
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            return Ok(candidateService.GetById(id));
        }

        [HttpGet("GetByUserId/{userId}")]
        public ActionResult GetByUserId(string userId)
        {
            return Ok(candidateService.GetByUserId(userId));
        }

        [HttpGet("GetAllByPositionId/{positionId}")]
        public ActionResult GetAllByPositionId(int positionId)
        {
            return Ok(candidateService.GetAllByPositionId(positionId));
        }


        [HttpPost]
        public ActionResult Create(CreateCandidateDTO request)
        {
            return Ok(candidateService.Add(request));
        }

        [HttpPatch("{id}")]
        public ActionResult Update(CreateCandidateDTO request, int id)
        {
            return Ok(candidateService.Update(request, id));
        }

        [HttpGet("validatePersonalId/{id}")]
        public ActionResult ValidatePersonalId(string id)
        {
            return Ok(ValidaCedula(id));
        }

        private bool ValidaCedula(string cedula)
        {
            //Declaración de variables a nivel de método o función.
            int verificador = 0;
            int digito = 0;
            int digitoVerificador = 0;
            int digitoImpar = 0;
            int sumaPar = 0;
            int sumaImpar = 0;
            int longitud = Convert.ToInt32(cedula.Length);
            /*Control de errores en el código*/
            try
            {
                //verificamos que la longitud del parametro sea igual a 11
                if (longitud == 11)
                {
                    digitoVerificador = Convert.ToInt32(cedula.Substring(10, 1));
                    //recorremos en un ciclo for cada dígito de la cédula
                    for (int i = 9; i >= 0; i--)
                    {
                        //si el digito no es par multiplicamos por 2
                        digito = Convert.ToInt32(cedula.Substring(i, 1));
                        if ((i % 2) != 0)
                        {
                            digitoImpar = digito * 2;
                            //si el digito obtenido es mayor a 10, restamos 9
                            if (digitoImpar > 10)
                            {
                                digitoImpar = digitoImpar - 9;
                            }
                            sumaImpar = sumaImpar + digitoImpar;
                        }
                        /*En los demás casos sumamos el dígito y lo aculamos 
                         en la variable */
                        else
                        {
                            sumaPar = sumaPar + digito;
                        }
                    }
                    /*Obtenemos el verificador restandole a 10 el modulo 10 
                    de la suma total de los dígitos*/
                    verificador = 10 - ((sumaPar + sumaImpar) % 10);
                    /*si el verificador es igual a 10 y el dígito verificador
                      es igual a cero o el verificador y el dígito verificador 
                      son iguales retorna verdadero*/
                    if (((verificador == 10) && (digitoVerificador == 0))
    || (verificador == digitoVerificador))
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }


    }
}
