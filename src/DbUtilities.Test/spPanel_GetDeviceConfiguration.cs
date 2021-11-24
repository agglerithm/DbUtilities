using System;
using System.Data.Common;
using DbUtilities.StoredProcedures;

namespace DbUtilities.Test
{
    public class spPanel_GetDeviceConfiguration : DbProcedure<DeviceConfigurationResult>
    {
        public spPanel_GetDeviceConfiguration(Func<DbConnection> connectionFactory, Action<object> logger = null) : base(connectionFactory, logger)
        {
        }


        protected override string GetProcName()
        {
            return StoredProcTests.StoredProcName;
        }
    }
}