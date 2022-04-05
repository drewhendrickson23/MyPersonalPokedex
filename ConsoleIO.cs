using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using Pokedex.Core.Models;

namespace MyPersonalPokedex
{
    public class ConsoleIO
    {

        //public void playSimpleSound()
        //{
        //    SoundPlayer simpleSound = new(@"C:\Users\Drew Hendrickson\Downloads\animewow.wav");
        //    simpleSound.Play();
        //}

        public static string ReadString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }


        public static string ReadRequiredString(string prompt)
        {
            while(true)
            {
                string result = ReadString(prompt);
                if (!string.IsNullOrWhiteSpace(result))
                {
                    return result;
                }

                Console.WriteLine("REQUIRED");

            }
            
        }

        public static int ReadInt(string prompt)
        {
            int result;

            while(true)
            {
                if (int.TryParse(ReadRequiredString(prompt), out result))
                {
                    return result;
                }
                Console.WriteLine("Please enter a number");
            }
        }


        //these two methods could probably be condensed to one
        public static Pokemon PokemonNumber(string prompt)
        {
            
            while(true)
            {
                int result = ReadInt(prompt);

                if(result>0)
                {
                    Pokemon newPokemon = new Pokemon();
                    newPokemon.Id = result;
                    return newPokemon;
                }
                Console.WriteLine("Out of range");
            }
          
        
               
        }

        public static Pokemon PokemonInfo()
        {
            Pokemon addPokemon = PokemonNumber("Enter the number ID for the new Pokemon addition:");
            addPokemon.Name=ReadString("Please enter a name for the new Pokemon:");
            addPokemon.Type1 = ReadString("Please enter a type for the new pokemon:");
            addPokemon.Type2 = ReadString("Please enter a secondary type for the new pokemon (if applicable):");
            addPokemon.Description = ReadString("{Please enter a description for the new pokemon:");

            return addPokemon;
            
        }

        public static Pokemon editDetails(string s, Pokemon editPokemon)
        {
            int input;
            int[] choices = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("1: ID \n 2: Name \n 3: Type 1 \n 4: Type 2 \n 5: Description \n Enter your choice here:");
            do { input = int.Parse(Console.ReadLine()); }
            while (input >6 || input <1);

            if (input == 1)
            {
                Console.Clear();
                Console.WriteLine("Enter the new ID of the Pokemon:");
                int newId = int.Parse(Console.ReadLine());

                Console.WriteLine($"So, you would like to change the ID from {editPokemon.Id} to {newId}, correct?\n (Enter Y or N)");

                editPokemon.Id = newId;
                return editPokemon;
            }
            if (input == 2)
            {
                Console.WriteLine("Enter the new name of the Pokemon:");
                string newName = Console.ReadLine();

                Console.WriteLine($"So, you would like to change the name from {editPokemon.Name} to {newName}, correct?\n (Enter Y or N)");

                editPokemon.Name = newName;
                return editPokemon;
            }
            if (input == 3)
            {
                Console.WriteLine("Enter the new type-1 of the Pokemon:");
                string newType1 = Console.ReadLine();

                Console.WriteLine($"So, you would like to change the type-1 from {editPokemon.Type1} to {newType1}, correct?\n (Enter Y or N)");

                editPokemon.Type1 = newType1;
                return editPokemon;
            }
            if(input == 4)
            {
                Console.WriteLine("Enter the new type-2 of the Pokemon:");
                string newType2 = Console.ReadLine();

                Console.WriteLine($"So, you would like to change the type-2 from {editPokemon.Type2} to {newType2}, correct?\n (Enter Y or N)");

                editPokemon.Type2 = newType2;
                return editPokemon;
            }
            if(input == 5)
            {
                Console.WriteLine("Enter the new description of the Pokemon:");
                string newDescription = Console.ReadLine();

                Console.WriteLine($"So, you would like to change the name from '{editPokemon.Description}' to '{newDescription}', correct?\n (Enter Y or N)");

                editPokemon.Description = newDescription;
                return editPokemon;
            }

                return editPokemon;
         }

      public static int OptionChooser()
        {
            int value;
            Console.WriteLine("Please choose an option from below");
            Console.WriteLine("=====================================================\n");
            Console.WriteLine(" 1.Add a Pokemon\n 2.View all Pokemon \n 3.Choose specific pokemon\n 4.Edit a Pokemon \n 5.Delete a Pokemon\n 0.Exit");

            do Console.WriteLine("Enter choice here:");
            while (!int.TryParse(Console.ReadLine() , out value));

            return value;
            
        }
    }
}
