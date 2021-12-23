using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Admin : IEntity
	{
		[Key]
		public int AdminID { get; set; }
		[StringLength(50)]
		public String Username { get; set; }
		[StringLength(50)]
		public String Password { get; set; }
	}
}
