using System;
using System.Collections.Generic;

namespace DbUtilities.Test
{
    public partial class DeviceConfiguration
    {

        public string CompleteAddress { get; set; }
        public string WakeUpTimeMax { get; set; }
        public string WakeUpTimeMin { get; set; }

        public bool IsUpload { get; set; }
        public bool IsSendIP { get; set; }
        public bool IsSendThreshold { get; set; }
        public bool IsSendShipment { get; set; }
        public bool IsSendReset { get; set; }
        public bool IsReadGPS { get; set; }
        public bool IsRestoreDefaultCalibration { get; set; }
        public bool IsUpdateModemFWVersion { get; set; }
        public bool DeviceHasLatestModemFW { get; set; }

        public string IPAddress1 { get; set; }
        public int Port1 { get; set; }
        public string IPAddress2 { get; set; }
        public int Port2 { get; set; }
        public string IPAddress3 { get; set; }
        public int Port3 { get; set; }
        public bool IsTestingDevice { get; set; }


    }
    public partial class DeviceRead
    {
        public System.Guid ID { get; set; }
        public string IPAddress1 { get; set; }
        public string IPAddress2 { get; set; }
        public string IPAddress3 { get; set; }
        public Nullable<int> Port1 { get; set; }
        public Nullable<int> Port2 { get; set; }
        public Nullable<int> Port3 { get; set; }
        public Nullable<double> LowBatteryThreshold { get; set; }
        public Nullable<double> TransientThreshold { get; set; }
        public Nullable<double> PressureMaximumThreshold { get; set; }
        public Nullable<double> PressureMinimumThreshold { get; set; }
        public Nullable<double> TemperatureMaximumThreshold { get; set; }
        public Nullable<double> TemperatureMinimumThreshold { get; set; }
        public Nullable<System.DateTime> UTC { get; set; }
        public Nullable<double> Longitude { get; set; }
        public Nullable<double> Latitude { get; set; }
        public string NS { get; set; }
        public string EW { get; set; }
        public string QualityIndicator { get; set; }
        public string SatellitiesUsed { get; set; }
        public Nullable<double> HDOP { get; set; }
        public Nullable<double> MSLAltitude { get; set; }
        public string MSLAltitudeUOM { get; set; }
        public Nullable<double> GEOIDSeparation { get; set; }
        public string GEOIDSeparationUnit { get; set; }
        public string DGPS { get; set; }
        public Nullable<System.DateTime> LastRead { get; set; }
        public System.Guid DeviceID { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string FWVersion { get; set; }
        public string ModemFWVersion { get; set; }

        public virtual Device Device { get; set; }
    }
    public partial class DeviceNote
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> DeviceID { get; set; }
        public string Note { get; set; }
        public byte[] Picture { get; set; }
        public byte[] ThumbNail { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        public virtual Device Device { get; set; }
    }
    public partial class DeviceConfigurationFast
    {
        public System.Guid ID { get; set; }
        public System.Guid DeviceID { get; set; }
        public string OpCode { get; set; }
        public string FormatCode { get; set; }
        public Nullable<bool> SystemSettingsChanged { get; set; }
        public Nullable<int> SystemControlLength { get; set; }
        public string SystemFlag { get; set; }
        public Nullable<byte> SystemMidnightResetOffset { get; set; }
        public Nullable<byte> SystemInitSessionCount { get; set; }
        public Nullable<byte> SystemInitSessionInterval { get; set; }
        public Nullable<byte> SystemInitSessionLogInterval { get; set; }
        public Nullable<byte> SystemBlueToothWindow { get; set; }
        public string SystemAdcChannelPriRef { get; set; }
        public string SystemAdcChannelPri { get; set; }
        public string SystemAdcChannelSecRef { get; set; }
        public string SystemAdcChannelSec { get; set; }
        public string SystemAdcChannelBattery { get; set; }
        public string SystemAdcChannelGenRef { get; set; }
        public string SystemAdcChannelGen { get; set; }
        public Nullable<bool> SensorSettingsChanged { get; set; }
        public Nullable<int> SensorControlLength { get; set; }
        public string SensorFlags { get; set; }
        public Nullable<int> SensorAlertLimitExcur { get; set; }
        public Nullable<int> SensorAlertLimitTrans { get; set; }
        public Nullable<int> SensorCaptLimitExcur { get; set; }
        public Nullable<int> SensorCaptLimitTrans { get; set; }
        public Nullable<int> SensorLockoutLength { get; set; }
        public Nullable<int> SensorPsp { get; set; }
        public Nullable<int> SensorPnspm { get; set; }
        public Nullable<int> SensorPlpm { get; set; }
        public Nullable<int> SensorSspm { get; set; }
        public Nullable<int> SensorSnspm { get; set; }
        public Nullable<int> SensorSlpm { get; set; }
        public Nullable<bool> PrimarySettingsChanged { get; set; }
        public Nullable<int> PrimaryControlLength { get; set; }
        public string PrimaryFlags { get; set; }
        public string PrimaryUpperThreashold { get; set; }
        public string PrimaryLowerThreashold { get; set; }
        public string PrimaryExcursionWin { get; set; }
        public string PrimaryClearWindow { get; set; }
        public string PrimaryTransientMagn { get; set; }
        public string PrimaryTransientWindow { get; set; }
        public Nullable<int> PrimaryPrecaptLength { get; set; }
        public Nullable<int> PrimaryPostcaptLength { get; set; }
        public Nullable<int> PrimaryLoggingOffset { get; set; }
        public Nullable<bool> SecondarySettingsChanged { get; set; }
        public Nullable<int> SecondaryControlLength { get; set; }
        public string SecondaryFlags { get; set; }
        public string SecondaryUpperThreashold { get; set; }
        public string SecondaryLowerThreashold { get; set; }
        public string SecondaryExcursionWin { get; set; }
        public string SecondaryClearWindow { get; set; }
        public string SecondaryTransientMagn { get; set; }
        public string SecondaryTransientWindow { get; set; }
        public Nullable<int> SecondaryPrecaptLength { get; set; }
        public Nullable<int> SecondaryPostcaptLength { get; set; }
        public Nullable<int> SecondaryLoggingOffset { get; set; }
        public Nullable<bool> CommSettingsChanged { get; set; }
        public Nullable<int> CommControlLength { get; set; }
        public Nullable<int> CommUploadPeriod { get; set; }
        public Nullable<int> CommUploadOffset { get; set; }
        public string CommServerPortPri { get; set; }
        public string CommServerUrlPri { get; set; }
        public string CommServerPortSec { get; set; }
        public string CommServerUrlSec { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        public virtual Device Device { get; set; }
    }
    public class Device
    {
        public Device()
        {
            this.CommunicationServerDetails = new HashSet<CommunicationServerDetail>();
            this.DeviceConfigurations = new HashSet<DeviceConfiguration>();
            this.DeviceReads = new HashSet<DeviceRead>();
            this.LocationDeviceHistories = new HashSet<LocationDeviceHistory>();
            this.Readings = new HashSet<Reading>();
            this.DeviceNotes = new HashSet<DeviceNote>();
            this.DeviceConfigurationFasts = new HashSet<DeviceConfigurationFast>();
        }
        public bool IsDeviceActive { get; set; }
        public string DeviceVersion { get; set; }

