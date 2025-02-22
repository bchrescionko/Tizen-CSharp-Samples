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

using System;
using Xamarin.Forms;

namespace Weather.Controls
{
    /// <summary>
    /// Custom Slider class.
    /// Slider shows only integer values.
    /// </summary>
    public class StepSlider : Slider
    {
        #region methods

        /// <summary>
        /// Default class constructor.
        /// </summary>
        public StepSlider()
        {
            ValueChanged += (s, e) => { Value = Math.Round(e.NewValue); };
        }

        #endregion
    }
}