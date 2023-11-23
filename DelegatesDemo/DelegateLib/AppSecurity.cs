using System.Reflection.Metadata.Ecma335;

namespace DelegateLib
{
    public static class AppSecurity
    {
        public static void RunUsingAppCredentials(Delegate d)
        {
            d.DynamicInvoke();
            var ctMethod = System.Reflection.MethodBase.GetCurrentMethod();
            Console.WriteLine($"Output from {ctMethod.DeclaringType}.{ctMethod.Name}");
        }
    }
}