using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BeeWorld
{
    [Serializable]
    class Flower
    {
        private const int LifrSpanMin = 15000;
        private const int LifeSpanMax = 30000;
        private const double InitialNectar = 1.5;
        private const double MaxNectar = 5;
        private const double NectarAddedPerTurn = 0.01;
        private const double NectarGatheredPerTurn = 0.3;

        private int lifespan;

        public Point Location { get; private set; }
        public int Age { get; private set; }
        public bool Alive { get; private set; }
        public double Nectar { get; private set; }
        public double NectarHarversted { get; set; }

        public Flower(Point location, Random random)
        {
            this.Location = location;
            this.Age = 0;
            this.Alive = true;
            this.Nectar = InitialNectar;
            this.NectarHarversted = 0;
            lifespan = random.Next(LifrSpanMin, LifeSpanMax + 1);
        }

        public double HarvestNectar()
        {
            if (NectarGatheredPerTurn > Nectar)
                return 0;
            else
            {
                Nectar -= NectarGatheredPerTurn;
                NectarHarversted += NectarGatheredPerTurn;
                return NectarGatheredPerTurn;
            }
        }

        public void Go()
        {
            this.Age++;
            if (Age > lifespan)
            {
                this.Alive = false;
            }
            else
            {
                this.Nectar += NectarAddedPerTurn;
                if (this.Nectar > MaxNectar)
                    this.Nectar = MaxNectar;
            }
        }
    }
}
