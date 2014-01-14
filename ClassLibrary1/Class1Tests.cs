using System;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using WpfApplication4;

namespace ClassLibrary1
{
    public class Class1Tests
    {
        [Test]
        public async void Test1()
        {
            var sut = new Class1();
            await sut.DoStuff();
            await sut.DoStuff();
            await sut.DoStuff();

            throw new InvalidOperationException();
        }

        [Test]
        public async void Test2()
        {
            Thread.Sleep(500);
            var sut = new Class1();
            await sut.DoStuff();
            await sut.DoStuff();
            await sut.DoStuff();
        }

        [Test]
        public async Task Test3()
        {
            var sut = new Class1();
            await sut.DoStuff();
        }
    }
}
