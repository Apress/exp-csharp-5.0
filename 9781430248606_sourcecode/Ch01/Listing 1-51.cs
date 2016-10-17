//using System;
//using System.Runtime.InteropServices;
//namespace Ch01
//{
//    class Program
//    {
//        [DllImport("User32.dll")]
//        static extern Boolean MessageBeep(UInt32 beepType);

//        static void Main()
//        {
//            MessageBeep((UInt32)BeepTypes.MB_ICONEXCLAMATION);
//        }
//        enum BeepTypes
//        {
//            MB_ICONASTERISK = 0x00000040,
//            MB_ICONEXCLAMATION = 0x00000030
//        }
//    }
//}
