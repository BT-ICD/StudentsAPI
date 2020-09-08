
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace StudentsAPI.Model
{
    public class StudentResult
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("enrollmentNo")]
        public string enrollmentNo { get; set; }

        [BsonElement("semesterResults")]
        public List<SemesterResult> semesterResults { get; set; }
    }
}
