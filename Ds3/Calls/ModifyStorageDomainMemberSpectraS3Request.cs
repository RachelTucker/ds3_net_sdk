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
    public class ModifyStorageDomainMemberSpectraS3Request : Ds3Request
    {
        
        public string StorageDomainMember { get; private set; }

        
        private int? _autoCompactionThreshold;
        public int? AutoCompactionThreshold
        {
            get { return _autoCompactionThreshold; }
            set { WithAutoCompactionThreshold(value); }
        }

        private StorageDomainMemberState? _state;
        public StorageDomainMemberState? State
        {
            get { return _state; }
            set { WithState(value); }
        }

        private WritePreferenceLevel? _writePreference;
        public WritePreferenceLevel? WritePreference
        {
            get { return _writePreference; }
            set { WithWritePreference(value); }
        }

        
        public ModifyStorageDomainMemberSpectraS3Request WithAutoCompactionThreshold(int? autoCompactionThreshold)
        {
            this._autoCompactionThreshold = autoCompactionThreshold;
            if (autoCompactionThreshold != null)
            {
                this.QueryParams.Add("auto_compaction_threshold", autoCompactionThreshold.ToString());
            }
            else
            {
                this.QueryParams.Remove("auto_compaction_threshold");
            }
            return this;
        }

        
        public ModifyStorageDomainMemberSpectraS3Request WithState(StorageDomainMemberState? state)
        {
            this._state = state;
            if (state != null)
            {
                this.QueryParams.Add("state", state.ToString());
            }
            else
            {
                this.QueryParams.Remove("state");
            }
            return this;
        }

        
        public ModifyStorageDomainMemberSpectraS3Request WithWritePreference(WritePreferenceLevel? writePreference)
        {
            this._writePreference = writePreference;
            if (writePreference != null)
            {
                this.QueryParams.Add("write_preference", writePreference.ToString());
            }
            else
            {
                this.QueryParams.Remove("write_preference");
            }
            return this;
        }


        
        
        public ModifyStorageDomainMemberSpectraS3Request(string storageDomainMember)
        {
            this.StorageDomainMember = storageDomainMember;
            
        }

        internal override HttpVerb Verb
        {
            get
            {
                return HttpVerb.PUT;
            }
        }

        internal override string Path
        {
            get
            {
                return "/_rest_/storage_domain_member/" + StorageDomainMember;
            }
        }
    }
}