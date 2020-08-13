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

using Ds3.Calls;
using Ds3.Runtime;
using System;
using System.Linq;
using System.Net;

namespace Ds3.ResponseParsers
{
    internal class GetJobChunksReadyForClientProcessingSpectraS3ResponseParser : IResponseParser<GetJobChunksReadyForClientProcessingSpectraS3Request, GetJobChunksReadyForClientProcessingSpectraS3Response>
    {
        public GetJobChunksReadyForClientProcessingSpectraS3Response Parse(GetJobChunksReadyForClientProcessingSpectraS3Request request, IWebResponse response)
        {
            using (response)
            {
                ResponseParseUtilities.HandleStatusCode(response, HttpStatusCode.OK, HttpStatusCode.NotFound);
                using (var stream = response.GetResponseStream())
                {
                    switch (response.StatusCode)
                    {
                        case HttpStatusCode.OK:
                            var jobResponse = ModelParsers.ParseMasterObjectList(
                                XmlExtensions.ReadDocument(stream).ElementOrThrow("MasterObjectList"));

                            if (jobResponse.Objects.Any())
                            {
                                return GetJobChunksReadyForClientProcessingSpectraS3Response.Success(RetryAfterHeader(response), jobResponse);
                            }
                            return GetJobChunksReadyForClientProcessingSpectraS3Response.RetryAfter(RetryAfterHeader(response));

                        case HttpStatusCode.NotFound:
                            return GetJobChunksReadyForClientProcessingSpectraS3Response.JobGone;

                        default:
                            throw new NotSupportedException(Resources.InvalidEnumValueException);
                    }
                }
            }
        }

        private static TimeSpan RetryAfterHeader(IWebResponse response)
        {
            return TimeSpan.FromSeconds(int.Parse(response.Headers["retry-after"]));
        }
    }
}