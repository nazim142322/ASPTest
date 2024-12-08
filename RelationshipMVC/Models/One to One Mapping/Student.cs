using RelationshipMVC.Models.one_to_many_mapping;

namespace RelationshipMVC.Models.One_to_One_Mapping
{
    public class Student
    {
        public int StudentId { get; set; } // Primary key - Principal Entity
        public string Name { get; set; }

        // Navigation property to navigate to StudentAddress
        public StudentAddress Address { get; set; }

        //one to many relationship
        public Grade Grade { get; set; }
    }

}
