using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class ConfigurationViewModel
    {
        [Required]
        [Display(Name = "Config Type")]
        public String configType { get; set; }

        [Required]
        [Display(Name = "Who is Requesting")]
        public String whoIsRequesting { get; set; }

        [Required]
        [Display(Name = "Ticket")]
        public String ticket { get; set; }
    }

    public class ActorViewModel
    {
        [Display(Name = "Actors Name")]
        public String name { get; set; }

        [Display(Name = "Last Name")]
        public String lastname { get; set; }

        [Display(Name = "Age")]
        public int age { get; set; }
    }
}