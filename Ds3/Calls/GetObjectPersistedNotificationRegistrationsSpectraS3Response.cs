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
using Ds3.Models;

namespace Ds3.Calls
{
    public class GetObjectPersistedNotificationRegistrationsSpectraS3Response
    {
        public S3ObjectPersistedNotificationRegistrationList ResponsePayload { get; private set; }
        public int? PagingTruncated { get; private set; }
        public int? PagingTotalResultCount { get; private set; }

        public GetObjectPersistedNotificationRegistrationsSpectraS3Response(S3ObjectPersistedNotificationRegistrationList responsePayload, int? pagingTruncated, int? pagingTotalResultCount)
        {
            this.ResponsePayload = responsePayload;
            this.PagingTruncated = pagingTruncated;
            this.PagingTotalResultCount = pagingTotalResultCount;
        }
    }
}