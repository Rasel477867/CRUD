using Finalproejt1.Models;
using Finalproejt1.Repositery;

namespace Finalproejt1.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepositery _obj;
        public StudentService(IStudentRepositery studentRepositery)
        {
            _obj = studentRepositery;
        }
        public List<Student> Getall()
        {
         var obj=_obj.Getall();
            return obj;
            
        }

        public void update(Student student)
        { 
            throw new NotImplementedException();
        }
        public void Insert(Student student) 
        {
           if(student.Name!=null)
            {
                _obj.Insert(student);
            }
           
        }
        public bool Delete(int id) { 
        if(id>=20)
            {
                _obj.Delete(id);
                return true;
            }
        else 
                return false;
        }
        public Student GetStudent(int id)
        {
          return _obj.GetStudnet(id);
        }
    }
}
