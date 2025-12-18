using RpgContentCreator.Library.Models;
using System.Runtime.Serialization;

namespace RpgContentCreator.Library.Exceptions;

public class BadRequestException : Exception
{
    public Invalidation Invalidation { get; private set; }

    public BadRequestException() { }

    public BadRequestException( IEnumerable<Notification> errors )
    {
        Invalidation = new Invalidation( errors );
    }

    public BadRequestException( string? message )
        : base( message )
    {
        Invalidation = new Invalidation( message );
    }
}