// This file was @generated with LibOVRPlatform/codegen/main. Do not modify it!

namespace Oculus.Platform.Models
{
    using System;

    public class AppDownloadResult
    {
        /// Timestamp in milliseconds when the operation finished.
        public readonly long Timestamp;


        public AppDownloadResult(IntPtr o)
        {
            Timestamp = CAPI.ovr_AppDownloadResult_GetTimestamp(o);
        }
    }

}
