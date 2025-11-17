// See https://aka.ms/new-console-template for more information
using SingletonSample.Models;

Console.WriteLine(
           "{0}\n{1}\n\n{2}\n",
           "If you see the same value, then singleton was reused (yay!)",
           "If you see different values, then 2 singletons were created (booo!!)",
           "RESULT:"
       );

Singleton singleton1 = Singleton.GetInstance();
Singleton singleton2 = Singleton.GetInstance();
if (singleton1 == singleton2)
{
    Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
    Console.WriteLine("Singleton failed, variables contain different instances.");
}

Thread process1 = new Thread(() =>
{
    CreateThreadSafeSingleton("FOO");
});

Thread process2 = new Thread(() =>
{
    CreateThreadSafeSingleton("BAR");
});

process1.Start();
process2.Start();

process1.Join();
process2.Join();
        
static void CreateThreadSafeSingleton(string value)
{
    ThreadSafeSingleton singleton = ThreadSafeSingleton.GetInstance(value); 
    Console.WriteLine(singleton.Value);
}