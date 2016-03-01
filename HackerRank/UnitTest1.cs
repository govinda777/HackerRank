using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace HackerRank
{
    [TestClass]
    public class HackerRankTest
    {
        [TestMethod]
        public void SimpleArraySumTest()
        {
            var array = new int[] { 1, 2, 3, 4, 10, 11 };
            var soma = array.Sum();

            Console.Write(soma);

            Assert.IsTrue(soma == 31);
        }

        [TestMethod]
        public void AVeryBigSumTest()
        {
            var array = new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005};
            long soma = array.Sum();

            Console.Write(soma);
            
            Assert.IsTrue(soma == 5000000015);
        }

        /// <summary>
        /// Teste 123
        /// </summary>
        [TestMethod]
        public void DiagonalDifferenceTest()
        {
            var colunaD1 = 0;
            var colunaD2 = 0;
            var array = new int[5][];
            var diferencaDiagonal = 0;
            var d1 = 0;
            var d2 = 0;
            var temp1 = 0;
            var temp2 = 0;
            int n = 5;

            array[0] = new int[] { 3 };
            array[1] = new int[] { 11, 2, 4 , 0};
            array[2] = new int[] {  4 ,5 ,6 , 0};
            array[3] = new int[] { 10 ,8 ,-12, 0};
            array[4] = new int[] { 0, 0, 0, 0 };

            n = n - 1;

            colunaD1 = n -1;

            for (int linha = n; linha <= array.Count() && linha > 0; linha--)
            {
                if (array[linha].Count() != n)
                {
                    continue;
                }

                temp1 = array[linha][colunaD1--];
                temp2 = array[linha][colunaD2++];

                d1 += temp1;
                d2 += temp2;
            }

            diferencaDiagonal = Math.Abs(d1 - d2);

            Console.Write(diferencaDiagonal);

            Assert.IsTrue(diferencaDiagonal == 15);
        }


        



    }
}
