// Guids.cs
// MUST match guids.h
using System;

using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace JasonBell.Pie_VisualStudio
{
    static class GuidList
    {
        public const string guidPie_VisualStudioPkgString = "6fd2ce86-9a8f-4fd2-9d1c-e7f1c5cce720";
        public const string guidPie_VisualStudioCmdSetString = "5c4fb2b3-b747-429c-9fde-2177b0efafb6";

        public static readonly Guid guidPie_VisualStudioCmdSet = new Guid(guidPie_VisualStudioCmdSetString);

        public const string guidSimpleProjectPkgString =
            "96bf4c26-d94e-43bf-a56a-f8500b52bfad";
        public const string guidSimpleProjectCmdSetString =
            "72c23e1d-f389-410a-b5f1-c938303f1391";
        public const string guidSimpleProjectFactoryString =
            "471EC4BB-E47E-4229-A789-D1F5F83B52D4";

        public static readonly Guid guidSimpleProjectCmdSet =
            new Guid(guidSimpleProjectCmdSetString);
        public static readonly Guid guidSimpleProjectFactory =
            new Guid(guidSimpleProjectFactoryString);
    };


}