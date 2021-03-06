﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_PetClinics
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Pet> pets = new List<Pet>();

            List<PetClinic> clinics = new List<PetClinic>();

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                string[] commandInput = Console.ReadLine().Split();
                string command = commandInput[0];

                switch (command)
                {
                    case "Create":
                        try
                        {
                            string typeOfCreation = commandInput[1];

                            if (typeOfCreation == "Pet")
                            {
                                int age = int.Parse(commandInput[3]);
                                Pet pet = new Pet(commandInput[2], age, commandInput[4]);
                                pets.Add(pet);
                            }
                            else
                            {
                                int roomCount = int.Parse(commandInput[3]);

                                PetClinic clinic = new PetClinic(commandInput[2], roomCount);

                                clinics.Add(clinic);
                            }
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case "Add":

                        Pet petToAdd = pets.FirstOrDefault(p => p.Name == commandInput[1]);

                        PetClinic clinicToAdd = clinics.FirstOrDefault(p => p.Name == commandInput[2]);

                        Console.WriteLine(clinicToAdd.Add(petToAdd));
                        break;

                    case "Release":
                        PetClinic clinicToRelease = clinics.FirstOrDefault(p => p.Name == commandInput[1]);
                        Console.WriteLine(clinicToRelease.Release());
                        break;

                    case "HasEmptyRooms":

                        PetClinic clinicToCheck = clinics.FirstOrDefault(p => p.Name == commandInput[1]);
                        Console.WriteLine(clinicToCheck.HasEmptyRooms);
                        break;

                    case "Print":
                        PetClinic clinicToPrint = clinics.FirstOrDefault(p => p.Name == commandInput[1]);
                        if (commandInput.Length == 3)
                        {
                            int roomNumber = int.Parse(commandInput[2]);
                            Console.WriteLine(clinicToPrint.Print(roomNumber));
                        }
                        else
                        {
                            Console.WriteLine(clinicToPrint.PrintAll());
                        }
                        break;

                    default:
                        break;
                }

            }
        }
    }
}
