using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Slider : IEntity
	{
		[Key]
		public int SliderID { get; set; }
		[StringLength(100)]
		public String Image { get; set; }
		[StringLength(350)]
		public String Title { get; set; }
		[StringLength(250)]
		public String Desc { get; set; }
		[StringLength(30)]
		public String ButonWay { get; set; }
		[StringLength(30)]
		public String ButonTitle { get; set; }
		public bool Status { get; set; }
	}
}
