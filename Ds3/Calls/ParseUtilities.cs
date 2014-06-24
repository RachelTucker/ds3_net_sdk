﻿/*
 * ******************************************************************************
 *   Copyright 2014 Spectra Logic Corporation. All Rights Reserved.
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

using System;
using System.Linq;
using System.Xml.Linq;

using Ds3.Models;
using Ds3.Runtime;
using System.Collections.Generic;

namespace Ds3.Calls
{
    internal class ParseUtilities
    {
        public static JobInfo ParseJobInfo(XElement jobElement)
        {
            return new JobInfo(
                jobElement.AttributeText("BucketName"),
                jobElement.AttributeText("StartDate"),
                Guid.Parse(jobElement.AttributeText("JobId")),
                jobElement.AttributeText("Priority"),
                jobElement.AttributeText("RequestType")
            );
        }

        public static Ds3Object ParseDs3Object(XElement objectElement)
        {
            return new Ds3Object(
                objectElement.AttributeText("Name"),
                Convert.ToInt64(objectElement.AttributeText("Size"))
            );
        }

        public static IDictionary<string, string> ExtractCustomMetadata(IDictionary<string, string> headers)
        {
            return headers
                .Keys
                .Where(key => key.StartsWith(HttpHeaders.AwsMetadataPrefix))
                .ToDictionary(key => key.Substring(HttpHeaders.AwsMetadataPrefix.Length), key => headers[key]);
        }
    }
}
