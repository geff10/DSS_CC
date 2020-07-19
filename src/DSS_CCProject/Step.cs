namespace DSS_CCProject
{
    public class Step
    {
        private long id;
        private long jobID;
        private int effortTime;
        private Consts.OperationType operationType;

        public long ID { get => id; set => id = value; }
        public long JobID { get => jobID; set => jobID = value; }
        /// <summary>
        /// in minutes
        /// </summary>
        public int EffortTime { get => effortTime; set => effortTime = value; }
        public Consts.OperationType MachineType { get => operationType; set => operationType = value; }
    }
}