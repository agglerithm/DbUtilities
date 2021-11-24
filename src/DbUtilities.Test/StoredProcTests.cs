using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DbUtilities.Test
{
    [TestClass]
    public class StoredProcTests:BaseTest
    {
        private string _connectionString;
        private spPanel_GetDeviceConfiguration _sp;
        private IEnumerable<DeviceConfigurationResult> _recs;
        public const string StoredProcName = "spPanel_GetDeviceConfiguration";
        [TestMethod]
        public void CanGet()
        {
            Arrange();
            Act();
            DoAssert();
        }

        protected override void Arrange()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["siteConnectionDev"].ConnectionString;
            _sp = new spPanel_GetDeviceConfiguration(() => new SqlConnection(connectionString), WriteLine); 
        }

        protected override void Act()
        {
            _recs = _sp.FetchData(new DeviceConfigurationParameters()
                {locationId = Guid.Parse("AA125FFE-AC9F-4F99-9F62-00172B1022E1")});
        }

        protected override void DoAssert()
        {
            Assert.AreEqual(_recs.Count(), 1);
        }

        private void WriteLine(object obj)
        {
            Console.WriteLine(obj);
        }
    }

    public class DeviceConfigurationParameters
    {
        public Guid locationId { get; set; }
    }

    public class DeviceConfigurationResult
    {
        public String Name { get; set; }
        public String IMEI { get; set; }
        public String ESN { get; set; }
        public String IMEIOriginal { get; set; }
        public String DeviceType { get; set; }
        public String DeviceTypeDescription { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String PostalCode { get; set; }
        public String Country { get; set; }
        public String Address2 { get; set; }
        public Double Latitude { get; set; }
        public Double Longitude { get; set; }
        public String HydrantNumber { get; set; }
        public String FIDNumber { get; set; }
        public Boolean? UseZoneThreshold { get; set; }
        public String PressureZone { get; set; }
        public String Temperature { get; set; }
        public String Pressure { get; set; }
        public String TemperatureController { get; set; }
        public String Signal { get; set; }
        public String BatteryLevel { get; set; }
        public String LastTimeStamp { get; set; }
        public String Alert { get; set; }
        public String AlertBit { get; set; }
        public Double? TemperatureMaximum { get; set; }
        public Double? TemperatureMinimum { get; set; }
        public Double? PressureMaximum { get; set; }
        public Double? PressureMinimum { get; set; }
        public Double? LowBattery { get; set; }
        public Double? TransientPressure { get; set; }
        public Double? ShipmentPressure { get; set; }
        public Boolean? istestdevice { get; set; }
        public Int32? WakeUpTime { get; set; }
        public String WakeUpTimeUOT { get; set; }
        public Int32? UpTimeWait { get; set; }
        public String UpTimeWaitUOT { get; set; }
        public Int32? AlarmLogPressureInterval { get; set; }
        public String AlarmLogPressureIntervalUOT { get; set; }
        public Int32? AlarmLogTempMultiple { get; set; }
        public Int32? AlarmLogTimeout { get; set; }
        public String AlarmLogTimeOutUOT { get; set; }
        public Int32? SamplePressureInterval { get; set; }
        public String SamplePressureIntervalUOT { get; set; }
        public Int32? SampleTempMultiple { get; set; }
        public Int32? NonAlarmPressureMultiple { get; set; }
        public Int32? NonAlarmTempMultiple { get; set; }
        public String InfoRequest { get; set; }
        public Int32? FormatCode { get; set; }
        public Boolean? Upload { get; set; }
        public Boolean? SendThreshold { get; set; }
        public Boolean? SendIP { get; set; }
        public Boolean? SendShipment { get; set; }
        public Boolean? SendReset { get; set; }
        public Boolean? ReadGPS { get; set; }
        public Boolean? SendFirmwareUpgrade { get; set; }
        public Boolean? RestoreDefaultCalibration { get; set; }
        public Boolean? EnableTransientEvents { get; set; }
        public Boolean? EnableLED { get; set; }
        public String IPAddress1 { get; set; }
        public Int32? Port1 { get; set; }
        public String IPAddress2 { get; set; }
        public Int32? Port2 { get; set; }
        public String IPAddress3 { get; set; }
        public Int32? Port3 { get; set; }
        public Boolean? Alarm_LowBattery { get; set; }
        public Boolean? Alarm_PressureMax { get; set; }
        public Boolean? Alarm_PressureMin { get; set; }
        public Boolean? Alarm_TempMax { get; set; }
        public Boolean? Alarm_TempMin { get; set; }
        public String ConfigurationTemplate { get; set; }
        public String CommunicationServer { get; set; }
        public String FirmwareVersion { get; set; }
        public String SensorRange { get; set; }
        public Boolean? IsTestDevice { get; set; }
        public Guid? DeviceID { get; set; }
        public Guid LocationID { get; set; }
        public Guid? ThresholdID { get; set; }
        public Guid? DeviceAlertID { get; set; }
        public Guid DeviceConfigurationID { get; set; }
        public Guid? ConfigurationTemplateID { get; set; }
        public Guid? CommunicationServerID { get; set; }
        public Guid FirmwareID { get; set; }
        public Guid? SensorID { get; set; }
        public Guid? ClientID { get; set; }
        public String FWVersion { get; set; }
        public String ModemFWVersion { get; set; }
        public Boolean? UpdateModemFWVersion { get; set; }
        public Boolean? DeviceHasLatestModemFW { get; set; }
    }
}
