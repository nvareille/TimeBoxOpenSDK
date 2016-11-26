using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using TimeBoxOpenSDK.Commands;

namespace TimeBoxOpenSDK
{
    public class TimeBoxWrapper
    {
        public static int REQ_NEED = 2;

        private static BluetoothClient LocalClient;
        private static BluetoothComponent LocalComponent;

        public TimeBoxWrapper()
        {
            LocalClient = new BluetoothClient();
            LocalComponent = new BluetoothComponent(LocalClient);
        }

        public void Connect(AsyncCallback OnConnected)
        {
            var t = LocalClient.DiscoverDevices(255, false, true, false, false);

            foreach (var bluetoothDeviceInfo in t)
            {
                Console.WriteLine(bluetoothDeviceInfo.DeviceName + " " + bluetoothDeviceInfo.Connected);

                if (bluetoothDeviceInfo.Connected)
                {
                    LocalClient.BeginConnect(bluetoothDeviceInfo.DeviceAddress, BluetoothService.SerialPort,
                        OnConnected, bluetoothDeviceInfo);
                }
            }
        }

        public static BluetoothComponent GetComponent()
        {
            return (LocalComponent);
        }

        public static BluetoothClient GetClient()
        {
            return (LocalClient);
        }

        public static byte[] EncodeCmd(int cmd_type, byte[] cmd_data = null)
        {
            byte[] sendbuf;
            byte[] cmd;
            int i;
            int i2;
            int cmd1 = cmd_type;
            bool cmdData_f = !(cmd_data == null);

            if (cmdData_f)
            {
                cmd = new byte[(cmd_data.Length + 7)];
            }
            else
            {
                cmd = new byte[7];
            }
            cmd[0] = (byte) 1;
            cmd[1] = (byte) ((cmd.Length - 4) & TelnetOption.MAX_OPTION_VALUE);
            cmd[REQ_NEED] = (byte) (((cmd.Length - 4) >> 8) & TelnetOption.MAX_OPTION_VALUE);
            cmd[3] = (byte) (cmd1 & TelnetOption.MAX_OPTION_VALUE);
            if (cmdData_f)
            {
                for (i = 0; i < cmd_data.Length; i++)
                {
                    cmd[i + 4] = cmd_data[i];
                }
            }
            int CheckSum = 0;
            for (i = 1; i < cmd.Length - 2; i++)
            {
                CheckSum = (CheckSum + (cmd[i] & TelnetOption.MAX_OPTION_VALUE)) & SupportMenu.USER_MASK;
            }
            cmd[cmd.Length - 3] = (byte) (CheckSum & TelnetOption.MAX_OPTION_VALUE);
            cmd[cmd.Length - 2] = (byte) ((CheckSum >> 8) & TelnetOption.MAX_OPTION_VALUE);
            cmd[cmd.Length - 1] = (byte) 2;
            byte[] sendcmd = new byte[(cmd.Length*REQ_NEED)];
            sendcmd[0] = (byte) 1;
            i = 1;
            int count = 1;
            while (i < cmd.Length - 1)
            {
                if (cmd[i] == 1)
                {
                    i2 = count + 1;
                    sendcmd[count] = (byte) 3;
                    count = i2 + 1;
                    sendcmd[i2] = (byte) 4;
                    i2 = count;
                }
                else if (cmd[i] == REQ_NEED)
                {
                    i2 = count + 1;
                    sendcmd[count] = (byte) 3;
                    count = i2 + 1;
                    sendcmd[i2] = (byte) 5;
                    i2 = count;
                }
                else if (cmd[i] == 3)
                {
                    i2 = count + 1;
                    sendcmd[count] = (byte) 3;
                    count = i2 + 1;
                    sendcmd[i2] = (byte) 6;
                    i2 = count;
                }
                else
                {
                    i2 = count + 1;
                    sendcmd[count] = cmd[i];
                }
                i++;
                count = i2;
            }
            i2 = count + 1;
            sendcmd[count] = (byte) 2;
            sendbuf = new byte[i2];
            for (int index = 0; index < i2; index++)
            {
                sendbuf[index] = sendcmd[index];
            }

            return sendbuf;
        }
    }
}
