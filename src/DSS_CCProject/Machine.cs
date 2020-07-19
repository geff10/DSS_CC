using System;
using System.Collections.Generic;
using System.Text;
using static DSS_CCProject.Consts;

namespace DSS_CCProject
{
    public class Machine
    {
        private long id;
        private OperationType machineType;

        public long Id { get => id; set => id = value; }
        public OperationType OperationType { get => machineType; set => machineType = value; }

        public Machine()
        {
        }

        public Machine(long machineId, OperationType machineType)
        {
            this.id = machineId;
            this.machineType = machineType;
        }
    }
}
