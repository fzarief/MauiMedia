﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using CommunityToolkit.Mvvm.ComponentModel;
using MauiMedia.Model;
using MauiMedia.Primitives;

namespace MauiMedia.Services;

public partial class VideoOnNavigated : ObservableObject
{
    [ObservableProperty]
    private Show _currentShow;
    [ObservableProperty]
    private string _title;
    public EventHandler<VideoNavigationEventArgs> Navigation { get; set; }
    public VideoOnNavigated()
    {
        CurrentShow = new();
    }
    public void Add(Show show)
    {
        var args = new VideoNavigationEventArgs
        {
            CurrentShow = show,
            Title = show.Title
        };
        OnVideoNavigation(args);
    }
    protected virtual void OnVideoNavigation(VideoNavigationEventArgs args)
    {
        Navigation?.Invoke(this, args);
    }
}
