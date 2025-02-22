﻿/*
 * Copyright (c) 2021 Samsung Electronics Co., Ltd. All rights reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Alarms.ViewModels;
using System;

namespace Alarms.Tizen.Mobile.Views
{
    /// <summary>
    /// NoAlarmsPage Xaml C# partial class code.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoAlarmsPage : ContentPage
    {
        #region methods

        /// <summary>
        /// Class constructor with component initialization (Xaml partial).
        /// </summary>
        public NoAlarmsPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates to the AppSelectPage.
        /// </summary>
        /// <param name="sender">Object firing the event.</param>
        /// <param name="e">Event arguments.</param>
        private void AddNewAlarm(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AppSelectPage());
        }

        #endregion
    }
}
