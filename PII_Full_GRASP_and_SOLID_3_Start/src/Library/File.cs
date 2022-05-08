using System;
using System.IO;

//RSP
namespace Full_GRASP_And_SOLID.Library
{
    public class FileClass : Iimprimir
    {
        public void Imprimir(Recipe recipe)
            {File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());}
    }
}