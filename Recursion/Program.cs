using System;

namespace Recursion
{
    
    
        class Program
        {
            static void Rec(int i)
            {
                Console.WriteLine(i);
            if (i >= 10)
            {
                return;
            }else if(i==4)
            {
                i++;
                Rec(i + 1);
                Console.WriteLine(i+1);
                return;
            }
                
                i++;
                Rec(i);
            Console.WriteLine(i);
                return;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Recursion is in process");
                Rec(0);
            }
        }
    }
