﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;

namespace System.Windows.Forms.Tests
{
    public class ToolStripDropDownItemAccessibleObjectTests
    {
        [WinFormsFact]
        public void ToolStripDropDownItemAccessibleObject_Ctor_OwnerToolStripDropDownItemCannotBeNull()
        {
            Assert.Throws<ArgumentNullException>(() => new ToolStripDropDownItemAccessibleObject(null));
        }
    }
}
