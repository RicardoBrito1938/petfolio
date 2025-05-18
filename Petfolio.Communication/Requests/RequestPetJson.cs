using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Requests;

public class RequestPetJson
{
    public string? Name { get; set; }
    public DateTime BirthDay { get; set; }
    public PetType Type { get; set; }
}