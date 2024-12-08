using RelationshipMVC.Models.One_to_One_Mapping;

namespace RelationshipMVC.Models.one_to_many_mapping
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }   
        public string Section { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
