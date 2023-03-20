using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad_GetPromedio.Contratos
{
    public class Media
    {
        public List<int> numberRandom(int n) 
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            var list = new List<int>();
            for (int i = 0; i < n; i++) 
            {
                list.Add( random.Next(0, 9));
            }
            return list.Order().ToList();
        }
        public double GetMedia(string agent, List<int> numbers) 
        {
            switch (agent) 
            {
                case "A":
                    return GetAverage(numbers);
                    break;
                case "B":
                    return GetArmonicMedia(numbers);
                    break; 
                case "C":
                    return GetMedian(numbers);
                    break;
                default:
                    return 0;
                    break;
            }
        }
        public string ResultMethod(string agent) 
        {
            switch (agent)
            {
                case "A":
                    return "Promedio";
                    break;
                case "B":
                    return "Media Amornica";
                    break;
                case "C":
                    return "Mediana";
                    break;
                default:
                    return null;
                    break;
            }
        }
        internal double GetAverage(List<int> numbers) 
        {
            return numbers.Average();
        }
        internal double GetArmonicMedia(List<int> numbers) 
        {
            var mediaArmonic = 0;
            for (int i = 1; i < numbers.Count(); i++)
            {
                
                mediaArmonic = mediaArmonic + 1/ numbers[i];
            }
            return numbers.Count() / mediaArmonic;
        }
        internal double GetMedian(List<int> numbers) 
        {
            int pos = numbers.Count() / 2;
            if (numbers.Count() % 2 == 0)
            {
                return (numbers[pos] + numbers[pos + 1]) / 2;
            }
            else
            {
                return numbers[pos];
            }

        }
        
    }
}
