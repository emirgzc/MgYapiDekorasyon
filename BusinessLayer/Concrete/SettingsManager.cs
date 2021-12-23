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
	public class SettingsManager : ISettingsService
	{
		ISettingsDal _settingsDal;

		public SettingsManager(ISettingsDal settingsDal)
		{
			_settingsDal = settingsDal;
		}

		public List<Settings> GetAll()
		{
			return _settingsDal.GetAll();
		}

		public Settings GetById(int id)
		{
			return _settingsDal.Get(x=>x.SettingId==id);
		}

		public List<Settings> GetSettingsById(int id)
		{
			return _settingsDal.GetAll(x => x.SettingId == id);
		}

		public void SettingsUpdate(Settings settings)
		{
			_settingsDal.Update(settings);
		}
	}
}
