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
        private const double ADDNECTARRATE = 0.5;

        private int _id; // Cada abelha receberá um número exclusivo de identificação.
        private Flower _destinationFlower;
        private World _world;
        private Hive _hive;
        private Point _location;

        public int Age { get; private set; }
        public bool InsideHive { get; private set; } = true;
        public double NectarCollected { get; private set; }
        public BeeState CurrentState { get; private set; } = BeeState.Idle;
        public Point Location => _location;

        public Bee(int id, Point location, Hive hive, World world)
        {
            _id = id;
            _hive = hive;
            _world = world;
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
                    else if (_world.Flowers.Count > 0 && _hive.ConsumeHoney(HONEYCONSUMED))
                    {
                        Flower flower = _world.Flowers[random.Next(_world.Flowers.Count)];
                        if(flower.Nectar >= MINIMUMFLOWERNECTAR && flower.Alive)
                        {
                            _destinationFlower = flower;
                            CurrentState = BeeState.FlyingToFlower;
                        }
                    }
                    break;
                case BeeState.FlyingToFlower:
                    if (!_world.Flowers.Contains(_destinationFlower))
                    {
                        CurrentState = BeeState.ReturningToHive;
                    }else if (InsideHive)
                    {
                        if (MoveTowardsLocation(_hive.GetLocation("Exit")))
                        {
                            InsideHive = false;
                            _location = _hive.GetLocation("Entrance");
                        }
                    }
                    else if (MoveTowardsLocation(_destinationFlower.Location))
                    {
                        CurrentState = BeeState.GatheringNectar;
                    }
                    break;
                case BeeState.GatheringNectar:
                    double nectar = _destinationFlower.HarvestNectar();
                    if (nectar > 0)
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
                        if (MoveTowardsLocation(_hive.GetLocation("Entrance")))
                        {
                            InsideHive = true;
                            _location = _hive.GetLocation("Exit");
                        }
                    }
                    else
                    {
                        if (MoveTowardsLocation(_hive.GetLocation("HoneyFactory")))
                        {
                            CurrentState = BeeState.MakingHoney;
                        }
                    }
                    break;
                case BeeState.MakingHoney:
                    if (NectarCollected < ADDNECTARRATE)
                    {
                        NectarCollected = 0;
                        CurrentState = BeeState.Idle;
                    }
                    else if (_hive.AddHoney(ADDNECTARRATE))
                    {
                        NectarCollected -= ADDNECTARRATE;
                    }
                    else
                    {
                        NectarCollected = 0;
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