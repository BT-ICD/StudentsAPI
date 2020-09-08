using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using StudentsAPI.Model;
namespace StudentsAPI.Services
{
    public class ResultService
    {
        private readonly IMongoCollection<StudentResult> _results;
        public ResultService(ITestResultDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _results = database.GetCollection<StudentResult>(settings.TestResultCollectionName);
        }
        public List<StudentResult> GetResults()=>
            _results.Find(result => true).ToList();
        public StudentResult GetResultByEnrollmentNo(string enrollmentNo) =>
            _results.Find(result => result.enrollmentNo == enrollmentNo).FirstOrDefault();
    }
}
