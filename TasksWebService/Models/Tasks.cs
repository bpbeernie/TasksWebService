using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TasksWebService.Models
{
    public class Tasks
    {
        [Key]
        public int ID { get; set; }

        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Priority { get; set; }
        public String Category { get; set; }
        public int Status { get; set; }
    }
}
