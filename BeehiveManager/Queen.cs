using System.Text;

namespace BeehiveManager
{
    public class Queen
    {
        // A rainnha seleciona a tarefa a ser feita não importando qual abelha
        // e o programa deve descobrir se há uma operária disponível e
        // atribuir o trabalho a ela

        // usa shiftsLeft da operária para ver quantos turnos faltam

        private readonly Worker[] _workers;
        private int _shiftNumber = 1;

        public Queen(Worker[] workers)
        {
            _workers = workers;
        }

        public bool AssignWork(string job, int shifts)
        {
            // retorna true se encontrar uma operária para atribuir o trabalho
            // se houver uma abelha disponível o programa deve atribuir e
            // avisar a rainha que o trabalho será feito

            // itera pela matriz e tenta atribuir a cada operária usando
            // seu método DoThisJob()

            foreach (Worker bee in _workers)
            {
                if(string.IsNullOrEmpty(bee.CurrentJob) &&
                    bee.DoThisJob(job, shifts))
                {
                    return true;
                }
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            // manda cada objeto Worker trabalhar um turno e então checa
            // o estado da operária para adicionar uma linha ao relatório
            // gera um relatório que deve retornar quais abelhas trabalharam,
            // quais tarefas fizeram e quantos turnos elas trabalharam em cada
            // tarefa

            var report = new StringBuilder();
            report.Append("Relatório para o turno ").Append(_shiftNumber++).AppendLine();

            for (int i = 0; i < _workers.Length; i++)
            {
                if (string.IsNullOrEmpty(_workers[i].CurrentJob))
                {
                    report.Append("Operária ").Append(i + 1).AppendLine(" não está trabalhando.");
                }else if(_workers[i].ShiftsLeft>=3){
                    report.Append("Operária ").Append(i + 1).Append(" fará '").Append(_workers[i].CurrentJob).Append("' por mais ").Append(_workers[i].ShiftsLeft).AppendLine(" turnos.");
                }
                else if (_workers[i].ShiftsLeft >= 2)
                {
                    report.Append("Operária ").Append(i + 1).Append(" fará '").Append(_workers[i].CurrentJob).AppendLine("' por mais 1 turno.");
                }
                else if (_workers[i].ShiftsLeft >= 1)
                {
                    report.Append("Operária ").Append(i + 1).Append(" terminará '").Append(_workers[i].CurrentJob).AppendLine("' neste turno.");
                }
                else
                {
                    report.Append("Operária ").Append(i + 1).AppendLine(" terminou o trabalho.");
                }

                if (!string.IsNullOrEmpty(_workers[i].CurrentJob))
                {
                    _workers[i].WorkOneShift();
                }
            }

            return report.ToString();
        }
    }
}