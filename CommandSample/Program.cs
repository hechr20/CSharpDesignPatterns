// See https://aka.ms/new-console-template for more information
// The client code can parameterize an invoker with any commands.
using CommandSample.Models;

Invoker invoker = new Invoker();
invoker.SetOnStart(new SimpleCommand("Say Hi!"));
Receiver receiver = new Receiver();
invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

invoker.DoSomethingImportant();