using Finalproejt1.Data;
using Finalproejt1.Models;

namespace Finalproejt1.Repositery
{
    public class StudentRepositery : IStudentRepositery
    {
        private readonly ApplicationDb _db;
        public StudentRepositery(ApplicationDb db)
        {
            _db = db;
        }
        public List<Student> Getall()
        {
            return _db.Students.ToList();
            
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
        public void Insert(Student student) {
            _db.Add(student);
            _db.SaveChanges();

        }
        public void Delete(int id) {
            var obj=_db.Students.Where(s => s.Age==id).FirstOrDefault();
            _db.Remove(obj);
            _db.SaveChanges();
           
        }

        public Student GetStudnet(int id)
        {
            return _db.Students.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
