using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegressionAnalysis
{
    class SalaryData
    {
        [LoadColumn(0)]
        public float YearsExperience;

        [LoadColumn(1), ColumnName("Label")]
        public float Salary;
    }
}
