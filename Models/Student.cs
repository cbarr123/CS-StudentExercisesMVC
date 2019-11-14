using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string SlackHandle { get; set; }
        [Required]
        public int CohortId { get; set; }
        public Cohort Cohort { get; set; }

        public List<Exercise> Exercises = new List<Exercise>();
    }
}
