using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson? Execute(int id)
    {
        // In a real implementation, this would retrieve the pet from a repository
        // For demonstration purposes, return mock data based on ID
        if (id == 1)
        {
            return new ResponsePetJson
            {
                Id = 1,
                Name = "Bobby",
                Type = PetType.Dog,
                BirthDate = new DateTime(2020, 3, 15),
                Breed = "Golden Retriever"
            };
        }
        else if (id == 2)
        {
            return new ResponsePetJson
            {
                Id = 2,
                Name = "Mittens",
                Type = PetType.Cat,
                BirthDate = new DateTime(2021, 5, 8),
                Breed = "Siamese"
            };
        }
        
        return null;
    }
}
