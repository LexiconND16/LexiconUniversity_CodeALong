using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LexiconUniversity.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name="Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}