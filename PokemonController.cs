using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using Pokedex.Core.Models;
using Pokedex.BLL;
using Pokedex.Core.Repositories;
using Pokedex.Core.Items;
using Pokedex.Core.Entities;

namespace MyPersonalPokedex
{
    class PokemonController
    {

       
        private PokemonService _pokemonService;


        public PokemonController(PokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        
        

        public void Run()
        {

            ConsoleIO io = new ConsoleIO();

            Console.WriteLine("Welcome to MyPersonalPokedex!");
            Console.WriteLine("=============================\n");
            Console.WriteLine("Lets get started.");

            RunLoop();

        }



        private void RunLoop()
        {
           
            bool running = true;
            {
                while (running)
                {
                    int value = ConsoleIO.OptionChooser();
                   
                    switch (value)
                    {
                        case 1:
                            AddPokemon();
                            break;
                        case 2:
                            ViewAll();
                            
                            break;
                        case 3:
                            ChooseOne();

                            break;
                        case 4:
                            EditPokemon();
                        
                            break;
                        case 5:
                            DeletePokemon();
                            break;
                        case 0:
                          
                            Console.WriteLine("Exiting....");
                            Console.ReadLine();
                            System.Environment.Exit(0);
                            break;
                    }
                }
            }
        }


        //adds new pokemon
        //it should: prompt user for new pokemon info -> check to make sure number isnt duplicate-> success message + sound
        //first prompt the number for the pokemon *check*
        //then prompt the rest of the info
        //maybe at some point check for duplicates?

        List<Pokemon> allPokemon = new List<Pokemon>();
  

        private void AddPokemon()
        {
           
            Pokemon addPokemon= ConsoleIO.PokemonInfo();

            //if(addPokemon != null)
            //allPokemon.Add(addPokemon);

            var result = _pokemonService.AddPokemon(addPokemon);
            
            if(result.Success != true)
            {
                ConsoleIO.ReadString($"Could not add pokemon\nMessage:{result.Message}");
            }
            Console.WriteLine("Pokemon successfully added!");
        }

        private void ViewAll()
        {
            var listPokemon = _pokemonService.ViewAll();
           foreach(Pokemon p in listPokemon)
            {
                Console.WriteLine(p.Name);
            }
        }

        private void ChooseOne()
        {
            Pokemon foundPokemon = ConsoleIO.PokemonNumber("Enter the Id of the pokemon you'd like information on:");

            var chosenPokemon = _pokemonService.ChooseOne(foundPokemon.Id);

            if (chosenPokemon == null)
            {
                Console.WriteLine("No matching pokemon with this ID");

            }
            else
            {
                Console.WriteLine($"Pokemon Id: {chosenPokemon.Data.Id}");
                Console.WriteLine($"Pokemon Name:{chosenPokemon.Data.Name}");
                Console.WriteLine($"Pokemon Type 1:{chosenPokemon.Data.Type1}");
                if (chosenPokemon.Data.Type2 != null)
                {
                    Console.WriteLine($"Pokemon Type 2: {chosenPokemon.Data.Type2}");
                }
                Console.WriteLine(($"Pokemon Description: {chosenPokemon.Data.Description}"));
            }

        }

        private void EditPokemon()
        {
            Pokemon foundPokemon = ConsoleIO.PokemonNumber("Enter the Id of the pokemon you'd like to edit:");

            var pokemonToEdit = _pokemonService.ChooseOne(foundPokemon.Id);
            if (pokemonToEdit.Data != null)
            {
                ConsoleIO.editDetails($"Which attribute would you like to edit for [{pokemonToEdit.Data.Name}", pokemonToEdit.Data);
                _pokemonService.EditPokemon(pokemonToEdit.Data);
            }
            else
            {
                Console.WriteLine(pokemonToEdit.Message);
            }
        }

        private void DeletePokemon()
        {
            Pokemon foundPokemon = ConsoleIO.PokemonNumber("Enter the Id of the pokemon you'd like to delete:");

            Response pokemonToDelete = _pokemonService.ChooseOne(foundPokemon.Id);

            _pokemonService.DeletePokemon(pokemonToDelete.Data.Id);
        }


    //END Class
    }
}

