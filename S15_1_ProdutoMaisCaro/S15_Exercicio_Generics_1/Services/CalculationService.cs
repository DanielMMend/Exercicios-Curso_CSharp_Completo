﻿using System;
using System.Collections.Generic;

namespace S15_Exercicio_Generics_1.Services
{
    class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            T max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
