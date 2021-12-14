using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolForeignKeys.Models
{
    public class TeacherSubject
    {
        //Class names don't need to match 
        //but property need to match whats in SQL 
        //Though you need extra in your model for .Net that is allowed
        [Key]
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }
        //Since this a many to many table, we need to put in a property for Teacher and for Subject, so we can 
        //easily represent that relationship to .Net 
        public Teacher Teacher { get; set; }
        public Subject Subject { get; set; }
    }
}
