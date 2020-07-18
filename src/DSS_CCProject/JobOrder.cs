using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSS_CCProject
{
    public class JobOrder
    {
        private int c_stepCount = 6;
        private List<Job> jobs;
        public int Length { get; private set; }

        public JobOrder()
        {
        }

        public JobOrder(List<Job> jobList)
        {
            this.jobs = jobList;
        }
        public Step this[int i]
        {
            get { return jobs.ElementAt(i / c_stepCount).Steps[i % c_stepCount]; }
            set { jobs.ElementAt(i / c_stepCount).Steps[i % c_stepCount] = value; }
        }

        public int GetStepCount()
        {
            return c_stepCount;
        }
    }
}
