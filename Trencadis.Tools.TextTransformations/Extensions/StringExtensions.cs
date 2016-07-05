// ---------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="Trencadis">
// Copyright (c) 2016, Trencadis, All rights reserved
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------------------------

namespace Trencadis.Tools.TextTransformations.Extensions
{
    using System.Xml.Linq;

    /// <summary>
    /// String extension methods
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Returns a flag indicating whether the specified text represents a valid xml document or fragment
        /// </summary>
        /// <param name="text">The text to check</param>
        /// <returns>True if the text represents a xml document or fragment, false otherwise</returns>
        public static bool IsXml(this string text)
        {
            XDocument xmlElement;
            return text.IsXml(out xmlElement);
        }

        /// <summary>
        /// Returns a flag indicating whether the specified text represents a valid xml document or fragment
        /// </summary>
        /// <param name="text">The text to check</param>
        /// <param name="xmlDocument">Output parameter: the parsed xml element</param>
        /// <returns>True if the text represents a xml document or fragment, false otherwise</returns>
        public static bool IsXml(this string text, out XDocument xmlDocument)
        {
            xmlDocument = null;

            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            var trimmedText = text.Trim();

            if (!trimmedText.StartsWith("<"))
            {
                return false;
            }

            if (!trimmedText.EndsWith(">"))
            {
                return false;
            }

            try
            {
                xmlDocument = XDocument.Parse(text, LoadOptions.PreserveWhitespace);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
