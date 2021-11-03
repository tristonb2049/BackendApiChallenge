using BackendApiChallenge.Model;
using BackendApiChallenge.Supporting_Classes;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BackendApiChallenge.Controllers
{
    [ApiController]
    [Route("api")]
    [Produces("application/json")]
    public class SupervisorController : ControllerBase
    {
        [HttpGet("supervisors")]
        public async Task<IActionResult> Get()
        {
            HttpClient client = new HttpClient();

            string URL = "https://o3m5qixdng.execute-api.us-east-1.amazonaws.com/api/managers";

            List<Supervisor> result;

            string responseAsString = string.Empty;

            try
            {
                var response = client.GetAsync(URL).Result;

                if (response.IsSuccessStatusCode)//Verification
                {
                    responseAsString = await response.Content.ReadAsStringAsync();
                }
                result = JsonConvert.DeserializeObject<List<Supervisor>>(responseAsString);
            }
            catch(Exception e)
            {
                Console.WriteLine("The following error occurred when trying to grab JSON data: " + e);
                return BadRequest(e);
            }

            //Separate the parsing methods into new class to avoid too much clutter
            JsonParser jsonParser = new JsonParser();
            var parsedAndSortedJson = jsonParser.ParseAndSortJsonList(result);

            if(parsedAndSortedJson == null)
            {
                return NotFound();//data is not present
            }
            return Ok(parsedAndSortedJson.Select(c => string.Format($"{c.jurisdiction} - {c.lastName}, {c.firstName}")));
        }

        [HttpPost("submit")]
        public IActionResult Post(DataToSubmit data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Console.WriteLine($"First Name: {data.firstName}");//Required
                Console.WriteLine($"Last Name: {data.lastName}");//Required
                Console.WriteLine($"Supervisor: {data.supervisor}");//Required
                Console.WriteLine("Email: {0}", string.IsNullOrEmpty(data.email) ? "None Submitted" : data.email);
                Console.WriteLine("Phone Number: {0}", string.IsNullOrEmpty(data.phoneNumber) ? "None Submitted" : data.phoneNumber);
                return Ok(data);
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
