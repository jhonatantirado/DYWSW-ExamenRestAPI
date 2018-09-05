using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Estudiantes.Application;
using Common.Api.Controller;

namespace Estudiantes.API
{
    public class EstudianteController : Controller{
        private const string studentsByTypeRoute = "/api/Students/findByType";
        private const string studentsAllRoute = "/api/Students";
        private const string getScholarshipAmountRoute = "/api/Students/getScholarshipAmount";
        IEstudianteApplicationService _estudianteApplicationService;
        ResponseHandler responseHandler;
        public EstudianteController(IEstudianteApplicationService estudianteApplicationService)
        {
            _estudianteApplicationService = estudianteApplicationService;
            responseHandler = new ResponseHandler();
        }


        [Route(studentsByTypeRoute)]
        [HttpGet]
        public IActionResult getByStudentByType(string studentType)
        {
            if (string.IsNullOrWhiteSpace(studentType)){
                return BadRequest(this.responseHandler.getAppCustomErrorResponse("Invalid student type"));
            } 

            try
            {
                return Ok(_estudianteApplicationService.getByStudentType(studentType));
            }
            catch (ArgumentException ex){
                return BadRequest(this.responseHandler.getAppCustomErrorResponse(ex.Message));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, this.responseHandler.getAppExceptionResponse());
            }

        }

        [Route(studentsAllRoute)]
        [HttpGet]
        public IActionResult getAll()
        {
            try
            {
                return Ok(_estudianteApplicationService.getAll());
            }
            catch (ArgumentException ex){
                return BadRequest(this.responseHandler.getAppCustomErrorResponse(ex.Message));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, this.responseHandler.getAppExceptionResponse());
            }

        }

        [Route(getScholarshipAmountRoute)]
        [HttpGet]
        public IActionResult getScholarshipAmount(string studentCode)
        {
            if (string.IsNullOrWhiteSpace(studentCode)){
                return BadRequest(this.responseHandler.getAppCustomErrorResponse("Invalid student code"));
            } 

            try
            {
                return Ok(_estudianteApplicationService.calculateScholarship(studentCode));
            }
            catch (ArgumentException ex){
                return BadRequest(this.responseHandler.getAppCustomErrorResponse(ex.Message));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, this.responseHandler.getAppExceptionResponse());
            }

        }
    }
    
}