using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01;

public class HappyHello : IHello
{
    public void SayHello(string name)
    {
        Console.WriteLine($"Hello {name}! I'm Happy!");
    }
}
