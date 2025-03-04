using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public void consolePrinter(Recipe steps)
        {
                    Console.WriteLine($"Receta de {steps.FinalProduct.Description}:");
            foreach (Step step in steps.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}