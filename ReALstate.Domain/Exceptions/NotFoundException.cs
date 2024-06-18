namespace ReALstate.Domain.Exceptions
{
    // The NotFoundException class is responsible for defining the exception that is thrown when a resource is not found.
    public class NotFoundException(string type, string identifier) : Exception($"Resource: [{type}] with id: {identifier} was not found!")
    {
    }
}
