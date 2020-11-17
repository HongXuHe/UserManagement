using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagement.Dtos
{
    public class DeviceDto
    {
        public Guid Id { get; set; }
        public string DeviceName { get; set; }
        public string DeviceDes { get; set; }
        public string COM { get; set; }
        public int BaudRate { get; set; } 
        public System.IO.Ports.Parity Parity { get; set; }
        public int DataBits { get; set; } = 8;
        public System.IO.Ports.StopBits StopBits { get; set; }
    }
}
