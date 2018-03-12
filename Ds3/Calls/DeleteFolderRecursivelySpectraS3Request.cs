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
using System;
using System.Net;

namespace Ds3.Calls
{
    public class DeleteFolderRecursivelySpectraS3Request : Ds3Request
    {
        
        public string Folder { get; private set; }

        public string BucketId { get; private set; }

        

        
        
        public DeleteFolderRecursivelySpectraS3Request(Guid bucketId, string folder)
        {
            this.Folder = folder;
            this.BucketId = bucketId.ToString();
            
            this.QueryParams.Add("bucket_id", bucketId.ToString());

            this.QueryParams.Add("recursive", null);

        }

        
        public DeleteFolderRecursivelySpectraS3Request(string bucketId, string folder)
        {
            this.Folder = folder;
            this.BucketId = bucketId;
            
            this.QueryParams.Add("bucket_id", bucketId);

            this.QueryParams.Add("recursive", null);

        }

        internal override HttpVerb Verb
        {
            get
            {
                return HttpVerb.DELETE;
            }
        }

        internal override string Path
        {
            get
            {
                return "/_rest_/folder/" + Folder;
            }
        }
    }
}