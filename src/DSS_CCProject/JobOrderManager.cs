using System;
using System.Collections.Generic;
using System.Text;

namespace DSS_CCProject
{
    public class JobOrderManager
    {
        private List<JobOrder> jobOrders;

        public List<JobOrder> JobOrders { get => jobOrders; }

        public JobOrderManager()
        {

        }
        public void ReadJobOrders()
        {
            jobOrders = new List<JobOrder>();
            throw new NotImplementedException();
        }

    }
}
