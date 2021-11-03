using System;

namespace BackendApiChallenge
{
    public class Supervisor //used json2cshartp.com in order to get fields correctly based on json data
    {
        public string id { get; set; }
        public string phone { get; set; }
        public string jurisdiction { get; set; }
        public string identificationNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
