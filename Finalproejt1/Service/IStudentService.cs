using Finalproejt1.Models;

namespace Finalproejt1.Service
{
    public interface IStudentService
    {
        List<Student> Getall();
        public void update(Student student);
        public void Insert(Student student);
        public bool Delete(int id);
        public Student GetStudent(int id);
    }
}
