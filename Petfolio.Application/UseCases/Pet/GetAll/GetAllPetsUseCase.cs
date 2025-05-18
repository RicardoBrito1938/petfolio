using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetAll;

public class GetAllPetsUseCase
{
    public ResponseAllPetsJson Execute()
    {
        return new ResponseAllPetsJson
        {
            Pets = new List<ResponseShortPetJson>
            {
                new ResponseShortPetJson
                {
                    Id = 1,
                    Name = "Bobby",
                    Type = Communication.Enums.PetType.Dog
                  
                },
                new ResponseShortPetJson
                {
                    Id = 2,
                    Name = "Mittens",
                    Type = Communication.Enums.PetType.Cat
                }
            }
        };
    }
}