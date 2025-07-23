using Managers;
using Managers;
using Models;
using PA.Manager;

using static System.Runtime.InteropServices.JavaScript.JSType;




namespace PA.ConsoleApp.Factory
{
    public static class FactoryGenerator
    {
        public static IManager Generate(string pgName)
        {
            switch (pgName.ToLower())
            {
                case "OddNumbers":
                    Number model = new Number();
                    model.SetNum(n);
                    NumberManager manager = new NumberManager();
                    NumberResultModel result = manager.odd(model);
                    break;


            }
            return new Manager(result);
        }
    }
}
