﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.ObjectModel;
using Microsoft.PowerToys.Settings.UI.Library;

namespace ColorPicker.Settings
{
    public interface IUserSettings
    {
        SettingItem<string> ActivationShortcut { get; }

        SettingItem<bool> ChangeCursor { get; }

        SettingItem<ColorRepresentationType> CopiedColorRepresentation { get; set; }

        SettingItem<bool> UseEditor { get; }

        ObservableCollection<string> ColorHistory { get; }

        SettingItem<int> ColorHistoryLimit { get; }
    }
}