        public string DeviceTypeDescription { get; set; }
        public string SelectedDeviceType { get; set; }

        public string DeviceConfigurationTemplate { get; set; }
        public string SelectedDeviceConfigurationTemplate { get; set; }

        public string CommunicationServerName { get; set; }
        public string SelectedCommunicationServer { get; set; }

        public string PressureZone { get; set; }
        public string SelectedPressureZone { get; set; }
        public bool UseZoneThresholdValues { get; set; }
        public string FirmwareVersion { get; set; }
        public string SelectedFirmwareVersion { get; set; }
        public string SensorRange { get; set; }
        public string SelectedSensorRange { get; set; }



        public string AlarmEnable { get; set; }
        public string AlarmEnableFS { get; set; }
        public bool PressureMaxAlarm { get; set; }
        public bool PressureMinAlarm { get; set; }
        public bool TemperatureMaxAlarm { get; set; }
        public bool TemperatureMinAlarm { get; set; }
        public bool BatteryAlarm { get; set; }

        public bool IsTransientEnabled { get; set; }
        public bool IsLEDsEnabled { get; set; }
        public bool IsSendShipment { get; set; }
        public bool IsSendReset { get; set; }
        public bool IsReadGPS { get; set; }
        public bool IsFirmwareModified { get; set; }
        public bool IsRestoreDefaultCalibration { get; set; }
        public bool IsUpdateModemFWVersion { get; set; }
        public bool IsFOTAUpdate { get; set; }
        public bool DeviceHasLatestModemFW { get; set; }
        public string ThresholdID { get; set; }

