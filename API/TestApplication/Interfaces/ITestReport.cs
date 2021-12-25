using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestApplication.Models;

namespace TestApplication.Interfaces
{
    public interface ITestReport
    {
        Task<List<TestReport>> GetTestReports(int input);
    }
}
