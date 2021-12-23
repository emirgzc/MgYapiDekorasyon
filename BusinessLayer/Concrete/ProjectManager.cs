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
	public class ProjectManager : IProjectService
	{
		IProjectDal _projectDal;

		public ProjectManager(IProjectDal projectDal)
		{
			_projectDal = projectDal;
		}

		public List<Project> GetAll()
		{
			return _projectDal.GetAll();
		}

		public Project GetById(int id)
		{
			return _projectDal.Get(x=>x.ProjectID==id);
		}

		public List<Project> GetProjectById(int id)
		{
			return _projectDal.GetAll(x=>x.ProjectID==id);
		}

		public List<Project> GetStatusByFalse()
		{
			return _projectDal.GetAll(x=>x.Status==false);
		}

		public List<Project> GetStatusByTrue()
		{
			return _projectDal.GetAll(x => x.Status == true);
		}

		public void ProjectAdd(Project project)
		{
			_projectDal.Add(project);
		}

		public void ProjectDelete(Project project)
		{
			_projectDal.Delete(project);
		}

		public void ProjectUpdate(Project project)
		{
			_projectDal.Update(project);
		}
	}
}
