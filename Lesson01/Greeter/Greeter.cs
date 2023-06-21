
namespace Lesson01.Greeter;

public class Greeter
{
    readonly IHello _hello;

    public Greeter(IHello hello)
    {
        _hello = hello;
    }

    public void Greet()
    {
        _hello.SayHello("ameer");
    }
}
