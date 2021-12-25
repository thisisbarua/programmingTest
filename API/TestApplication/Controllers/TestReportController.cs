using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.DTO;
using TestApplication.Interfaces;
using TestApplication.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestReportController : ControllerBase
    {
        private readonly ITestReport _testReps;

        public TestReportController(ITestReport testReps)
        {
            _testReps = testReps;
        }


        [HttpGet("getTestReport/{size}")]
        public async Task<ActionResult<Response>> GetReport(int input)
        {
            List<TestReport> _reports = new();
            _reports = await _testReps.GetTestReports(input);

            int totalCounts = _reports.Count;

            //string path = "C:\\Users\\Dell\\.txt";
            //FileStream uploadFileStream = System.IO.File.OpenRead(path);

            //using (StreamWriter writeIt = new StreamWriter(uploadFileStream))
            //{
            //    foreach (var value in _reports)
            //    {
            //        writeIt.Write(value.Data);
            //    }
            //}
            //uploadFileStream.Flush();
            //uploadFileStream.Close();
 
            //string fullPath = @"C:\Users\Dell\Desktop\test.txt";

  
            //string authors = (string.Join(",", _reports.Select(x => x.Data))).ToString();

            //System.IO.File.WriteAllText(fullPath, authors);


            return StatusCode(StatusCodes.Status200OK, new Response
            {
                Message = "Generated Report",
                Success = true,
                Payload = new
                {
                    output = _reports,
                    //totalCount = authors,
                    totalNumeric = _reports.Count(x => x.Type == "numeric"),
                    totalAlphaNumeric = _reports.Count(x => x.Type == "alphanumeric"),
                    totalFloat = _reports.Count(x => x.Type == "float"),
                    NumericPercent = (_reports.Count(x => x.Type == "numeric") * 100) / totalCounts,
                    AlphaNumericPercent = (_reports.Count(x => x.Type == "alphanumeric") * 100) / totalCounts,
                    FloatPercent = (_reports.Count(x => x.Type == "float") * 100) / totalCounts
                }
            });

            //return Ok(reports);
        }
    }
}
