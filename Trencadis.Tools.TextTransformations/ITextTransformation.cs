// ---------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="ITextTransformation.cs" company="Trencadis">
// Copyright (c) 2016, Trencadis, All rights reserved
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------------------------

namespace Trencadis.Tools.TextTransformations
{
    /// <summary>
    /// Abstracts a text transformation over an input string
    /// </summary>
    public interface ITextTransformation
    {
        /// <summary>
        /// Transforms the input text and returns result
        /// </summary>
        /// <param name="input">The input text</param>
        /// <returns>The transformation result</returns>
        string ApplyTransformation(string input);
    }
}
