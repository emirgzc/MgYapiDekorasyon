using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ServiceManager : IServiceServices
	{
		IServicesDal _servicesDal;

		public ServiceManager(IServicesDal servicesDal)
		{
			_servicesDal = servicesDal;
		}

		public List<Services> GetAll()
		{
			return _servicesDal.GetAll();
		}

		public Services GetById(int id)
		{
			return _servicesDal.Get(x=>x.ServicesId==id);
		}

		public List<Services> GetServicesById(int id)
		{
			return _servicesDal.GetAll(x=>x.ServicesId==id);
		}

		public List<Services> GetStatusByTrue()
		{
			return _servicesDal.GetAll(x=>x.Status==true);
		}

		public void ServicesAdd(Services services)
		{
			_servicesDal.Add(services);
		}

		public void ServicesDelete(Services services)
		{
			_servicesDal.Delete(services);
		}

		public void ServicesUpdate(Services services)
		{
			_servicesDal.Update(services);
		}
	}
}
