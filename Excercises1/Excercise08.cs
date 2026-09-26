using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Fundamentals
{
    internal class Excercise08
    {
        public void exercise()
        {
            string[] inventoryData = new string[]
            {
                "ELEC:  TV-01:   4     ;          ELEC:  LAP-02:  10     ;   FURN:  CHAIR-9:  25",
                "CLOTH: SHIRT-M: 50    ;          ELEC: PHN-05:  8",
                "FURN:  DESK-01: 5     ;          CLOTH: PANTS-L: 30     ;   CLOTH: SOCK-S:  100"
                              
            };
            foreach (string batchItems in inventoryData)
            {
                string[] itemsBatch = batchItems.Split(';');

                foreach (string items in itemsBatch)
                {
                    string[] things = items.Split(':');

                    
                    string departmentCode = things[0];
                    string productCode = things[1];
                    int quantity = int.Parse(things[2]);

                    

                    string nonliving = things[0];
                    
           

                    
                    switch (nonliving)
                    {
                        case "ELEC":
                            Console.WriteLine($"Parsed: {productCode} (Electronics) - QTY = {quantity}");
                            
                            break;

                        case "CLOTH":
                            Console.WriteLine($"Parsed: {productCode} (Clothing) - QTY = {quantity}");
                            ;
                            break;

                        case "FURN":
                            Console.WriteLine($"Parsed: {productCode} (Furniture) - QTY = {quantity}");
                            
                            break;
                        default:
                            Console.WriteLine("Department not found");
                            break;
                    }

                    Console.WriteLine();
                }
                

            }
        }
    
        
    }
}
