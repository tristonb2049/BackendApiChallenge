using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BackendApiChallenge.Supporting_Classes
{
    public class JsonParser
    {
        
        public JsonParser()
        {
            
        }
        public List<Supervisor> ParseAndSortJsonList(List<Supervisor> jsonData)
        {
            try
            {
                var removeJurisdictionNumberResults = jsonData.Where(c => !ContainsNum(c.jurisdiction)).ToList();
                var alphabetizedJson = removeJurisdictionNumberResults.OrderBy(c => c.jurisdiction).ThenBy(c => c.lastName).ThenBy(c => c.firstName).ToList();
                return alphabetizedJson;
            }
            catch(Exception e)
            {
                throw new Exception("The following error occurred when trying to sort the json list: " + e);
            }
        }
        private bool ContainsNum(string supervisor)
        {
            if (Regex.IsMatch(supervisor, @"\d"))
            {
                return true;
            }
            return false;
        }
    }
}
