/*
 * ******************************************************************************
 *   Copyright 2014-2017 Spectra Logic Corporation. All Rights Reserved.
 *   Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *   this file except in compliance with the License. A copy of the License is located at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 *   or in the "license" file accompanying this file.
 *   This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *   CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *   specific language governing permissions and limitations under the License.
 * ****************************************************************************
 */

// This code is auto-generated, do not modify

using System;
using System.Collections.Generic;

namespace Ds3.Models
{
    public class BucketChangesNotificationRegistration
    {
        public Guid? BucketId { get; set; }
        public DateTime CreationDate { get; set; }
        public HttpResponseFormatType Format { get; set; }
        public Guid Id { get; set; }
        public string LastFailure { get; set; }
        public int? LastHttpResponseCode { get; set; }
        public DateTime? LastNotification { get; set; }
        public long? LastSequenceNumber { get; set; }
        public NamingConventionType NamingConvention { get; set; }
        public string NotificationEndPoint { get; set; }
        public RequestType NotificationHttpMethod { get; set; }
        public int NumberOfFailuresSinceLastSuccess { get; set; }
        public Guid? UserId { get; set; }
    }
}
