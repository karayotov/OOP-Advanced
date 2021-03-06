﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P08_PetClinics
{
    public class PetClinic
    {

        private Pet[] pets;

        public PetClinic(string name, int roomCount)
        {
            this.Name = name;
            this.ValidateRoomCount(roomCount);
            this.pets = new Pet[roomCount];
        }

        public string Name { get; set; }

        public int Center => this.pets.Length / 2;

        public bool HasEmptyRooms => this.pets.Any(p => p == null);


        private void ValidateRoomCount(int roomCount)
        {
            if (roomCount % 2 == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }


        public bool Add(Pet pet)
        {
            int currentRoom = this.Center;

            for (int i = 0; i < this.pets.Length; i++)
            {
                if (i % 2 != 0)
                {
                    currentRoom -= i;
                }
                else
                {
                    currentRoom += i;
                }

                if (this.pets[currentRoom] == null)
                {
                    this.pets[currentRoom] = pet;
                    return true;
                }
            }

            return false;
        }

        public bool Release()
        {
            for (int i = 0; i < this.pets.Length; i++)
            {
                int index = (this.Center + i) % this.pets.Length;

                if (this.pets[index] != null)
                {
                    this.pets[index] = null;

                    return true;
                }
            }

            return false;
        }

        public string Print(int roomnumber)
        {
            return this.pets[roomnumber - 1]?.ToString() ?? "Room empty";
        }

        public string PrintAll()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i <= this.pets.Length; i++)
            {
                stringBuilder.AppendLine(this.Print(i));
            }

            string result = stringBuilder.ToString().TrimEnd();

            return result;
        }
    }
}
