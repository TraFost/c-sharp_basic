// here's the example of using the namespaces with/without.

// with namespaces
using NamespacesExample;

class NamespacesExamples
{
    public static void MyFunc()
    {
        Namespaces Test = new Namespaces();

        Test.LogMethod();
    }
}

// without namespaces
// class NamespacesExercise
// {
//     public static void MyFunc()
//     {
//         NamespacesExample.Namespaces Test = new NamespacesExample.Namespaces();
//         Test.LogMethod();
//     }
// }