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
    public class GetSuspectObjectsWithFullDetailsSpectraS3Request : Ds3Request
    {
        
        
        private string _bucketId;
        public string BucketId
        {
            get { return _bucketId; }
            set { WithBucketId(value); }
        }

        private string _storageDomain;
        public string StorageDomain
        {
            get { return _storageDomain; }
            set { WithStorageDomain(value); }
        }

        
        public GetSuspectObjectsWithFullDetailsSpectraS3Request WithBucketId(Guid? bucketId)
        {
            this._bucketId = bucketId.ToString();
            if (bucketId != null)
            {
                this.QueryParams.Add("bucket_id", bucketId.ToString());
            }
            else
            {
                this.QueryParams.Remove("bucket_id");
            }
            return this;
        }

        
        public GetSuspectObjectsWithFullDetailsSpectraS3Request WithBucketId(string bucketId)
        {
            this._bucketId = bucketId;
            if (bucketId != null)
            {
                this.QueryParams.Add("bucket_id", bucketId);
            }
            else
            {
                this.QueryParams.Remove("bucket_id");
            }
            return this;
        }

        
        public GetSuspectObjectsWithFullDetailsSpectraS3Request WithStorageDomain(string storageDomain)
        {
            this._storageDomain = storageDomain;
            if (storageDomain != null)
            {
                this.QueryParams.Add("storage_domain", storageDomain);
            }
            else
            {
                this.QueryParams.Remove("storage_domain");
            }
            return this;
        }


        
        
        public GetSuspectObjectsWithFullDetailsSpectraS3Request()
        {
            
            this.QueryParams.Add("full_details", null);

        }

        internal override HttpVerb Verb
        {
            get
            {
                return HttpVerb.GET;
            }
        }

        internal override string Path
        {
            get
            {
                return "/_rest_/suspect_object";
            }
        }
    }
}