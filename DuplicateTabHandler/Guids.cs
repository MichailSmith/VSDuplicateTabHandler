// Guids.cs
// MUST match guids.h
using System;

namespace SimplifierSoftware.DuplicateTabHandler
{
    static class GuidList
    {
        public const string guidDuplicateTabHandlerPkgString = "1ac22e37-8197-4d9b-ae0b-b6ab644ab090";
        public const string guidDuplicateTabHandlerCmdSetString = "ed57fda0-ec09-40fb-87e6-a6cea9e8a180";

        public static readonly Guid guidDuplicateTabHandlerCmdSet = new Guid(guidDuplicateTabHandlerCmdSetString);
    };
}