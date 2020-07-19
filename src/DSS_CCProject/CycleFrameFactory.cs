using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using static DSS_CCProject.Consts;

namespace DSS_CCProject
{
    public class CycleFrameFactory
    {
        public static ReadOnlyCollection<Machine> Machines { get; } = new ReadOnlyCollection<Machine>(
        new Machine[] 
            {
                new Machine(0, OperationType.Cutting),
                new Machine(1, OperationType.Cutting),
                new Machine(2, OperationType.Cutting),
                new Machine(3, OperationType.Cutting),
                new Machine(4, OperationType.Cutting),
                new Machine(5, OperationType.Cutting),
                new Machine(6, OperationType.Blending),
                new Machine(7, OperationType.Blending),
                new Machine(8, OperationType.Welding),
                new Machine(9, OperationType.Welding),
                new Machine(10, OperationType.Welding),
                new Machine(11, OperationType.Testing),
                new Machine(12, OperationType.Painting),
                new Machine(13, OperationType.Painting),
                new Machine(14, OperationType.Painting),
                new Machine(15, OperationType.Painting),
                new Machine(16, OperationType.Packing),
                new Machine(17, OperationType.Packing),
                new Machine(18, OperationType.Packing)
            }
        );
    }
}
