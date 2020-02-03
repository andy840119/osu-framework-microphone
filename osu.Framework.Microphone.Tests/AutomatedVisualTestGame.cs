﻿// Copyright (c) andy840119 <andy840119@gmail.com>. Licensed under the GPL Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Testing;

namespace osu.Framework.Tests
{
    internal class AutomatedVisualTestGame : TestGame
    {
        public AutomatedVisualTestGame()
        {
            Add(new TestBrowserTestRunner(new TestBrowser()));
        }
    }
}
