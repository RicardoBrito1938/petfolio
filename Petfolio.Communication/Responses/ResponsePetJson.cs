using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Responses;

public class ResponsePetJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public PetType Type { get; set; }
    public DateTime BirthDate { get; set; }
    public string Breed { get; set; } = string.Empty;
}
