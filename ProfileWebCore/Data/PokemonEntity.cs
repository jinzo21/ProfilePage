using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileWebCore.Data
{
	public class PokemonEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Required]
		[MaxLength(32)]
		public string PokemonId { get; set; }
		[Required]
		[MaxLength(128)]
		public string PokemonName { get; set; }
		[Required]
		[MaxLength(1000)]
		public string PokemonDescription { get; set; }
		[Required]
		[MaxLength(64)]
		public string PokemonHeight { get; set; }
		[Required]
		[MaxLength(64)]
		public string PokemonWeight { get; set; }
		[Required]
		[MaxLength(64)]
		public string PokemonType { get; set; }
		[Required]
		[MaxLength(360)]
		public string PokemonImage { get; set; }
		[Required]
		[MaxLength(360)]
		public string PokemonImageSFront { get; set; }
		[Required]
		[MaxLength(360)]
		public string PokemonImageSBack { get; set; }
		[Required]
		[MaxLength(64)]
		public string StatHp { get; set; }
		[Required]
		[MaxLength(64)]
		public string StatAttack { get; set; }
		[Required]
		[MaxLength(64)]
		public string StatDefense { get; set; }
		[Required]
		[MaxLength(64)]
		public string StatSpAttack { get; set; }
		[Required]
		[MaxLength(64)]
		public string StatSpDefense { get; set; }
		[Required]
		[MaxLength(64)]
		public string StatSpeed { get; set; }
		[Required]
		[MaxLength(64)]
		public string StatTotal { get; set; }
		[Required]
		[Column(TypeName = "DATETIME2(7) DEFAULT (GETUTCDATE())")]
		public DateTime DateCreated { get; set; }
		[Required]
		[Column(TypeName = "DATETIME2(7) DEFAULT (GETUTCDATE())")]
		public DateTime DateUpdated { get; set; }
	}
}
