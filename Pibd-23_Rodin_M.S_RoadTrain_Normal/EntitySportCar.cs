using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pibd_23_Rodin_M.S_RoadTrain_Normal
{
    public class EntitySportCar
    {
        public int Speed { get; private set; }

        public double Weight { get; private set; }

        public Color BodyColor { get; private set; }

        public Color AdditionalColor { get; private set; }

        public bool BodyKit { get; private set; }

        public bool Wing { get; private set; }

        public bool SportLine { get; private set; }

        public double Step => (double)Speed * 100 / Weight;

        public void Init(int speed, double weight, Color bodyColor, Color
additionalColor, bool bodyKit, bool wing, bool sportLine)
        {
            Speed = speed;
            Weight = weight;
            BodyColor = bodyColor;
            AdditionalColor = additionalColor;
            BodyKit = bodyKit;
            Wing = wing;
            SportLine = sportLine;


        }


    }
}
