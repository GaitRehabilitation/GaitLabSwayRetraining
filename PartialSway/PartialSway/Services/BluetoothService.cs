using Plugin.BluetoothLE;
using System;
using System.Collections.Generic;

namespace PartialSway.Services
{
    public class BluetoothService : IBluetoothService
    {
        public IAdapter Current => CrossBleAdapter.Current;
    }
}
