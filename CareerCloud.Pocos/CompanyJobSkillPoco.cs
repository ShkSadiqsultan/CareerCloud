﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Job_Skills")]
    public class CompanyJobSkillPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        [Column("Job")]
        public Guid Job { get; set; }

        [Column("Skill")]
        public string Skill { get; set; }
        [Column("Skill_Level")]
        public string SkillLevel { get; set; }
        public int Importance { get; set; }
        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }

        
        public virtual CompanyJobPoco CompanyJob { get; set; }
    }


}
