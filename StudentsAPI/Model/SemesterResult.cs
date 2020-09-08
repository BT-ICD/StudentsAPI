using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StudentsAPI.Model
{
    public class SemesterResult
    {
        [BsonElement("semesterName")]
        public string semesterName { get; set; }

        [BsonElement("examYear")]
        public string examYear { get; set; }
        [BsonElement("seatNumber")]
        public string seatNumber { get; set; }
        [BsonElement("resultClass")]
        public string resultClass { get; set; }
        [BsonElement("status")]
        public string status { get; set; }
        [BsonElement("resultdData")]
        public List<ResultData> resultdData { get; set; }
    }
    public class ResultData
    {
        [BsonElement("resDataId")]
        public int resDataId { get; set; }
        [BsonElement("subjectId")]
        public int subjectId { get; set; }
        [BsonElement("subject")]
        public string subject { get; set; }
        [BsonElement("total")]
        public string total { get; set; }
        [BsonElement("grade")]
        public string grade { get; set; }
        [BsonElement("marks")]
        public List<MarksData> marks { get; set; }
    }
    public class MarksData
    {
        [BsonElement("max")]
        public string max { get; set; }
        [BsonElement("min")]
        public string min { get; set; }
        [BsonElement("obtain")]
        public string obtain { get; set; }
    }
}
