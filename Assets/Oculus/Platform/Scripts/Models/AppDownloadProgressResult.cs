// This file was @generated with LibOVRPlatform/codegen/main. Do not modify it!

namespace Oculus.Platform.Models
{
    using System;

    public class AppDownloadProgressResult
    {
        /// Total number of bytes that need to be downloaded
        public readonly long DownloadBytes;
        /// Number of bytes that have already been downloaded
        public readonly long DownloadedBytes;
        /// Status code of the current app status. Can be used to find if app is
        /// downloading etc.
        public readonly AppStatus StatusCode;


        public AppDownloadProgressResult(IntPtr o)
        {
            DownloadBytes = CAPI.ovr_AppDownloadProgressResult_GetDownloadBytes(o);
            DownloadedBytes = CAPI.ovr_AppDownloadProgressResult_GetDownloadedBytes(o);
            StatusCode = CAPI.ovr_AppDownloadProgressResult_GetStatusCode(o);
        }
    }

}
