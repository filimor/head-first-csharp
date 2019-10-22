namespace BeehiveManager
{
    public class Worker
    {
        private readonly string[] _jobsICanDo;
        private readonly int _shiftsToWork;
        private readonly int _shiftsWorked;

        public string CurrentJob { get; }
        public int ShiftsLeft => _shiftsToWork - _shiftsWorked;

        public Worker(string[] jobsICanDo)
        {
            _jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string job)
        {
            return true;
        }

        public void WorkOneShift()
        {
        }
    }
}