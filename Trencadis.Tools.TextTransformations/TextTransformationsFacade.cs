// ---------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="TextTransformationsFacade.cs" company="Trencadis">
// Copyright (c) 2016, Trencadis, All rights reserved
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------------------------

namespace Trencadis.Tools.TextTransformations
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml.Linq;

    using Trencadis.Tools.TextTransformations.Factories;

    /// <summary>
    /// Facade class for xml transformations
    /// </summary>
    public static class TextTransformationsFacade
    {
        /// <summary>
        /// Creates a collection of text transformations from the specified xml file
        /// </summary>
        /// <param name="path">The path to xml file (holds text transformations configuration)</param>
        /// <returns>A collection of text transformations</returns>
        public static IEnumerable<ITextTransformation> CreateFromXmlFile(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return Enumerable.Empty<ITextTransformation>();
            }

            if (!File.Exists(path))
            {
                return Enumerable.Empty<ITextTransformation>();
            }

            var xmlDocument = XDocument.Load(path);

            var elements = xmlDocument
                .Root
                .DescendantNodes()
                .OfType<XElement>();

            var xmlTextTransformations = new XmlTextTransformationsFactory(elements);

            return xmlTextTransformations.CreateTextTransformations();
        }

        /// <summary>
        /// Creates a collection of text transformations from the specified xml content
        /// </summary>
        /// <param name="xml">The xml content (holds text transformations configuration)</param>
        /// <returns>A collection of text transformations</returns>
        public static IEnumerable<ITextTransformation> CreateFromXmlContent(string xml)
        {
            if (string.IsNullOrWhiteSpace(xml))
            {
                return Enumerable.Empty<ITextTransformation>();
            }

            var xmlFragment = XElement.Parse(xml);

            var elements = xmlFragment
               .DescendantsAndSelf()
               .OfType<XElement>();

            var xmlTextTransformations = new XmlTextTransformationsFactory(elements);

            return xmlTextTransformations.CreateTextTransformations();
        }
    }
}
