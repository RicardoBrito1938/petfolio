namespace Petfolio.Application.UseCases.Pet.Delete;

public class DeletePetUseCase
{
    public bool Execute(int id)
    {
        // In a real implementation, this would delete the pet from a repository
        // For demonstration purposes, return true if the ID exists in our mock data
        return id == 1 || id == 2; // Mocking successful deletion for known IDs
    }
}
