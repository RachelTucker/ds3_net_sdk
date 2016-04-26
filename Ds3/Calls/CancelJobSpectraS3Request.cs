/*
 * ******************************************************************************
 *   Copyright 2014-2015 Spectra Logic Corporation. All Rights Reserved.
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
using System.Net;

namespace Ds3.Calls
{
    public class CancelJobSpectraS3Request : Ds3Request
    {
        
        public Guid JobId { get; private set; }

        
        private bool _force;
        public bool Force
        {
            get { return _force; }
            set { WithForce(value); }
        }

        public CancelJobSpectraS3Request WithForce(bool force)
        {
            this._force = force;
            if (force != null) {
                this.QueryParams.Add("force", force.ToString());
            }
            else
            {
                this.QueryParams.Remove("force");
            }
            return this;
        }

        public CancelJobSpectraS3Request(Guid jobId) {
            this.JobId = jobId;
            
        }

        internal override HttpVerb Verb
        {
            get
            {
                return HttpVerb.DELETE
            }
        }

        internal override string Path
        {
            get
            {
                return "/_rest_/job/" + jobId.ToString();
            }
        }
    }
}