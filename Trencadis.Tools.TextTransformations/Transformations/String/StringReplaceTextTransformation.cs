// ---------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="StringReplaceTextTransformation.cs" company="Trencadis">
// Copyright (c) 2016, Trencadis, All rights reserved
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------------------------

namespace Trencadis.Tools.TextTransformations.Transformations.String
{
    using System;

    /// <summary>
    /// String replace based text transformation. Concrete implementation if <see cref="ITextTransformation"/>
    /// </summary>
    public class StringReplaceTextTransformation : ITextTransformation
    {
        /// <summary>
        /// Holds the text to search (pattern)
        /// </summary>
        private readonly string pattern;

        /// <summary>
        /// Holds the replacement for the matched text
        /// </summary>
        private readonly string replacement;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringReplaceTextTransformation"/> class
        /// </summary>
        /// <param name="pattern">The search string (pattern)</param>
        /// <param name="replacement">The replacement string</param>
        public StringReplaceTextTransformation(string pattern, string replacement)
        {
            if (pattern == null)
            {
                throw new ArgumentNullException("pattern");
            }

            this.pattern = pattern;

            this.replacement = replacement;
        }

        /// <summary>
        /// Transforms the input text using a string-replace and returns result
        /// </summary>
        /// <param name="input">The input text</param>
        /// <returns>The transformation result</returns>
        public string ApplyTransformation(string input)
        {
            if (input == null)
            {
                return input;
            }

            var result = input.Replace(this.pattern, this.replacement);

            return result;
        }
    }
}
