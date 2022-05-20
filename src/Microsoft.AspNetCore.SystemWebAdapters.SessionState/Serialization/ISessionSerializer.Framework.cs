// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Microsoft.AspNetCore.SystemWebAdapters.SessionState.Serialization;

public interface ISessionSerializer
{
    Task DeserializeToAsync(Stream stream, HttpSessionStateBase state, CancellationToken token);

    Task SerializeAsync(HttpSessionStateBase state, Stream stream, CancellationToken token);

    byte[] Serialize(string key, object value);

    object? Deserialize(string key, Memory<byte> bytes);
}