using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalExam.Models
{
    public partial class Entertainer
    {
        [Key]
        [Required]
        public int EntertainerId { get; set; }
        public string EntStageName { get; set; }
        public int? EntSsn { get; set; }
        public string EntStreetAddress { get; set; }
        public string EntCity { get; set; }
        public string EntState { get; set; }
        public int EntZipCode { get; set; }
        public int EntPhoneNumber { get; set; }
        public string EntWebPage { get; set; }
        public string EntEmailAddress { get; set; }
        public DateTime DateEntered { get; set; }
    }
}
