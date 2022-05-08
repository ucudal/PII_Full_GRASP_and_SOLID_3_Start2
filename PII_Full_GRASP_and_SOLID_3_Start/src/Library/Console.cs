using System;
using System.IO;

//RSP
namespace Full_GRASP_And_SOLID.Library
{
    public class ConsoleClass : Iimprimir
    {
        public void Imprimir(Recipe recipe) 
            {Console.WriteLine(recipe.GetTextToPrint());}
    }
}