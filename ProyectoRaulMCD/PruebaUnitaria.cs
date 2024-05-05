using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRaulMCD
{
    public class PruebaUnitaria
    {
        public static int CalcularMCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        
        public static int CalcularCuatroNumMCD(int n1, int n2, int n3, int n4)
        {
            int mcdN1N2 = CalcularMCD(n1, n2);
            int mcdN3N4 = CalcularMCD(n3, n4);
            int mcd = CalcularMCD(mcdN1N2, mcdN3N4);
            return mcd;
        }
    }
}
