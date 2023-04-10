using System;

namespace CSLightArithmeticsN3
{
    class Program
    {
        static void Main()
        {
            int a = 10;
            int b = 38;
            int c = (31 - 5 * a) / b;

            ///<summary>
            ///
            ///Последовательность действий
            ///сначала вычисляется умножение 5х10=50
            ///далее вычитание 31-50=-19
            ///далее проводится целочисленное деление без остатка -19/38=0
            ///в итоге получаем 0
            ///
            ///</summary>

            Console.WriteLine(c);
        }
    }
}
