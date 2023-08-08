﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using SQLite;

namespace NerdNewsNavigator2.Model;

/// <summary>
/// <c>Show</c> is a Class for storing Shows
/// </summary>
[Table("AllShows")]
public partial class Show : Shared
{
    [ObservableProperty]
    private bool _isDownloading;
    [ObservableProperty]
    private string _status;
}
