using Microsoft.AspNetCore.Mvc.Rendering;
using StudentExercisesMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class StudentCreateViewModel
    {
        public List<SelectListItem> Cohorts { get; set; }
        public Student Student { get; set; }
    }
}
