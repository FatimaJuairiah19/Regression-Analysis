using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegressionAnalysis
{
    class SalaryPrediction
    {
        [ColumnName("Score")]
        public float PredictedSalary { get; set; }

    }
}
