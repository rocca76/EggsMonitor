﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Research.DynamicDataDisplay.Common;

namespace EggsMonitor
{
    public class IncubatorDataCollection : RingArray<IncubatorData>
    {
        private const int TotalData = 900;
        public IntPtr CurrPointer = IntPtr.Zero;
        public IntPtr PrevPointer = IntPtr.Zero;

        public IncubatorDataCollection()
            : base(TotalData)
        {
        }

        public IncubatorDataCollection(int capacity)
            : base(capacity)
        {
        }
    }

    public class IncubatorData
    {
        public IncubatorData(DateTime time, double temperature, double relativeHumidity, int co2)
        {
            Time = time;
            this.Temperature = temperature;
            this.RelativeHumidity = relativeHumidity;
            this.CO2 = co2;
        }

        public DateTime Time { get; set; }

        public double Temperature { get; set; }

        public double RelativeHumidity { get; set; }

        public int CO2 { get; set; }
    }
}
