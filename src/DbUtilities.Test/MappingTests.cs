using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using DbUtilities.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DbUtilities.Test
{
    [TestClass]
    public class MappingTests:BaseTest
    {
        private spPanel_GetDeviceConfiguration _sp;
        private DeviceConfigurationResult _spResult;
        private Device _complexObj;

        [TestMethod]
        public void CanMap()
        {
            Arrange();
            Act();
            DoAssert();
        }

        protected override void Arrange()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["siteConnectionDev"].ConnectionString;
            _sp = new spPanel_GetDeviceConfiguration(() => new SqlConnection(connectionString), null);
            _spResult = _sp.FetchData(new DeviceConfigurationParameters()
                { locationId = Guid.Parse("AA125FFE-AC9F-4F99-9F62-00172B1022E1") }).First();
        }

        protected override void Act()
        {
            _complexObj =(Device)_spResult.ConvertFlatObject(typeof(Device));
        }

        protected override void DoAssert()
        {
            Assert.IsNotNull(_complexObj);
        }
    }
}
