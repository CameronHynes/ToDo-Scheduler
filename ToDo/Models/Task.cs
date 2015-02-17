using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDo.Models
{


    public class Task
    {
        public int ID { get; set; }

        [Required]
        [MinLength(1)]
        [Display(Name = "Task Description")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:mm:dd:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime StartTime { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:mm:dd:hh:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.DateTime)]
        public DateTime DeadLine { get; set; }

       
        // Navigation properties
        //public virtual Schedule Schedule { get; set; }
    }


}