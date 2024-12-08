using Microsoft.AspNetCore.Http.HttpResults;

namespace RelationshipMVC.Models.One_to_One_Mapping
{
    public class StudentAddress
    {
        public int StudentAddressId { get; set; } // Primary key
        public string Address { get; set; }

        // Foreign key to link with Student
        public int StudentId { get; set; }// Foreign key - Dependent Entity

        // Navigation property to navigate to Student
        public Student Student { get; set; }
       
    }
}

