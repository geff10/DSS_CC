using System;
using System.Collections.Generic;
using System.Text;

namespace DSS_CCProject
{
    public class StepGeneValueWrapper
    {
        private List<Step> steps;
        public int Length { get; private set; }

        public Step this[int i]
        {
            get { return steps[i]; }
            set { steps[i] = value; }
        }
    }
}
