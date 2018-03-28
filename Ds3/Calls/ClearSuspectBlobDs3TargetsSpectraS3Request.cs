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
using System.Collections.Generic;

namespace Ds3.Calls
{
    public class ClearSuspectBlobDs3TargetsSpectraS3Request : AbstractIdsPayloadRequest
    {
        
        
        private bool? _force;
        public bool? Force
        {
            get { return _force; }
            set { WithForce(value); }
        }

        
        public ClearSuspectBlobDs3TargetsSpectraS3Request WithForce(bool? force)
        {
            this._force = force;
            if (force != null)
            {
                this.QueryParams.Add("force", force.ToString());
            }
            else
            {
                this.QueryParams.Remove("force");
            }
            return this;
        }


        
        public ClearSuspectBlobDs3TargetsSpectraS3Request(IEnumerable<string> ids) : base(ids)
        {
            
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
                return "/_rest_/suspect_blob_ds3_target";
            }
        }
    }
}