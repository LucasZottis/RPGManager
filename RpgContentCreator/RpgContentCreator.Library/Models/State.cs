//using Microsoft.EntityFrameworkCore;
//using RpgContentCreator.Library.Enums;
//using RpgContentCreator.Library.Interfaces;
//using SysPret.Core.Library.Attributes;
//using System.ComponentModel.DataAnnotations;

//namespace RpgContentCreator.Library.Models;

//[PrimaryKey( nameof( Guid ) )]
//public class State : Entity, IIdentifiableEntity
//{
//    [HasColumn( nameof( Id ), "int" )]
//    public int Id { get; set; }

//    [HasColumn( nameof( Name ), ColumnType.ShortText )]
//    [MaxLength( 100 )]
//    public string Name { get; set; }

//    [HasColumn( nameof( FederativeUnit ), ColumnType.ShortText )]
//    [MaxLength( 2 )]
//    public string FederativeUnit { get; set; }

//    protected State() { }

//    public State( Guid guid, byte id, string nome, string federativeUnit )
//    {
//        Guid = guid;
//        Id = id;
//        Name = nome;
//        FederativeUnit = federativeUnit;
//    }

//    public State( byte id, string nome, string federativeUnit )
//        : this( Guid.NewGuid(), id, nome, federativeUnit ) { }

//    public State( string stateName, string federativeUnit )
//        : this( Guid.NewGuid(), 0, stateName, federativeUnit ) { }

//    public State( string federativeUnit ) : this( string.Empty, federativeUnit ) { }
//}