using Finalproejt1.Models;

namespace Finalproejt1.Repositery
{
    public interface IStudentRepositery
    {
        List<Student> Getall();
        public void Update(Student student);
        public void Insert(Student student);
        public void Delete(int id);
        public Student GetStudnet(int id);
    }
}
