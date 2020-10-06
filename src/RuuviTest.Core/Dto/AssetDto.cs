﻿using RuuviTest.Core.ValueObjects;
using RuuviTest.SharedKernel.Base;

namespace RuuviTest.Core.Dto
{

    public class AssetDto : BaseEntity
    {
        public string DeviceId { get; set; }
        public string Name { get; set; }

        public SingleStat[] Temperature { get; set; }
        public SingleStat[] Humidity { get; set; }
        public SingleStat[] Pressure { get; set; }
        public SingleStat[] BatteryLevel { get; set; }
        public LocationStat[] Route { get; set; }

    }
}