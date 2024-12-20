﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareerCloud.WebAPI.Controllers
{
    [Route("api/careercloud/system/v1")]
    [ApiController]
    public class SystemLanguageCodeController : ControllerBase
    {
        private readonly SystemLanguageCodeLogic _logic;

        public SystemLanguageCodeController()
        {
            var repo = new EFGenericRepository<SystemLanguageCodePoco>();
            _logic = new SystemLanguageCodeLogic(repo);
        }

        //Get on ID
        [HttpGet]
        [Route("languagecode/{id}")]
        [ProducesResponseType(200, Type = typeof(SystemLanguageCodePoco))]
        public ActionResult GetSystemLanguageCode(string id)
        {
            SystemLanguageCodePoco poco = _logic.Get(id);
            if (poco == null)
            {
                //404
                return NotFound();
            }
            else
            {
                //200
                return Ok(poco);
            }
        }

        //Get All
        [HttpGet]
        [Route("languagecode")]
        [ProducesResponseType(200, Type = typeof(List<SystemLanguageCodePoco>))]
        public ActionResult GetAllSystemLanguageCode()
        {
            List<SystemLanguageCodePoco> pocos = _logic.GetAll();
            if (pocos == null)
            {
                //404
                return NotFound();
            }
            else
            {
                //200
                return Ok(pocos);
            }

        }

        //Post
        //To force Web API to read a simple type from the request body, add the[FromBody] attribute to the parameter
        [HttpPost]
        [Route("languagecode")]
        public ActionResult PostSystemLanguageCode([FromBody] SystemLanguageCodePoco[] systemLanguageCodePocos)
        {
            _logic.Add(systemLanguageCodePocos);
            return Ok();
        }

        //Put
        //To force Web API to read a simple type from the request body, add the[FromBody] attribute to the parameter
        [HttpPut]
        [Route("languagecode")]
        public ActionResult PutSystemLanguageCode([FromBody] SystemLanguageCodePoco[] systemLanguageCodePocos)
        {
            _logic.Update(systemLanguageCodePocos);
            return Ok();
        }

        //Delete
        //To force Web API to read a simple type from the request body, add the[FromBody] attribute to the parameter
        [HttpDelete]
        [Route("languagecode")]
        public ActionResult DeleteSystemLanguageCode([FromBody] SystemLanguageCodePoco[] systemLanguageCodePocos)
        {
            _logic.Delete(systemLanguageCodePocos);
            return Ok();
        }

    }
}