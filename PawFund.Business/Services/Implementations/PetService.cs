﻿using PawFund.Data.Models;
using PawFund.Business.Services.Interfaces;

using PawFund.Data.Repositories.Interfaces;

namespace PawFund.Business.Services.Implementations
{
    public class PetService : IPetService
    {
        private readonly IPetRepository petRepository;

        public PetService(IPetRepository petRepository)
        {
            this.petRepository = petRepository;
        }

        public async Task AddPetAsync(Pet pet)
        {
            await petRepository.AddPetAsync(pet);
        }

        public async Task DeletePetAsync(int id)
        {
            await petRepository.DeletePetAsync(id);
        }

        public async Task<IEnumerable<Pet>> GetAllPetsAsync()
        {
            return await petRepository.GetAllPetsAsync();
        }

        public async Task<Pet> GetPetByIdAsync(int id)
        {
            return await petRepository.GetPetByIdAsync(id);
        }

        public async Task<IEnumerable<Pet>> SearchPetsAsync(string searchTerm)
        {
            return await petRepository.SearchPetsAsync(searchTerm);
        }

        public async Task UpdatePetAsync(Pet pet)
        {
            await petRepository.UpdatePetAsync(pet);
        }
    }
}
