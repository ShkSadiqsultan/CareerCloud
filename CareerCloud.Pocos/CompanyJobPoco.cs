﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Jobs")]
    public class CompanyJobPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        [Column("Company")]
        public Guid Company { get; set; }
        [Column("Profile_Created")]
        public DateTime ProfileCreated { get; set; }
        [Column("Is_Inactive")]
        public bool IsInactive { get; set; }
        [Column("Is_Company_Hidden")]
        public bool IsCompanyHidden { get; set; }
        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }


        [ForeignKey("Company")]
        public CompanyJobPoco CompanyJobs { get; set; }

        public CompanyJobPoco Job { get; set; }


        public virtual CompanyProfilePoco CompanyProfile { get; set; }
        public virtual ICollection<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }

        public virtual ICollection<CompanyJobEducationPoco> CompanyJobEducations { get; set; }

        public virtual ICollection<CompanyJobSkillPoco> CompanyJobSkills { get; set; }

        public virtual ICollection<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }





    }
}