namespace RpgContentCreator.Library.Models
{
    public class Invalidation
    {
        public string Title { get; private set; } = "Houve uma ou mais invalidações";
        public IEnumerable<Notification> Notifications { get; private set; }

        public Invalidation( string title, IEnumerable<Notification> notifications )
        {
            Title = title;
            Notifications = notifications;
        }

        public Invalidation( IEnumerable<Notification> notifications )
        {
            Notifications = notifications;
        }

        public Invalidation( string title, Notification notification )
            : this( title, new List<Notification> { notification } ) { }

        public Invalidation( string title, string message )
            : this( title, new List<Notification> { new Notification { Message = message } } ) { }

        public Invalidation( string title, string code, string message )
            : this( title, new List<Notification> { new Notification { Code = code, Message = message } } ) { }

        public Invalidation( string title, string component, string code, string message )
            : this( title, new List<Notification> { new Notification { Component = component, Code = code, Message = message } } ) { }

        public Invalidation( string message )
            : this( new List<Notification> { new Notification { Message = message } } ) { }

        public override string ToString()
        {
            var value = string.Join( "<br>", Notifications.Select( n => n ) );
            return $"{Title}<br><br>{value}";
        }
    }
}