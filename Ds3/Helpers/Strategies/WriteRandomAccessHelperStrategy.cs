﻿/*
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

using Ds3.Helpers.Strategies.ChunkStrategies;
using Ds3.Helpers.Strategies.StreamFactory;

namespace Ds3.Helpers.Strategies
{
    /// <summary>
    /// The WriteRandomAccessHelperStrategy bundle WriteRandomAccessChunkStrategy with WriteRandomAccessStreamFactory
    /// </summary>
    public class WriteRandomAccessHelperStrategy : IHelperStrategy<string>
    {
        private readonly IChunkStrategy _writeRandomAccessChunkStrategy;
        private readonly IStreamFactory<string> _writeRandomAccessStreamFactory;

        public WriteRandomAccessHelperStrategy(int retryAfter = -1, bool withAggregation = false)
        {
            this._writeRandomAccessChunkStrategy = new WriteRandomAccessChunkStrategy(retryAfter, withAggregation);
            this._writeRandomAccessStreamFactory = new WriteRandomAccessStreamFactory();
        }

        public IChunkStrategy GetChunkStrategy()
        {
            return this._writeRandomAccessChunkStrategy;
        }

        public IStreamFactory<string> GetStreamFactory()
        {
            return this._writeRandomAccessStreamFactory;
        }
    }
}