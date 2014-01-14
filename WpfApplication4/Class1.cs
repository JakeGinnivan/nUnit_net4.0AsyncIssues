using System.Threading;
using System.Threading.Tasks;

namespace WpfApplication4
{
    public class Class1
    {
        public Task DoStuff()
        {
            return TaskEx.Run(() =>
            {
                Thread.Sleep(100);
            });
        } 
    }
}