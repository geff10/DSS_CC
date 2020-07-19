using System;
using System.Collections.Generic;
using System.Text;
using static DSS_CCProject.Consts;

namespace DSS_CCProject
{
    class Machine
    {
        long id;
        MachineType machineType;

        public long Id { get => id; set => id = value; }
        public MachineType MachineType { get => machineType; set => machineType = value; }
    }
}
