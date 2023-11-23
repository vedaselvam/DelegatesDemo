// See https://aka.ms/new-console-template for more information
using DelegateLib;

Console.WriteLine("Hello, World!");

AppSecurity.RunUsingAppCredentials(delegate ()
{
    var ctMethod = System.Reflection.MethodBase.GetCurrentMethod();
    Console.WriteLine($"Output from {ctMethod.DeclaringType}.{ctMethod.Name}");
});
