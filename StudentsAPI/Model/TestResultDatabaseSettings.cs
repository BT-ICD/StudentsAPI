using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAPI.Model
{
    /// <summary>
    /// Class used to store appsettings.json file's TestResultDatabaseSetting
    /// </summary>
    public interface ITestResultDatabaseSettings
    {
        string StudentsCollectionName { get; set; }
        string TestResultCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
    public class TestResultDatabaseSettings : ITestResultDatabaseSettings
    {
        public string StudentsCollectionName { get ; set ; }
        public string ConnectionString { get; set ; }
        public string DatabaseName { get ; set ; }
        public string TestResultCollectionName { get; set; }
    }
}
