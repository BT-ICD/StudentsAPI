using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using StudentsAPI.Model;

namespace StudentsAPI.Services
{
    public class StudentService
    {
        private readonly IMongoCollection<Student> _students;
        public StudentService(ITestResultDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _students = database.GetCollection<Student>(settings.StudentsCollectionName);
        }

        public List<Student> GetStudents() =>
                _students.Find(student => true).ToList();

        public Student GetById(string id) =>
            _students.Find(student => student.Id == id).FirstOrDefault();
    }
}
