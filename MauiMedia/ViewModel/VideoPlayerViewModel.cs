﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MauiMedia.ViewModel;

/// <summary>
/// A class that inherits from <see cref="BaseViewModel"/> and manages <see cref="VideoPlayerViewModel"/>
/// </summary>
public partial class VideoPlayerViewModel : BaseViewModel
{

    /// <summary>
    /// Initializes a new instance of the <see cref="VideoPlayerViewModel"/> class.
    /// </summary>
    public VideoPlayerViewModel(IConnectivity connectivity) : base(connectivity)
    {
    }
}
