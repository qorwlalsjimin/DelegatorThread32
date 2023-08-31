using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatorThread32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //스레드 선언 
            Thread threadA = new Thread(ThesMethod); //기본 delegator
            Thread threadB = new Thread(delegate () { //무명 delegator
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("B");
                }
            });
            Thread threadC = new Thread(() => //람다
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("B");
                }
            });

            //스레드 실행 
            threadA.Start();
            threadB.Start();
            threadC.Start();
        }

        private static void ThesMethod()
        {
            for(int i = 0; i<1000; i++)
            {
                Console.Write("A");
            }
        }
    }
}
