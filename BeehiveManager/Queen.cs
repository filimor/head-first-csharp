using System.Text;

namespace BeehiveManager
{
    public class Queen : Bee
    {
        // A rainnha seleciona a tarefa a ser feita não importando qual abelha e o programa deve
        // descobrir se há uma operária disponível e atribuir o trabalho a ela

        // usa shiftsLeft da operária para ver quantos turnos faltam

        private readonly Worker[] _workers;
        private int _shiftNumber = 1;

        public Queen(Worker[] workers) : base(275)
        {
            _workers = workers;
        }

        public bool AssignWork(string job, int shifts)
        {
            // retorna true se encontrar uma operária para atribuir o trabalho se houver uma abelha
            // disponível o programa deve atribuir e avisar a rainha que o trabalho será feito

            // itera pela matriz e tenta atribuir a cada operária usando seu método DoThisJob()

            foreach (Worker bee in _workers)
            {
                if (bee.DoThisJob(job, shifts))
                {
                    return true;
                }
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            // manda cada objeto Worker trabalhar um turno e então checa o estado da operária para
            // adicionar uma linha ao relatório gera um relatório que deve retornar quais abelhas
            // trabalharam, quais tarefas fizeram e quantos turnos elas trabalharam em cada tarefa

            // alterar o relatório para incluir o consumo de mel de cada operária já que ela mesma
            // consome mel também, terá de herdar de Bee e sobrepor seu método GetHoneyConsumption()

            // incluir um laço para somar os consumos de mel para cada operária e encontrar a de
            // maior consumo - antes de dizer a cada uma para trabalhar o próximo turno

            // somar os valores ao seu próprio número e incluir no relatório

            double totalConsumption = 0;
            foreach (Worker bee in _workers)
            {
                totalConsumption += bee.GetHoneyConsumption();
            }
            totalConsumption += GetHoneyConsumption();

            var report = new StringBuilder();
            report.Append("Relatório para o turno ").Append(_shiftNumber++).AppendLine();

            for (int i = 0; i < _workers.Length; i++)
            {
                if (_workers[i].WorkOneShift())
                {
                    report.Append("Operária ").Append(i + 1).AppendLine(" terminou o trabalho.");
                }
                else if (string.IsNullOrEmpty(_workers[i].CurrentJob))
                {
                    report.Append("Operária ").Append(i + 1).AppendLine(" não está trabalhando.");
                }
                else if (_workers[i].ShiftsLeft > 1)
                {
                    report.Append("Operária ").Append(i + 1).Append(" fará '").Append(_workers[i].CurrentJob).Append("' por mais ").Append(_workers[i].ShiftsLeft).AppendLine(" turnos.");
                }
                else if (_workers[i].ShiftsLeft > 0)
                {
                    report.Append("Operária ").Append(i + 1).Append(" fará '").Append(_workers[i].CurrentJob).AppendLine("' por mais 1 turno.");
                }
                else
                {
                    report.Append("Operária ").Append(i + 1).Append(" terminará '").Append(_workers[i].CurrentJob).AppendLine("' neste turno.");
                }
            }

            report.Append("Consumo de Mel Total: ").Append(totalConsumption.ToString("F3")).AppendLine(" unidades.");
            return report.ToString();
        }

        public override double GetHoneyConsumption()
        {
            double totalConsumption = 0;
            double higherConsumption = 0;
            int totalWorkers = 0;

            foreach (Worker bee in _workers)
            {
                if (bee.ShiftsLeft > 0)
                {
                    totalWorkers++;
                }

                double consumption = bee.GetHoneyConsumption();
                if (consumption > higherConsumption)
                {
                    higherConsumption = consumption;
                }
            }

            totalConsumption += higherConsumption;
            totalConsumption += totalWorkers > 2 ? 30 : 20;
            return totalConsumption;
        }
    }
}