        public string CurrentIMEI { get; set; }

        public bool IsTestDevice { get; set; }

        //public Guid? firmwareId { get; set; }
        public string BuryDepthOther { get; set; }
        public string txtNotes { get; set; }
        public bool IsAlarmChanged { get; set; }
        public bool IsThresholdChanged { get; set; }

        public bool IsConfigurationTemplateChanged { get; set; }
        public System.Guid ID { get; set; }
        public string IMEI { get; set; }
        public string ESN { get; set; }
        public string Name { get; set; }
        public string Frequency { get; set; }
        public Nullable<int> BatteryCounter { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> UseZoneThreshold { get; set; }
        public Nullable<System.DateTime> ImportDate { get; set; }
        public Nullable<System.Guid> ConfigurationTemplateID { get; set; }
        public Nullable<System.Guid> CommunicationServerID { get; set; }
        public System.Guid ClientID { get; set; }
        public Nullable<System.Guid> LocationID { get; set; }
        public System.Guid DeviceTypeID { get; set; }
        public Nullable<System.Guid> DeviceAlertID { get; set; }
        public Nullable<System.Guid> FirmwareID { get; set; }
        public Nullable<System.Guid> SensorID { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string IMEIOriginal { get; set; }
        public string RFID { get; set; }
        public Nullable<double> BatteryLevel { get; set; }
        public Nullable<System.Guid> ModelId { get; set; }
        public Nullable<System.Guid> ManufacturingClientId { get; set; }
        public string BuryDepth { get; set; }
        public Nullable<bool> IsFastSampling { get; set; }

        public virtual Client Client { get; set; }
        public virtual CommunicationServer CommunicationServer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommunicationServerDetail> CommunicationServerDetails { get; set; }

        public virtual ConfigurationTemplate ConfigurationTemplate { get; set; }
        public virtual DeviceAlert DeviceAlert { get; set; }
        /*public virtual DeviceSensor DeviceSensor { get; set; }
        public virtual DeviceType DeviceType { get; set; }
        public virtual Firmware Firmware { get; set; }
        */
        public virtual Location Location { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeviceConfiguration> DeviceConfigurations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeviceRead> DeviceReads { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationDeviceHistory> LocationDeviceHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reading> Readings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeviceNote> DeviceNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeviceConfigurationFast> DeviceConfigurationFasts { get; set; }

    }

    public partial class DeviceAlert
    {
         public DeviceAlert()
        {
            this.Devices = new HashSet<Device>();
        }

        public System.Guid ID { get; set; }
        public string AlarmEnable { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string AlarmEnableFS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Device> Devices { get; set; }
    }
    public  class ConfigurationTemplateDetail
    {
        public Nullable<bool> UpdateModemFWVersion { get; set; }
        public System.Guid ID { get; set; }
        public Nullable<int> WakeUpTime { get; set; }
        public string WakeUpTimeUOT { get; set; }
        public Nullable<int> UpTimeWait { get; set; }
        public string UpTimeWaitUOT { get; set; }
        public Nullable<int> SamplePressureInterval { get; set; }
        public string SamplePressureIntervalUOT { get; set; }
        public Nullable<int> SampleTempMultiple { get; set; }
        public Nullable<int> NonAlarmPressureMultiple { get; set; }
        public Nullable<int> NonAlarmTempMultiple { get; set; }
        public Nullable<int> AlarmLogTimeout { get; set; }
        public string AlarmLogTimeOutUOT { get; set; }
        public Nullable<int> AlarmLogPressureInterval { get; set; }
        public string AlarmLogPressureIntervalUOT { get; set; }
        public Nullable<int> AlarmLogTempMultiple { get; set; }
        public Nullable<double> ShipmentPressureInterval { get; set; }
        public string ShipmentPressureIntervalUOT { get; set; }
        public Nullable<int> FormatCode { get; set; }
        public string InfoRequest { get; set; }
        public Nullable<bool> Upload { get; set; }
        public Nullable<bool> SendThreshold { get; set; }
        public Nullable<bool> SendIP { get; set; }
        public Nullable<bool> SendShipment { get; set; }
        public Nullable<bool> SendReset { get; set; }
        public Nullable<bool> SendFirmwareUpgrade { get; set; }
        public Nullable<bool> ReadThreshold { get; set; }
        public Nullable<bool> ReadIP { get; set; }
        public Nullable<bool> ReadGPS { get; set; }
        public Nullable<bool> RestoreDefaultCalibration { get; set; }
        public System.Guid ConfigurationTemplateID { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        public virtual ConfigurationTemplate ConfigurationTemplate { get; set; }
    }
    public  class ConfigurationTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConfigurationTemplate()
        {
            this.ConfigurationTemplateDetails = new HashSet<ConfigurationTemplateDetail>();
            this.Devices = new HashSet<Device>();
        }

        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public System.Guid ClientID { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<short> seq { get; set; }
        public bool IsFastSampling { get; set; }

        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConfigurationTemplateDetail> ConfigurationTemplateDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Device> Devices { get; set; }
    }
    public class Client
    {
        public Client()
        {
            this.CommunicationServers = new HashSet<CommunicationServer>();
            this.Districts = new HashSet<District>();
            this.Locations = new HashSet<Location>();
            //this.Notifications = new HashSet<Notification>();
            //this.NotificationGroups = new HashSet<NotificationGroup>();
            //this.NotificationUsers = new HashSet<NotificationUser>();
            //this.PressureZones = new HashSet<PressureZone>();
            this.Users = new HashSet<User>();
            this.ConfigurationTemplates = new HashSet<ConfigurationTemplate>();
            //this.UserRegistrations = new HashSet<UserRegistration>();
            this.Devices = new HashSet<Device>();
            //this.Audits = new HashSet<Audit>();
            //this.Models = new HashSet<Model>();
            //this.UserClients = new HashSet<UserClient>();
        }

        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string CityInFocus { get; set; }
        public Nullable<int> ZoomLevel { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<double> Latitude { get; set; }
        public string DefaultAddress { get; set; }
        public string DefaultCity { get; set; }
        public string DefaultState { get; set; }
        public string DefaultPostalCode { get; set; }
        public Nullable<bool> IsEnventory { get; set; }
        public string DefaultCountry { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommunicationServer> CommunicationServers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District> Districts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Location> Locations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Notification> Notifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<NotificationGroup> NotificationGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<NotificationUser> NotificationUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PressureZone> PressureZones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConfigurationTemplate> ConfigurationTemplates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<UserRegistration> UserRegistrations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Device> Devices { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
        //    "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Audit> Audits { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
         //   "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Model> Models { get; set; }

       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage","CA2227:CollectionPropertiesShouldBeReadOnly")] public virtual ICollection<UserClient> UserClients { get; set; }
    }

    public partial class CommunicationServer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CommunicationServer()
        {
            this.CommunicationServerDetails = new HashSet<CommunicationServerDetail>();
            this.Devices = new HashSet<Device>();
        }

        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public string IsActive { get; set; }
        public System.Guid ClientID { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommunicationServerDetail> CommunicationServerDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Device> Devices { get; set; }
    }
    public  class CommunicationServerDetail
    {
        public System.Guid ID { get; set; }
        public string IPAddress { get; set; }
        public int Port { get; set; }
        public short Sequence { get; set; }
        public Nullable<System.Guid> CommunicationServerID { get; set; }
        public Nullable<System.Guid> DeviceID { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        public virtual CommunicationServer CommunicationServer { get; set; }
        public virtual Device Device { get; set; }
    }

    public partial class District
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public District()
        {
            this.Locations = new HashSet<Location>();
        }

        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public Nullable<System.Guid> ClientID { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Location> Locations { get; set; }
        public virtual Client Client { get; set; }
    }

    public partial class Location
    {
        public string CurrentAddress { get; set; }
        //public int ZipCode { get; set; }

    }
    public partial class UserPinnedLocation
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> UserID { get; set; }
        public Nullable<System.Guid> LocationID { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        public virtual Location Location { get; set; }
        public virtual User User { get; set; }
    }

    public partial class User
    {
        public string UserID { get; set; }
        public string UserRole { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Role { get; set; }
        public string Admins { get; set; }
        public string PressureZone { get; set; }
        public string ClientName { get; set; }
        public string URL { get; set; }
        public string CityInFocus { get; set; }
        public int ZoomLevel { get; set; }
        public int PendingUserRoles { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public bool DisplayUserLocationNew { get; set; }
        public string DefaultLanguage { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool ClientHasTAndCConfiguration { get; set; }
        public bool ClientTermsAndConditionsIsExpired { get; set; }
        public bool UserTAndCIsAcknowledged { get; set; }
        public DateTime UserTAndCStartDate { get; set; }
    }
    public partial class Reading
    {
        public string AlertBit { get; set; }
        public string Alert { get; set; }
        public double Temperature { get; set; }
        public double Pressure { get; set; }
        public double TemperatureController { get; set; }
        public double Signal { get; set; }
        public double BatteryLevel { get; set; }
        public string LastTimeStamp { get; set; }
        public string NumberOfDays { get; set; }
        public string FWVersion { get; set; }
        public string ModemFWVersion { get; set; }
    }
    public partial class LocationDeviceHistory
    {
        public System.Guid ID { get; set; }
        public System.Guid LocationID { get; set; }
        public System.Guid DeviceID { get; set; }
        public string IMEI { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        public virtual Location Location { get; set; }
        public virtual Device Device { get; set; }
    }
    public partial class Location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Location()
        {
            this.Notes = new HashSet<Note>();
            this.UserPinnedLocations = new HashSet<UserPinnedLocation>();
            this.LocationDeviceHistories = new HashSet<LocationDeviceHistory>();
            this.Readings = new HashSet<Reading>();
            this.Devices = new HashSet<Device>();
        }

        public System.Guid ID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }
        public string HydrantNumber { get; set; }
        public string FIDNumber { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.Guid> ClientID { get; set; }
        public Nullable<System.Guid> DistrictID { get; set; }
        public Nullable<System.Guid> PressureZoneID { get; set; }
        public Nullable<System.Guid> ThresholdID { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string Country { get; set; }

        public virtual District District { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Note> Notes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPinnedLocation> UserPinnedLocations { get; set; }
        public virtual Client Client { get; set; }
        //public virtual PressureZone PressureZone { get; set; }
        //public virtual Threshold Threshold { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationDeviceHistory> LocationDeviceHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reading> Readings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Device> Devices { get; set; }
    }

    public partial class Note
    {
        public System.Guid ID { get; set; }
        public string Note1 { get; set; }
        public System.Guid NoteTypeID { get; set; }
        public Nullable<System.Guid> LocationID { get; set; }
        public Nullable<System.Guid> UserID { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        //public virtual NoteType NoteType { get; set; }
        public virtual Location Location { get; set; }
    }
}