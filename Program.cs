// new feature, top-level statements. No need for Main method

// if we give an alias to a namespace, we lost direct access to the classes in that namespace.
// so in order to access the classes in that namespace, we need to use the alias name. e.g. Profile.Function
using Profile =  basic.basic.Function;
using Methods.Static;
using Methods.Instance; // this is not using an alias, that way we can access the classes directly in below code.

// function call
string name = new Profile.Function().getName("John", "Doe");
Console.WriteLine(name + " is a software developer");

// static method call
int result = StaticMethod.Add(10, 20);
Console.WriteLine("Sum of 10 and 20 is " + result);

// instance method call
InstanceMethod mathMultiply = new InstanceMethod();
int multiplyResult = mathMultiply.Multiply(10, 20);
Console.WriteLine("Multiply of 10 and 20 is " + multiplyResult);