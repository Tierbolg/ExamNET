using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamenNET
{

    public class ReImplement
    {
        private const char V = ',';

        /// <summary>
        /// Classic split method.       
        /// </summary>
        /// <param name="wordToCheck">String to check.</param>
        /// <returns>string[] split values</returns>
        public string[] Traditional(string inputFromUser, char separator)
        {
            return inputFromUser.Split(separator);
        }

        /// <summary>
        /// Re implement method, based in substrings, first check the separator in the string
        /// Then made the substring based in the position
        /// Finally, return the info in an array, exactly like the split method       
        /// </summary>
        /// <param name="wordToCheck">String to check.</param>
        /// <returns>string[] split values</returns>
        public void SplitReimplemented(string inputFromUser, char separator)
        {
            //Get the index of the separator
            var separatorIndex = inputFromUser.IndexOf(separator);
            List<int> arr4 = new List<int>();
            for (int e = 0; e < inputFromUser.Length; e++)
            {
                if (inputFromUser[e] == ',')
                {
                    arr4.Add(e);

                }
            }

            string inputFromUserWork = inputFromUser;
            for (int j = 0; j < arr4.Count+1; j++)
            {
                if (j == 0)
                {
                    IEnumerable<char> stringQuery2 = inputFromUserWork.TakeWhile(c => c != V);
                    Console.WriteLine("\nReimplement Split");
                    foreach (char c in stringQuery2)
                        //Console.Write("Separado:" + c);                        
                        Console.Write(c);

                    inputFromUserWork = inputFromUser.Remove(0, arr4[j] + 1);
                }
                else
                {
                    IEnumerable<char> stringQuery2 = inputFromUserWork.TakeWhile(c => c != V);
                    Console.WriteLine("\nReimplement Split");
                    foreach (char c in stringQuery2)
                        //Console.Write("Separado2:" + c);                        
                        Console.Write(c);
                    try
                    {
                         inputFromUserWork = inputFromUser.Remove(0, arr4[j]);
                        
                    }
                    catch (Exception e)
                    {
                        //Console.WriteLine("arr4[j]: " + arr4[j]);
                        //Console.Write(e.Message);
                    }

                }
                //Console.WriteLine("inputMocho:" + inputFromUserWork);

            }
            if (inputFromUserWork.Length > 1)
            {
                inputFromUserWork.Remove(0, 1);
                Console.WriteLine(inputFromUserWork);
            }
        }

    }

}