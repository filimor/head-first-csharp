namespace BeehiveManager
{
    public class Queen
    {
        private readonly Worker[] _workers;
        private readonly int _shiftNumber;

        public Queen(Worker[] workers)
        {
            _workers = workers;
        }

        public bool AssignWork(string job, int shifts)
        {
            // retorna true se encontrar uma operária para atribuir o trabalho
            return true;
        }

        public void WorkTheNextShift()
        {
            // manda as abelhas trabalharem e gera um relatório
        }
    }
}