using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Settings : IEntity
	{
		[Key]
		public int SettingId { get; set; }
		[StringLength(20)]
		public String City { get; set; }
		[StringLength(20)]
		public String Country { get; set; }
		[StringLength(100)]
		public String Address { get; set; }
		[StringLength(15)]
		public String Phone { get; set; }
		[StringLength(100)]
		public String Email { get; set; }
		[StringLength(100)]
		public String Facebook { get; set; }
		[StringLength(100)]
		public String Instagram { get; set; }
		[StringLength(100)]
		public String Copyright { get; set; }
		[StringLength(1000)]
		public String Map { get; set; }
	}
}
