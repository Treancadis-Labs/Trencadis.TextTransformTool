// ---------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="TextTransformationsRunner.cs" company="Trencadis">
// Copyright (c) 2016, Trencadis, All rights reserved
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------------------------

namespace Trencadis.Tools.TextTransformations
{
    using System.Collections.Generic;

    /// <summary>
    /// Runner for text transformations
    /// </summary>
    public static class TextTransformationsRunner
    {
        /// <summary>
        /// Runs a collection of text transformations over the specified input and returns the result
        /// </summary>
        /// <param name="input">The initial input text</param>
        /// <param name="transformations">The collection of text transformations to run</param>
        /// <returns>The result of the text transformations</returns>
        public static string RunTransformations(string input, IEnumerable<ITextTransformation> transformations)
        {
            var result = input;

            if (transformations != null)
            {
                foreach (ITextTransformation transformation in transformations)
                {
                    result = transformation.ApplyTransformation(result);
                }
            }

            return result;
        }
    }
}
