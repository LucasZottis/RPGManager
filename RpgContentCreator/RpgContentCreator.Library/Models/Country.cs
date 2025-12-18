//using Microsoft.EntityFrameworkCore;
//using RpgContentCreator.Library.Enums;
//using RpgContentCreator.Library.Interfaces;
//using SysPret.Core.Library.Attributes;
//using System.ComponentModel.DataAnnotations;

//namespace RpgContentCreator.Library.Models;

//[PrimaryKey( nameof( Guid ) )]
//public class Country : Entity, IIdentifiableEntity
//{
//    [HasColumn( nameof( Id ), "int" )]
//    public int Id { get; set; }

//    [HasColumn(nameof(Name), ColumnType.ShortText)]
//    [MaxLength(60)]
//    [Required]
//    public string Name { get; set; }

//    [HasColumn( nameof( Alpha3Code ), ColumnType.ShortText )]
//    [MaxLength( 3 )]
//    public string Alpha3Code { get; set; }

//    [HasColumn(nameof(Alpha2Code), ColumnType.ShortText)]
//    [MaxLength(2)]
//    public string Alpha2Code { get; set; }
//}