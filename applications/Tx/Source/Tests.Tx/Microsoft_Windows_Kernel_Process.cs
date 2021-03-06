// 
//    This code was generated by EtwEventTypeGen.exe 
//

using System;

namespace Microsoft.Etw.Microsoft_Windows_Kernel_Process
{
    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 10, 0)]
    public class IoPriorityChange : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ThreadID { get; set; }

        [EventField("win:UInt8")]
        public byte OldPriority { get; set; }

        [EventField("win:UInt8")]
        public byte NewPriority { get; set; }
    }

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 9, 0)]
    public class PagePriorityChange : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ThreadID { get; set; }

        [EventField("win:UInt8")]
        public byte OldPriority { get; set; }

        [EventField("win:UInt8")]
        public byte NewPriority { get; set; }
    }

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 8, 0)]
    public class CpuPriorityChange : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ThreadID { get; set; }

        [EventField("win:UInt8")]
        public byte OldPriority { get; set; }

        [EventField("win:UInt8")]
        public byte NewPriority { get; set; }
    }

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 7, 0)]
    public class CpuBasePriorityChange : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ThreadID { get; set; }

        [EventField("win:UInt8")]
        public byte OldPriority { get; set; }

        [EventField("win:UInt8")]
        public byte NewPriority { get; set; }
    }

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 6, 0)]
    public class ImageUnload : SystemEvent
    {
        [EventField("win:Pointer")]
        public ulong ImageBase { get; set; }

        [EventField("win:Pointer")]
        public ulong ImageSize { get; set; }

        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ImageCheckSum { get; set; }

        [EventField("win:UInt32")]
        public uint TimeDateStamp { get; set; }

        [EventField("win:Pointer")]
        public ulong DefaultBase { get; set; }

        [EventField("win:UnicodeString")]
        public string ImageName { get; set; }
    }

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 5, 0)]
    public class ImageLoad : SystemEvent
    {
        [EventField("win:Pointer")]
        public ulong ImageBase { get; set; }

        [EventField("win:Pointer")]
        public ulong ImageSize { get; set; }

        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ImageCheckSum { get; set; }

        [EventField("win:UInt32")]
        public uint TimeDateStamp { get; set; }

        [EventField("win:Pointer")]
        public ulong DefaultBase { get; set; }

        [EventField("win:UnicodeString")]
        public string ImageName { get; set; }
    }

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 4, 0)]
    public class ThreadStop_V0 : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ThreadID { get; set; }

        [EventField("win:Pointer")]
        public ulong StackBase { get; set; }

        [EventField("win:Pointer")]
        public ulong StackLimit { get; set; }

        [EventField("win:Pointer")]
        public ulong UserStackBase { get; set; }

        [EventField("win:Pointer")]
        public ulong UserStackLimit { get; set; }

        [EventField("win:Pointer")]
        public ulong StartAddr { get; set; }

        [EventField("win:Pointer")]
        public ulong Win32StartAddr { get; set; }

        [EventField("win:Pointer")]
        public ulong TebBase { get; set; }
    }

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 3, 0)]
    public class ThreadStart_V0 : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ThreadID { get; set; }

        [EventField("win:Pointer")]
        public ulong StackBase { get; set; }

        [EventField("win:Pointer")]
        public ulong StackLimit { get; set; }

        [EventField("win:Pointer")]
        public ulong UserStackBase { get; set; }

        [EventField("win:Pointer")]
        public ulong UserStackLimit { get; set; }

        [EventField("win:Pointer")]
        public ulong StartAddr { get; set; }

        [EventField("win:Pointer")]
        public ulong Win32StartAddr { get; set; }

        [EventField("win:Pointer")]
        public ulong TebBase { get; set; }
    }

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 2, 0)]
    public class ProcessStop_V0 : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:FILETIME")]
        public DateTime CreateTime { get; set; }

        [EventField("win:FILETIME")]
        public DateTime ExitTime { get; set; }

        [EventField("win:UInt32")]
        public uint ExitCode { get; set; }

        [EventField("win:UInt32")]
        public uint TokenElevationType { get; set; }

        [EventField("win:UInt32")]
        public uint HandleCount { get; set; }

        [EventField("win:UInt64")]
        public ulong CommitCharge { get; set; }

        [EventField("win:UInt64")]
        public ulong CommitPeak { get; set; }

        [EventField("win:AnsiString")]
        public string ImageName { get; set; }
    }

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 1, 0)]
    public class ProcessStart : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:FILETIME")]
        public DateTime CreateTime { get; set; }

        [EventField("win:UInt32")]
        public uint ParentProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint SessionID { get; set; }

        [EventField("win:UnicodeString")]
        public string ImageName { get; set; }
    }

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 4, 1)]
    public class ThreadStop : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ThreadID { get; set; }

        [EventField("win:Pointer")]
        public ulong StackBase { get; set; }

        [EventField("win:Pointer")]
        public ulong StackLimit { get; set; }

        [EventField("win:Pointer")]
        public ulong UserStackBase { get; set; }

        [EventField("win:Pointer")]
        public ulong UserStackLimit { get; set; }

        [EventField("win:Pointer")]
        public ulong StartAddr { get; set; }

        [EventField("win:Pointer")]
        public ulong Win32StartAddr { get; set; }

        [EventField("win:Pointer")]
        public ulong TebBase { get; set; }

        [EventField("win:UInt32")]
        public uint SubProcessTag { get; set; }

        [EventField("win:UInt64")]
        public ulong CycleTime { get; set; }
    }

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 3, 1)]
    public class ThreadStart : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:UInt32")]
        public uint ThreadID { get; set; }

        [EventField("win:Pointer")]
        public ulong StackBase { get; set; }

        [EventField("win:Pointer")]
        public ulong StackLimit { get; set; }

        [EventField("win:Pointer")]
        public ulong UserStackBase { get; set; }

        [EventField("win:Pointer")]
        public ulong UserStackLimit { get; set; }

        [EventField("win:Pointer")]
        public ulong StartAddr { get; set; }

        [EventField("win:Pointer")]
        public ulong Win32StartAddr { get; set; }

        [EventField("win:Pointer")]
        public ulong TebBase { get; set; }

        [EventField("win:UInt32")]
        public uint SubProcessTag { get; set; }
    }

    [ManifestEvent("{22fb2cd6-0e7b-422b-a0c7-2fad1fd0e716}", 2, 1)]
    public class ProcessStop : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ProcessID { get; set; }

        [EventField("win:FILETIME")]
        public DateTime CreateTime { get; set; }

        [EventField("win:FILETIME")]
        public DateTime ExitTime { get; set; }

        [EventField("win:UInt32")]
        public uint ExitCode { get; set; }

        [EventField("win:UInt32")]
        public uint TokenElevationType { get; set; }

        [EventField("win:UInt32")]
        public uint HandleCount { get; set; }

        [EventField("win:UInt64")]
        public ulong CommitCharge { get; set; }

        [EventField("win:UInt64")]
        public ulong CommitPeak { get; set; }

        [EventField("win:UInt64")]
        public ulong CPUCycleCount { get; set; }

        [EventField("win:UInt32")]
        public uint ReadOperationCount { get; set; }

        [EventField("win:UInt32")]
        public uint WriteOperationCount { get; set; }

        [EventField("win:UInt32")]
        public uint ReadTransferKiloBytes { get; set; }

        [EventField("win:UInt32")]
        public uint WriteTransferKiloBytes { get; set; }

        [EventField("win:UInt32")]
        public uint HardFaultCount { get; set; }

        [EventField("win:AnsiString")]
        public string ImageName { get; set; }
    }

}
