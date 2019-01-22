using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileWebCore.Models
{
	public class MailInsert
	{
		[Required]
		public string Email { get; set; }
		[Required]
		public string Message { get; set; }
		[Required]
		public string Name { get; set; }
	}
}
