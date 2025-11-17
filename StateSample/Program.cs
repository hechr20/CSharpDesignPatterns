// See https://aka.ms/new-console-template for more information
// The client code.
using StateSample.Models;

var context = new Context(new ConcreteStateA());
context.Request1();
context.Request2();