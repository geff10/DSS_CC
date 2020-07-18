using System;
using System.Collections.Generic;
using System.Text;

namespace DSS_CCProject
{
    public class Job
    {
        private List<Step> steps;

        public List<Step> Steps { get => steps; set => steps = value; }
    }
}
