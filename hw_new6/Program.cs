using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_new6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько людей в очереди перед вами: ");
            int peopleQueue = Convert.ToInt32(Console.ReadLine());

            int timeStepInMin = 13;
            int totalTimeInMin = peopleQueue * timeStepInMin;
            int hourToMin = 60;
            int timeInHours = totalTimeInMin / hourToMin;
            int timeInMin = totalTimeInMin % hourToMin;

            Console.WriteLine($"Время ожидания: {timeInHours} часов {timeInMin} минут.");
        }
    }
}