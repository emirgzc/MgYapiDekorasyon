using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class About : IEntity
	{
		[Key]
		public int AboutId { get; set; }
		[StringLength(100)]
		public String MissionTitle { get; set; }
		public String MissionDesc { get; set; }
		[StringLength(100)]
		public String VisionTitle { get; set; }
		public String VisionDesc { get; set; }
	}
}
