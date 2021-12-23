using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Contact : IEntity
	{
		[Key]
		public int ConID { get; set; }
		[StringLength(100)]
		public String Name { get; set; }
		[StringLength(100)]
		public String Surname { get; set; }
		[StringLength(100)]
		public String Email { get; set; }
		[StringLength(100)]
		public String Subject { get; set; }
		[StringLength(1000)]
		public String Message { get; set; }
		public DateTime DateMes { get; set; }
		public bool Status { get; set; }
	}
}
