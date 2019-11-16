using System;
using System.Drawing;

namespace BeehiveSimulator
{
    public class Bee
    {
        private const double HONEYCONSUMED = 0.5;
        private const int MOVERATE = 3;
        private const double MINIMUMFLOWERNECTAR = 1.5; // Como ela sabe quais flores podem ser coletadas.
        private const int CAREERSPAN = 1000;
        private const double MAKEHONEYRATE = 0.5;

        private int _id; // Cada abelha receberá um número exclusivo de identificação.
        private Flower _destinationFlower;
        private Point _location;

        public int Age { get; private set; }
        public bool InsideHive { get; private set; } = true;
        public double NectarCollected { get; private set; }
        public BeeState CurrentState { get; private set; } = BeeState.Idle;
        public Point Location => _location;

        public Bee(int id, Point location)
        {
            _id = id;
            _location = location;
        }

        public void Go(Random random)
        {
            Age++;
            switch (CurrentState)
            {
                case BeeState.Idle:
                    if (Age > CAREERSPAN)
                    {
                        CurrentState = BeeState.Retired;
                    }
                    else
                    {
                        // O que fazer quando está desocupada?
                    }
                    break;
                case BeeState.FlyingToFlower:
                    // Vá no sentido de uma flor
                    break;
                case BeeState.GatheringNectar:
                    double nectar = _destinationFlower.HarvestNectar();
                    if (nectar>0)
                    {
                        NectarCollected += nectar;
                    }
                    else
                    {
                        CurrentState = BeeState.ReturningToHive;
                    }
                    break;
                case BeeState.ReturningToHive:
                    if (!InsideHive)
                    {
                        // Avança no sentido da colméia.
                    }
                    else
                    {
                        // O que fazer no interior da colméia?
                    }
                    break;
                case BeeState.MakingHoney:
                    if (NectarCollected < MAKEHONEYRATE)
                    {
                        NectarCollected = 0;
                        CurrentState = BeeState.Idle;
                    }
                    else
                    {
                        // Uma vez que temos um enxame, vamos tornar o néctar em mel
                    }
                    break;
                case BeeState.Retired:
                    // Não faz nada, já que está aposentada.
                    break;
            }
        }

        private bool MoveTowardsLocation(Point destination)
        {
            if (destination != null)
            {
                if (Math.Abs(destination.X - Location.X) <= MOVERATE &&
                    Math.Abs(destination.Y - Location.Y) <= MOVERATE)
                {
                    return true;
                }
                if (destination.X > Location.X)
                {
                    _location.X += MOVERATE;
                }
                else if (destination.X < Location.X)
                {
                    _location.X -= MOVERATE;
                }
                if (destination.Y > Location.Y)
                {
                    _location.Y += MOVERATE;
                }
                else if (destination.Y < Location.Y)
                {
                    _location.Y -= MOVERATE;
                }
            }
            return false;
        }
    }
}