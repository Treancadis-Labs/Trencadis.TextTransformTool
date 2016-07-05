// ---------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="ITextTransformationsFactory.cs" company="Trencadis">
// Copyright (c) 2016, Trencadis, All rights reserved
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------------------------

namespace Trencadis.Tools.TextTransformations.Factories
{
    using System.Collections.Generic;

    /// <summary>
    /// Abstracts a factory that can create a collection of text transformations
    /// </summary>
    public interface ITextTransformationsFactory
    {
        /// <summary>
        /// Creates a collection of text transformations
        /// </summary>
        /// <returns>A collection of text transformations</returns>
        IEnumerable<ITextTransformation> CreateTextTransformations();
    }
}
