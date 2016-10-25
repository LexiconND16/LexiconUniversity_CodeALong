using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LexiconUniversity.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Display(Name = "Course Title")]
        public string Title { get; set; }

        [Display(Name = "Number of Students")]
        public int StudentCount => Students.Count; 

        public virtual List<Student> Students { get; set; }

        public virtual List<Teacher> Teachers { get; set; }
    }
}