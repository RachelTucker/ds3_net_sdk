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
using System.IO;

using Ds3.Models;
using Ds3.Calls;

namespace Ds3.Helpers
{
    public delegate Stream ObjectPutter(Ds3Object ds3Object);
    public delegate void ObjectGetter(Ds3Object ds3Object, Stream inputStream);

    public interface IJob
    {
        Guid JobId { get; }
        string BucketName { get; }
    }

    public interface IWriteJob : IJob
    {
        void Write(ObjectPutter putter);
        IWriteJob WithRequestModifier(ModifyPutRequest modifier);
    }

    public interface IReadJob : IJob
    {
        void Read(ObjectGetter getter);
        IReadJob WithRequestModifier(ModifyGetRequest modifier);
    }

    public delegate void ModifyGetRequest(GetObjectRequest request);
    public delegate void ModifyPutRequest(PutObjectRequest request);
}