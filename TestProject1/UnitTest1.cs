using MyApplication;
using System;

namespace TestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void Test_Addera()
        {
            Assert.Equal(7, Program.Addera(2, 5));
        }

        [Fact]
        public void Test_Subtrahera()
        {
            Assert.Equal(1, Program.Subtrahera(6, 5));
        }

        [Fact]
        public void Test_Multiplicera()
        {
            Assert.Equal(25, Program.Multiplicera(5, 5));
        }

        [Fact]
        public void Test_Dividera()
        {
            Assert.Equal(4, Program.Dividera(8, 2));
        }

        [Fact]
        public void Test_Addera_Array()
        {
            int[] arr1 = {3};
            int[] arr2 = {5};
            Assert.Equal(8, Program.Addera(arr1, arr2));
        }

        [Fact]
        public void Test_Subtrahera_Array()
        {
            int[] arr1 = {10};
            int[] arr2 = {7};
            Assert.Equal(3, Program.Subtrahera(arr1, arr2));
        }

        [Fact]
        public void Test_Dividera_Exception()
        {
            //var exception = Assert.Throws<DivideByZeroException>(() => Program.Dividera(3, 0));
            Assert.Equal(-1, Program.Dividera(3, 0));
        }

    }
}