﻿using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            // put your code here
            int Years = 0;
           // throw new NotImplementedException();
            while (initialPopulation <= currentPopulation)
            {
                initialPopulation = initialPopulation + (int)(initialPopulation * percent / 100) + visitors;
                Years = Years + 1;
            }
            return Years;
        }
    }
}