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

namespace Ds3.Helpers
{
    class Ds3ClientFactory : IDs3ClientFactory
    {
        private readonly IDs3Client _client;

        public Ds3ClientFactory(IDs3Client client)
        {
            this._client = client;
        }

        public IDs3Client GetClientForServerId(string serverId)
        {
            //TODO: this needs to return a client that connects to the specified server id.
            return this._client;
        }
    }
}