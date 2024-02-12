// This file was @generated with LibOVRPlatform/codegen/main. Do not modify it!

namespace Oculus.Platform.Models
{
    using System;

    public class UserAccountAgeCategory
    {
        /// Age category of the user in Meta account.
        public readonly AccountAgeCategory AgeCategory;


        public UserAccountAgeCategory(IntPtr o)
        {
            AgeCategory = CAPI.ovr_UserAccountAgeCategory_GetAgeCategory(o);
        }
    }

}
