using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveSimulator
{
    public class Flower
    {
        private const int LIFESPANMIN = 15000;
        private const int LIFESPANMAX = 30000;
        private const double INITIALNECTAR = 1.5;
        private const double MAXNECTAR = 5;
        private const double NECTARADDEDPERTURN = 0.01;
        private const double NECTARGATHEREDPERTURN = 0.03;

        private int _lifespan;

        public Point Location { get; private set; }
        public int Age { get; private set; }
        public bool Alive { get; private set; } = true;
        public double Nectar { get; private set; } = INITIALNECTAR;
        public double NectarHarvested { get; set; }

        public Flower(Point location, Random random)
        {
            Location = location;
            _lifespan = random.Next(LIFESPANMIN, LIFESPANMAX + 1);
        }

        public double HarvestNectar()
        {
            // Checa se o néctar colhido no ciclo é maior do que a quantidade restante.
            // Se for o caso, deve retornar 0. Se não, deve retirar a quantidade
            // coletada num ciclo do total restante da flor e retornar quanto foi
            // coletado. Adicionar a quantidade colhida a NectarHarvested, que manterá
            // o total de néctar coletado de cada flor em particular.
        }

        public void Go()
        {
            // Faz as flores funcionarem. Cada vez que esse método for chamado, um ciclo
            // se passará, então atualize a idade da flor corretamente. Ver se a idade é 
            // maior do que o tempo de vida, e se for o caso, a flor deve morrer.
            // Se a flor continuar viva, será preciso adicionar a quantidade de néctar
            // que cada flor produz num ciclo. Não ultrapassar o limite de néctar que
            // uma flor pode manter.
        }
    }
}
