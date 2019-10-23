namespace BeehiveManager
{
    public class Worker
    {
        private readonly string[] _jobsICanDo;
        private int _shiftsToWork;
        private int _shiftsWorked;

        public string CurrentJob { get; private set; } = string.Empty;
        // retorna a tarefa atual ou se ociosa uma string vazia
        // utilizar IsNullOrEmpty()
        public int ShiftsLeft => _shiftsToWork - _shiftsWorked;

        public Worker(string[] jobsICanDo)
        {
            _jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string job, int shifts)
        {
            // a rainha tenta atribuir uma tarefa à operária usando este
            // método. Se estiver desocupada e souber fazer, ela aceitará
            // e retornará true

            // o objeto checa sua matriz para ver se pode realizar o trabalho
            // e então associa shiftsToWork à duração do trabalho, CurrentJob
            // ao trabalho e shiftNumber a zero

            if (ShiftsLeft == 0)
            {
                foreach (string work in _jobsICanDo)
                {
                    if (work == job)
                    {
                        _shiftsToWork = shifts;
                        CurrentJob = job;
                        return true;
                    }
                }
            }
            return false;
        }

        public void WorkOneShift()
        {
            // trabalha um turno e controla quantos turnos faltam para a
            // tarefa atual. Se o trabalho terminar, reinicia o trabalho
            // atual para uma string vazia

            // diminui um de shiftNumber

            if(++_shiftsWorked == 0)
            {
                CurrentJob = string.Empty;
            }
        }
    }
}