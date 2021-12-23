using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ISettingsService
	{
		List<Settings> GetAll();
		List<Settings> GetSettingsById(int id);
		Settings GetById(int id);
		void SettingsUpdate(Settings settings);
	}
}
