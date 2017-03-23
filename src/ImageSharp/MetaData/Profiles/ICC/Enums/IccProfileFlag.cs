﻿// <copyright file="IccProfileFlag.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp
{
    using System;

    /// <summary>
    /// Profile flags. Can be combined with a logical OR
    /// </summary>
    [Flags]
    internal enum IccProfileFlag : int
    {
        /// <summary>
        /// Profile is embedded within another file
        /// </summary>
        Embedded = 1 << 31,

        /// <summary>
        /// Profile cannot be used independently of the embedded colour data
        /// </summary>
        Independent = 1 << 30,
    }
}