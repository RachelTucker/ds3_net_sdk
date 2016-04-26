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
    public class ModifyTapePartitionSpectraS3Request : Ds3Request
    {
        
        public string TapePartition { get; private set; }

        
        private Quiesced _quiesced;
        public Quiesced Quiesced
        {
            get { return _quiesced; }
            set { WithQuiesced(value); }
        }

        public ModifyTapePartitionSpectraS3Request WithQuiesced(Quiesced quiesced)
        {
            this._quiesced = quiesced;
            if (quiesced != null) {
                this.QueryParams.Add("quiesced", quiesced.ToString());
            }
            else
            {
                this.QueryParams.Remove("quiesced");
            }
            return this;
        }

        public ModifyTapePartitionSpectraS3Request(string tapePartition) {
            this.TapePartition = tapePartition;
            
        }

        internal override HttpVerb Verb
        {
            get
            {
                return HttpVerb.PUT
            }
        }

        internal override string Path
        {
            get
            {
                return "/_rest_/tape_partition/" + TapePartition;
            }
        }
    }
}