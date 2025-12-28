namespace RPGManager.Desktop.Test.Integration.Attributes;

[AttributeUsage( AttributeTargets.Class, AllowMultiple = true, Inherited = false )]
public class DependsOnAttribute : Attribute
{
    public Type Dependency { get; set; }

    public DependsOnAttribute( Type dependency )
    {
        Dependency = dependency;
    }
}