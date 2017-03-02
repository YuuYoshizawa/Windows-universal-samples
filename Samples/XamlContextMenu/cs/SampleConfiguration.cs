//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace SDKTemplate
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "XAML Context Menu";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title="ContextFlyout on an element", ClassType=typeof(Scenario1)},
            new Scenario() { Title="ContextFlyout in ListView", ClassType=typeof(Scenario2)},
            new Scenario() { Title="ContextRequested event", ClassType=typeof(Scenario3)},
        };
    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}
