﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagement.Entity
{
    public class Device:BaseEntity
    {       
        public string DeviceName { get; set; }
        public string DeviceDes { get; set; }
        public string COM { get; set; }
        public int BaudRate { get; set; } = 9600;
        public System.IO.Ports.Parity Parity { get; set; } = System.IO.Ports.Parity.None;
        public int DataBits { get; set; } = 8;
        public System.IO.Ports.StopBits StopBits { get; set; } = System.IO.Ports.StopBits.One;
    }
}
