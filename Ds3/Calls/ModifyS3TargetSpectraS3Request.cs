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
    public class ModifyS3TargetSpectraS3Request : Ds3Request
    {
        
        public string S3Target { get; private set; }

        
        private string _accessKey;
        public string AccessKey
        {
            get { return _accessKey; }
            set { WithAccessKey(value); }
        }

        private int? _autoVerifyFrequencyInDays;
        public int? AutoVerifyFrequencyInDays
        {
            get { return _autoVerifyFrequencyInDays; }
            set { WithAutoVerifyFrequencyInDays(value); }
        }

        private string _cloudBucketPrefix;
        public string CloudBucketPrefix
        {
            get { return _cloudBucketPrefix; }
            set { WithCloudBucketPrefix(value); }
        }

        private string _cloudBucketSuffix;
        public string CloudBucketSuffix
        {
            get { return _cloudBucketSuffix; }
            set { WithCloudBucketSuffix(value); }
        }

        private string _dataPathEndPoint;
        public string DataPathEndPoint
        {
            get { return _dataPathEndPoint; }
            set { WithDataPathEndPoint(value); }
        }

        private TargetReadPreferenceType? _defaultReadPreference;
        public TargetReadPreferenceType? DefaultReadPreference
        {
            get { return _defaultReadPreference; }
            set { WithDefaultReadPreference(value); }
        }

        private bool? _https;
        public bool? Https
        {
            get { return _https; }
            set { WithHttps(value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { WithName(value); }
        }

        private CloudNamingMode? _namingMode;
        public CloudNamingMode? NamingMode
        {
            get { return _namingMode; }
            set { WithNamingMode(value); }
        }

        private int? _offlineDataStagingWindowInTb;
        public int? OfflineDataStagingWindowInTb
        {
            get { return _offlineDataStagingWindowInTb; }
            set { WithOfflineDataStagingWindowInTb(value); }
        }

        private bool? _permitGoingOutOfSync;
        public bool? PermitGoingOutOfSync
        {
            get { return _permitGoingOutOfSync; }
            set { WithPermitGoingOutOfSync(value); }
        }

        private string _proxyDomain;
        public string ProxyDomain
        {
            get { return _proxyDomain; }
            set { WithProxyDomain(value); }
        }

        private string _proxyHost;
        public string ProxyHost
        {
            get { return _proxyHost; }
            set { WithProxyHost(value); }
        }

        private string _proxyPassword;
        public string ProxyPassword
        {
            get { return _proxyPassword; }
            set { WithProxyPassword(value); }
        }

        private int? _proxyPort;
        public int? ProxyPort
        {
            get { return _proxyPort; }
            set { WithProxyPort(value); }
        }

        private string _proxyUsername;
        public string ProxyUsername
        {
            get { return _proxyUsername; }
            set { WithProxyUsername(value); }
        }

        private Quiesced? _quiesced;
        public Quiesced? Quiesced
        {
            get { return _quiesced; }
            set { WithQuiesced(value); }
        }

        private S3Region? _region;
        public S3Region? Region
        {
            get { return _region; }
            set { WithRegion(value); }
        }

        private bool? _restrictedAccess;
        public bool? RestrictedAccess
        {
            get { return _restrictedAccess; }
            set { WithRestrictedAccess(value); }
        }

        private string _secretKey;
        public string SecretKey
        {
            get { return _secretKey; }
            set { WithSecretKey(value); }
        }

        private int? _stagedDataExpirationInDays;
        public int? StagedDataExpirationInDays
        {
            get { return _stagedDataExpirationInDays; }
            set { WithStagedDataExpirationInDays(value); }
        }

        
        public ModifyS3TargetSpectraS3Request WithAccessKey(string accessKey)
        {
            this._accessKey = accessKey;
            if (accessKey != null)
            {
                this.QueryParams.Add("access_key", accessKey);
            }
            else
            {
                this.QueryParams.Remove("access_key");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithAutoVerifyFrequencyInDays(int? autoVerifyFrequencyInDays)
        {
            this._autoVerifyFrequencyInDays = autoVerifyFrequencyInDays;
            if (autoVerifyFrequencyInDays != null)
            {
                this.QueryParams.Add("auto_verify_frequency_in_days", autoVerifyFrequencyInDays.ToString());
            }
            else
            {
                this.QueryParams.Remove("auto_verify_frequency_in_days");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithCloudBucketPrefix(string cloudBucketPrefix)
        {
            this._cloudBucketPrefix = cloudBucketPrefix;
            if (cloudBucketPrefix != null)
            {
                this.QueryParams.Add("cloud_bucket_prefix", cloudBucketPrefix);
            }
            else
            {
                this.QueryParams.Remove("cloud_bucket_prefix");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithCloudBucketSuffix(string cloudBucketSuffix)
        {
            this._cloudBucketSuffix = cloudBucketSuffix;
            if (cloudBucketSuffix != null)
            {
                this.QueryParams.Add("cloud_bucket_suffix", cloudBucketSuffix);
            }
            else
            {
                this.QueryParams.Remove("cloud_bucket_suffix");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithDataPathEndPoint(string dataPathEndPoint)
        {
            this._dataPathEndPoint = dataPathEndPoint;
            if (dataPathEndPoint != null)
            {
                this.QueryParams.Add("data_path_end_point", dataPathEndPoint);
            }
            else
            {
                this.QueryParams.Remove("data_path_end_point");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithDefaultReadPreference(TargetReadPreferenceType? defaultReadPreference)
        {
            this._defaultReadPreference = defaultReadPreference;
            if (defaultReadPreference != null)
            {
                this.QueryParams.Add("default_read_preference", defaultReadPreference.ToString());
            }
            else
            {
                this.QueryParams.Remove("default_read_preference");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithHttps(bool? https)
        {
            this._https = https;
            if (https != null)
            {
                this.QueryParams.Add("https", https.ToString());
            }
            else
            {
                this.QueryParams.Remove("https");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithName(string name)
        {
            this._name = name;
            if (name != null)
            {
                this.QueryParams.Add("name", name);
            }
            else
            {
                this.QueryParams.Remove("name");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithNamingMode(CloudNamingMode? namingMode)
        {
            this._namingMode = namingMode;
            if (namingMode != null)
            {
                this.QueryParams.Add("naming_mode", namingMode.ToString());
            }
            else
            {
                this.QueryParams.Remove("naming_mode");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithOfflineDataStagingWindowInTb(int? offlineDataStagingWindowInTb)
        {
            this._offlineDataStagingWindowInTb = offlineDataStagingWindowInTb;
            if (offlineDataStagingWindowInTb != null)
            {
                this.QueryParams.Add("offline_data_staging_window_in_tb", offlineDataStagingWindowInTb.ToString());
            }
            else
            {
                this.QueryParams.Remove("offline_data_staging_window_in_tb");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithPermitGoingOutOfSync(bool? permitGoingOutOfSync)
        {
            this._permitGoingOutOfSync = permitGoingOutOfSync;
            if (permitGoingOutOfSync != null)
            {
                this.QueryParams.Add("permit_going_out_of_sync", permitGoingOutOfSync.ToString());
            }
            else
            {
                this.QueryParams.Remove("permit_going_out_of_sync");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithProxyDomain(string proxyDomain)
        {
            this._proxyDomain = proxyDomain;
            if (proxyDomain != null)
            {
                this.QueryParams.Add("proxy_domain", proxyDomain);
            }
            else
            {
                this.QueryParams.Remove("proxy_domain");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithProxyHost(string proxyHost)
        {
            this._proxyHost = proxyHost;
            if (proxyHost != null)
            {
                this.QueryParams.Add("proxy_host", proxyHost);
            }
            else
            {
                this.QueryParams.Remove("proxy_host");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithProxyPassword(string proxyPassword)
        {
            this._proxyPassword = proxyPassword;
            if (proxyPassword != null)
            {
                this.QueryParams.Add("proxy_password", proxyPassword);
            }
            else
            {
                this.QueryParams.Remove("proxy_password");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithProxyPort(int? proxyPort)
        {
            this._proxyPort = proxyPort;
            if (proxyPort != null)
            {
                this.QueryParams.Add("proxy_port", proxyPort.ToString());
            }
            else
            {
                this.QueryParams.Remove("proxy_port");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithProxyUsername(string proxyUsername)
        {
            this._proxyUsername = proxyUsername;
            if (proxyUsername != null)
            {
                this.QueryParams.Add("proxy_username", proxyUsername);
            }
            else
            {
                this.QueryParams.Remove("proxy_username");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithQuiesced(Quiesced? quiesced)
        {
            this._quiesced = quiesced;
            if (quiesced != null)
            {
                this.QueryParams.Add("quiesced", quiesced.ToString());
            }
            else
            {
                this.QueryParams.Remove("quiesced");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithRegion(S3Region? region)
        {
            this._region = region;
            if (region != null)
            {
                this.QueryParams.Add("region", region.ToString());
            }
            else
            {
                this.QueryParams.Remove("region");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithRestrictedAccess(bool? restrictedAccess)
        {
            this._restrictedAccess = restrictedAccess;
            if (restrictedAccess != null)
            {
                this.QueryParams.Add("restricted_access", restrictedAccess.ToString());
            }
            else
            {
                this.QueryParams.Remove("restricted_access");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithSecretKey(string secretKey)
        {
            this._secretKey = secretKey;
            if (secretKey != null)
            {
                this.QueryParams.Add("secret_key", secretKey);
            }
            else
            {
                this.QueryParams.Remove("secret_key");
            }
            return this;
        }

        
        public ModifyS3TargetSpectraS3Request WithStagedDataExpirationInDays(int? stagedDataExpirationInDays)
        {
            this._stagedDataExpirationInDays = stagedDataExpirationInDays;
            if (stagedDataExpirationInDays != null)
            {
                this.QueryParams.Add("staged_data_expiration_in_days", stagedDataExpirationInDays.ToString());
            }
            else
            {
                this.QueryParams.Remove("staged_data_expiration_in_days");
            }
            return this;
        }


        
        
        public ModifyS3TargetSpectraS3Request(string s3Target)
        {
            this.S3Target = s3Target;
            
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
                return "/_rest_/s3_target/" + S3Target;
            }
        }
    }
}