// ---------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="XDocumentExtensions.cs" company="Trencadis">
// Copyright (c) 2016, Trencadis, All rights reserved
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------------------------

namespace Trencadis.Tools.TextTransformations.Extensions
{
    using System;
    using System.Xml.Linq;

    /// <summary>
    /// Extension methods for <see cref="XDocument"/>
    /// </summary>
    public static class XDocumentExtensions
    {
        /// <summary>
        /// Saves the <see cref="XDocument"/> instance to string including also xml declaration if present
        /// </summary>
        /// <param name="xml">The xml document</param>
        /// <param name="options">The xml save options</param>
        /// <returns>The xml string holding the document content</returns>
        public static string ToStringWithDeclaration(this XDocument xml, SaveOptions options)
        {
            if (xml == null)
            {
                return string.Empty;
            }

            return ((xml.Declaration != null) ? xml.Declaration.ToString() : string.Empty) + xml.ToString(options);
        }
    }
}
