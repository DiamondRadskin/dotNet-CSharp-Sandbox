using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Math_Exercises
{
    /*public enum planet
    {
        earth,
        mars,
        venus,
        jupiter,
        saturn,
        uranus,
        neptune,
        mercury


    }
    public enum gravityType
    {
        lowgravity,
        earthlike,
        highgravity





    }
    internal class ex5
    {
        public void exercise()
        {
            const double objectMassKG = 70.0;
            Dictionary<planet, double> determiner = new Dictionary<planet, double>();
            {
                

                Dictionary<planet, double> planetGravity = new()
                {
                     { planet.earth, 9.81 },
                     { planet.venus, 8.87 },
                     { planet.mercury, 3.7 },
                     { planet.mars, 3.72 },
                     { planet.jupiter, 24.79 },
                     { planet.uranus, 8.69 },
                     { planet.saturn, 10.44 },
                     { planet.neptune, 11.15 }
                };
                    List<string> extremeEnvironments = new();
                    List<string> habitableGravityEnvironments = new();

                foreach (var kvp in determiner)
                {
                    planet Planet = kvp.Key;
                    double gravityType = kvp.Value;

                    double weight = calculateWeight(objectMassKG, gravityType);
                }



            }

            





        }

        public static double calculateWeight(double massKG, double surfaceGravity)
        {
            double weight = massKG * surfaceGravity;

            return weight;




        }
      /*
        public static gravityType(double surfaceGravity)
        {

            if (surfaceGravity < 5.0)
            {
                return gravityType.lowgravity;
            }
            if (surfaceGravity >= 5.0 && surfaceGravity <= 15.0)
            {
                return gravityType.earthlike;
            }
            if (surfaceGravity > 15.0)
            {
                return gravityType.highgravity;
            }
      
        }
      */
    }

