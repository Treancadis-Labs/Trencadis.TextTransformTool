// ---------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="RegexReplaceTextTransformation.cs" company="Trencadis">
// Copyright (c) 2016, Trencadis, All rights reserved
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------------------------

namespace Trencadis.Tools.TextTransformations.Transformations.Regex
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Regex replace based text transformation. Concrete implementation if <see cref="ITextTransformation"/>
    /// </summary>
    public class RegexReplaceTextTransformation : ITextTransformation
    {
        /// <summary>
        /// Holds the replacement for the pattern-matched text
        /// </summary>
        private readonly string replacement;

        /// <summary>
        /// Holds the regex expression
        /// </summary>
        private readonly Regex regex;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexReplaceTextTransformation"/> class
        /// </summary>
        /// <param name="pattern">The pattern to search for</param>
        /// <param name="replacement">The replacement string</param>
        public RegexReplaceTextTransformation(string pattern, string replacement)
        {
            if (pattern == null)
            {
                throw new ArgumentNullException("pattern");
            }

            if (replacement == null)
            {
                throw new ArgumentNullException("pattern");
            }

            this.replacement = replacement;

            this.regex = new Regex(pattern);
        }

        /// <summary>
        /// Transforms the input text using a regex-replace and returns result
        /// </summary>
        /// <param name="input">The input text</param>
        /// <returns>The transformation result</returns>
        public string ApplyTransformation(string input)
        {
            if (input == null)
            {
                return input;
            }

            var result = this.regex.Replace(input, this.replacement);

            return result;
        }
    }
}
