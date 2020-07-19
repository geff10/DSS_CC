using System;
using System.Collections.Generic;
using System.Text;
using static DSS_CCProject.Consts;

namespace DSS_CCProject
{
    class Machine
    {
        private long id;
        private MachineType machineType;

        public long Id { get => id; set => id = value; }
        public MachineType MachineType { get => machineType; set => machineType = value; }

        public Machine()
        {
        }

        public Machine(long machineId, MachineType machineType)
        {
            this.id = machineId;
            this.machineType = machineType;
        }
    }
}
