using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IServiceServices
	{
		List<Services> GetAll();
		List<Services> GetStatusByTrue();
		List<Services> GetServicesById(int id);
		Services GetById(int id);
		void ServicesAdd(Services services);
		void ServicesDelete(Services services);
		void ServicesUpdate(Services services);
	}
}
