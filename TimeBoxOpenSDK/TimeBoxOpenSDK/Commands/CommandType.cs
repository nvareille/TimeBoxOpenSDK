using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeBoxOpenSDK.Values;

namespace TimeBoxOpenSDK.Commands
{
    public static class CommandType
    {
        private static int _SetSystemTime = 24;
        private static int _SetBoxColor = 68;
        public static int GetSysVersion = 144;
        public static int SetConnectedFlag = 175;
        private static int _GetConnectedFlag = 176;

        public static byte[] SetSystemTime()
        {
            DateTime dt = DateTime.Now;

            int year = dt.Year;
            int center = year / 100;
            int year_center = year % 100;
            int month = dt.Month;
            int day_week = (int)dt.DayOfWeek;
            int day_month = dt.Day;
            int hour = dt.Hour;
            int minute = dt.Minute;
            int second = dt.Second;

            byte[] cmd = TimeBoxWrapper.EncodeCmd(_SetSystemTime,
                new byte[]
                {
                    (byte) (year_center & TelnetOption.MAX_OPTION_VALUE), (byte) (center & TelnetOption.MAX_OPTION_VALUE),
                    (byte) (month & TelnetOption.MAX_OPTION_VALUE), (byte) (day_month & TelnetOption.MAX_OPTION_VALUE),
                    (byte) (hour & TelnetOption.MAX_OPTION_VALUE), (byte) (minute & TelnetOption.MAX_OPTION_VALUE),
                    (byte) (second & TelnetOption.MAX_OPTION_VALUE), (byte) (day_week & TelnetOption.MAX_OPTION_VALUE)
                });
            return cmd;
        }

        public static byte[] SetBoxColor(byte[] data)
        {
            byte[] cmd_data = new byte[SMTPReply.UNRECOGNIZED_COMMAND];
            int offset = 0 + 1;
            cmd_data[0] = (byte)0;
            int offset2 = offset + 1;
            cmd_data[offset] = (byte)10;
            offset = offset2 + 1;
            cmd_data[offset2] = (byte)10;
            offset2 = offset + 1;
            cmd_data[offset] = (byte)4;
            for (int j = 0; j < 363; j += 2)
            {
                if (j == 362)
                {
                    cmd_data[offset2] = (byte)(toUnsigned(data[j]) >> 4);
                }
                else
                {
                    cmd_data[offset2] = (byte)((toUnsigned(data[j]) >> 4) | ((toUnsigned(data[j + 1]) >> 4) << 4));
                }
                offset2++;
            }
            byte[] tmp_cmd_data = new byte[offset2];
            for (int i = 0; i < offset2; i++)
            {
                tmp_cmd_data[i] = cmd_data[i];
            }
            return TimeBoxWrapper.EncodeCmd(_SetBoxColor, tmp_cmd_data);
        }

        public static byte[] GetConnectedFlag()
        {
            return (TimeBoxWrapper.EncodeCmd(_GetConnectedFlag));
        }

        public static int toUnsigned(byte s)
        {
            return s & TelnetOption.MAX_OPTION_VALUE;
        }
    }
}
