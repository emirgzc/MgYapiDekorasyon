using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IProjectService
	{
		List<Project> GetAll();
		List<Project> GetStatusByTrue();
		List<Project> GetStatusByFalse();
		List<Project> GetProjectById(int id);
		Project GetById(int id);
		void ProjectAdd(Project project);
		void ProjectDelete(Project project);
		void ProjectUpdate(Project project);
	}
}
