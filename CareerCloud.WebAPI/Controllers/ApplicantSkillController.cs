﻿using System;
using System.Collections.Generic;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using Microsoft.AspNetCore.Mvc;

namespace CareerCloud.WebAPI.Controllers
{
    [Route("api/careercloud/applicant/v1")]
    [ApiController]
    public class ApplicantSkillController : ControllerBase
    {
        private readonly ApplicantSkillLogic _logic;        

        public ApplicantSkillController()
        {
            var repo = new EFGenericRepository<ApplicantSkillPoco>();
            _logic = new ApplicantSkillLogic(repo);


        }

        //Get on ID
        [HttpGet]
        [Route("skill/{id}")]
        
        [ProducesResponseType(200, Type = typeof(ApplicantSkillPoco))]
        public ActionResult GetApplicantSkill(Guid id)
        {
            ApplicantSkillPoco poco = _logic.Get(id);
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
        [Route("skill")]

        [ProducesResponseType(200, Type = typeof(List<ApplicantSkillPoco>))]
        public ActionResult GetAllApplicantSkill()
        {
            List<ApplicantSkillPoco > pocos = _logic.GetAll();
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
        [Route("skill")]
        public ActionResult PostApplicantSkill([FromBody] ApplicantSkillPoco[] applicantSkillPocos)
        {
            _logic.Add(applicantSkillPocos);
            return Ok();
        }

        //Put
        //To force Web API to read a simple type from the request body, add the[FromBody] attribute to the parameter
        [HttpPut]
        [Route("skill")]
        public ActionResult PutApplicantSkill([FromBody] ApplicantSkillPoco[] applicantSkillPocos)
        {
            _logic.Update(applicantSkillPocos);
            return Ok();
        }

        //Delete
        //To force Web API to read a simple type from the request body, add the[FromBody] attribute to the parameter
        [HttpDelete]
        [Route("skill")]
        public ActionResult DeleteApplicantSkill([FromBody] ApplicantSkillPoco[] applicantSkillPocos)
        {
            _logic.Delete(applicantSkillPocos);
            return Ok();
        }




    }
}