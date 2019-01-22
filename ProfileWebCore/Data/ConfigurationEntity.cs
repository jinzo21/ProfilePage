using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileWebCore.Data
{
	public class ConfigurationEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Required]
		[Column(TypeName = "NVARCHAR(32)")]
		public string AccessKey { get; set; }
		[Required]
		[Column(TypeName = "NVARCHAR(128)")]
		public string AccessValue { get; set; }
		[Column(TypeName = "DATETIME2(7) DEFAULT (GETUTCDATE())")]
		public DateTime Created { get; set; }
		[Required]
		[Column(TypeName = "DATETIME2(7) DEFAULT (GETUTCDATE())")]
		public DateTime Updated { get; set; }
	}
}
