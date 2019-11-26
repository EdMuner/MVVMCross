using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci.Core.Services
{

    public class FibonacciService : IFibonacciService
    {
        public int _primero = 0;
        public int _segundo = 1;
        public int _x;
        public int _sum;

        public string GetFibonacci(int n)
        {
            _primero = 0;
            _segundo = 1;
            _x = 0;
            _sum = 0;

            for (int i = 0; i < n; i++)
            {
                _x = _primero;
                _primero = _segundo;
                _segundo = _x + _primero;
                _sum = _segundo;

            }          
            return (""+ _x + ","+ _primero +","+ _segundo +"");

           
        }
    }
}
