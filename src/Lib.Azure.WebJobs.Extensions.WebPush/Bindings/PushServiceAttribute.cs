﻿using System;
using Microsoft.Azure.WebJobs.Description;
using Lib.Net.Http.WebPush;

namespace Lib.Azure.WebJobs.Extensions.WebPush.Bindings
{
    /// <summary>
    /// Attribute used to bind to a PushService.
    /// </summary>
    /// <remarks>
    /// The method parameter type can be one of the following:
    /// <list type="bullet">
    /// <item><description><see cref="PushServiceClient"/></description></item>
    /// </list>
    /// </remarks>
    [Binding]
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class PushServiceAttribute : Attribute
    {
        /// <summary>
        /// The application server public key.
        /// </summary>
        [AppSetting]
        public string PublicKeySetting { get; set; }

        /// <summary>
        /// The application server private key.
        /// </summary>
        [AppSetting]
        public string PrivateKeySetting { get; set; }

        /// <summary>
        /// The contact information for the application server.
        /// </summary>
        [AppSetting]
        public string SubjectSetting { get; set; }
    }
}
