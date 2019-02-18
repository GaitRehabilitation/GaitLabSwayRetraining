using Plugin.BluetoothLE;
using System;
using System.Collections.Generic;
using System.Text;

namespace PartialSway.Services
{
    public interface IBluetoothService
    {
        IAdapter Current { get; }
    }
}
