using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Interfaces;
using TestApplication.Models;

namespace TestApplication.Services
{
    public class TestReportRepository : ITestReport
    {
        public async Task<List<TestReport>> GetTestReports(int input)
        {
            List<TestReport> testReports = new();

            for (var i = 0; i < input; i++)
            {
                Random rnds = new Random();
                int nums = rnds.Next(1, 10);

                Random rnd = new Random();
                int num = rnd.Next();

                TestReport testReport = new TestReport();

                if(nums >= 1 && nums <= 4)
                {
                    testReport.Data = num.ToString();
                    testReport.Type = "numeric";
                }
                else if(nums >= 5 && nums <= 7)
                {
                    double min = 1;
                    double max = 100000;
                    double range = max - min;
                    double sample = rnd.NextDouble();
                    double scaled = (sample * range) + min;
                    float f = (float)scaled;

                    testReport.Data = f.ToString();
                    testReport.Type = "float";
                }
                else 
                {
                    var characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                    var Charsarr = new char[10];

                    for (int j = 0; j < Charsarr.Length; j++)
                    {
                        Charsarr[j] = characters[rnd.Next(characters.Length)];
                    }

                    var resultString = new String(Charsarr);

                    testReport.Data = resultString;
                    testReport.Type = "alphanumeric";
                }

                //switch (nums)
                //{
                //    case 1:
                //        testReport.Data = num.ToString();
                //        testReport.Type = "numeric";
                //        break;
                //    case 2:
                //        // Float
                //        double min = 1;
                //        double max = 100000;
                //        double range = max - min;
                //        double sample = rnd.NextDouble();
                //        double scaled = (sample * range) + min;
                //        float f = (float)scaled;


                //        testReport.Data = f.ToString();
                //        testReport.Type = "float";
                //        break;
                //    case 3:
                //        //Alphanumeric
                //        var characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                //        var Charsarr = new char[10];

                //        for (int j = 0; j < Charsarr.Length; j++)
                //        {
                //            Charsarr[j] = characters[rnd.Next(characters.Length)];
                //        }

                //        var resultString = new String(Charsarr);

                //        testReport.Data = resultString;
                //        testReport.Type = "alphanumeric";
                //        break;
                //}

                testReports.Add(testReport);
            }

            return await Task.FromResult(testReports);
        }
    }
}
