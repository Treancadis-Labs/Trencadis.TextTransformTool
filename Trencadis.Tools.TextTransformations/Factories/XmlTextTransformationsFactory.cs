// ---------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="XmlTextTransformationsFactory.cs" company="Trencadis">
// Copyright (c) 2016, Trencadis, All rights reserved
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------------------------

namespace Trencadis.Tools.TextTransformations.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Linq;

    using Trencadis.Tools.TextTransformations.Transformations.Regex;
    using Trencadis.Tools.TextTransformations.Transformations.String;
    using Trencadis.Tools.TextTransformations.Transformations.Xml;

    /// <summary>
    /// Factory class, creates <see cref="ITextTransformationsFactory"/> instances based on the configuration xml
    /// </summary>
    public class XmlTextTransformationsFactory : ITextTransformationsFactory
    {
        /// <summary>
        /// Holds the xml elements that specify text transformations config
        /// </summary>
        private readonly IEnumerable<XElement> elements;

        /// <summary>
        /// Initializes a new instance of the <see cref="XmlTextTransformationsFactory"/> class
        /// </summary>
        /// <param name="elements">The xml elements that specify text transformations config</param>
        public XmlTextTransformationsFactory(IEnumerable<XElement> elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("elements");
            }

            this.elements = elements;
        }

        /// <summary>
        /// Creates and returns the list of text transformations that correspond to the given xml configuration
        /// </summary>
        /// <returns>The list of text transformations</returns>
        public IEnumerable<ITextTransformation> CreateTextTransformations()
        {
            var result = new List<ITextTransformation>();

            foreach (var element in this.elements)
            {
                var transformation = this.CreateTransformationForElement(element);
                if (transformation != null)
                {
                    result.Add(transformation);
                }
            }

            return result;
        }

        /// <summary>
        /// Creates an instance of <see cref="ITextTransformation"/> based on the xml element configuration
        /// </summary>
        /// <param name="element">The xml element specifying the text transformation to create</param>
        /// <returns>An instance of <see cref="ITextTransformation"/></returns>
        protected virtual ITextTransformation CreateTransformationForElement(XElement element)
        {
            if (element == null)
            {
                return null;
            }

            var tagName = element.Name.ToString();

            if (string.Equals(tagName, typeof(RegexReplaceTextTransformation).Name, StringComparison.OrdinalIgnoreCase))
            {
                return CreateRegexReplaceTextTransformation(element);
            }
            else if (string.Equals(tagName, typeof(StringReplaceTextTransformation).Name, StringComparison.OrdinalIgnoreCase))
            {
                return CreateStringReplaceTextTransformation(element);
            }
            else if (string.Equals(tagName, typeof(RemoveXmlNodeTextTransformation).Name, StringComparison.OrdinalIgnoreCase))
            {
                return CreateRemoveXmlNodeTextTransformation(element);
            }
            else if (string.Equals(tagName, typeof(RemoveEmptyXmlNodeTextTransformation).Name, StringComparison.OrdinalIgnoreCase))
            {
                return CreateRemoveEmptyXmlNodeTextTransformation(element);
            }

            return null;
        }

        /// <summary>
        /// Creates an instance of <see cref="RegexReplaceTextTransformation"/> based on the xml element configuration
        /// </summary>
        /// <param name="element">The xml element specifying the text transformation configuration</param>
        /// <returns>An instance of <see cref="RegexReplaceTextTransformation"/></returns>
        protected virtual ITextTransformation CreateRegexReplaceTextTransformation(XElement element)
        {
            if (element == null)
            {
                return null;
            }

            var pattern = ReadAttributeOrChildElementValue(element, "pattern");

            var replacement = ReadAttributeOrChildElementValue(element, "replacement");

            if ((!string.IsNullOrEmpty(pattern)) && (!string.IsNullOrEmpty(replacement)))
            {
                var transformation = new RegexReplaceTextTransformation(pattern, replacement);

                return transformation;
            }

            return null;
        }

        /// <summary>
        /// Creates an instance of <see cref="StringReplaceTextTransformation"/> based on the xml element configuration
        /// </summary>
        /// <param name="element">The xml element specifying the text transformation configuration</param>
        /// <returns>An instance of <see cref="StringReplaceTextTransformation"/></returns>
        protected virtual ITextTransformation CreateStringReplaceTextTransformation(XElement element)
        {
            if (element == null)
            {
                return null;
            }

            var pattern = ReadAttributeOrChildElementValue(element, "pattern");

            var replacement = ReadAttributeOrChildElementValue(element, "replacement");

            if ((!string.IsNullOrEmpty(pattern)) && (!string.IsNullOrEmpty(replacement)))
            {
                var transformation = new StringReplaceTextTransformation(pattern, replacement);

                return transformation;
            }

            return null;
        }

        /// <summary>
        /// Creates an instance of <see cref="RemoveXmlNodeTextTransformation"/> based on the xml element configuration
        /// </summary>
        /// <param name="element">The xml element specifying the text transformation configuration</param>
        /// <returns>An instance of <see cref="RemoveXmlNodeTextTransformation"/></returns>
        protected virtual ITextTransformation CreateRemoveXmlNodeTextTransformation(XElement element)
        {
            if (element == null)
            {
                return null;
            }

            var xpath = ReadAttributeOrChildElementValue(element, "xpath");

            if (!string.IsNullOrEmpty(xpath))
            {
                var transformation = new RemoveXmlNodeTextTransformation(xpath);

                return transformation;
            }

            return null;
        }

        /// <summary>
        /// Creates an instance of <see cref="RemoveEmptyXmlNodeTextTransformation"/> based on the xml element configuration
        /// </summary>
        /// <param name="element">The xml element specifying the text transformation configuration</param>
        /// <returns>An instance of <see cref="RemoveEmptyXmlNodeTextTransformation"/></returns>
        protected virtual ITextTransformation CreateRemoveEmptyXmlNodeTextTransformation(XElement element)
        {
            if (element == null)
            {
                return null;
            }

            var transformation = new RemoveEmptyXmlNodeTextTransformation();

            return transformation;
        }

        /// <summary>
        /// Tries to read the value from the specified attribute, or child xml element if no attribute can be found with the specified name
        /// </summary>
        /// <param name="element">The "parent" xml element</param>
        /// <param name="attributeOrElementName">The attribute name, or child element name</param>
        /// <returns>The value from the specified attribute or child xml element</returns>
        protected string ReadAttributeOrChildElementValue(XElement element, string attributeOrElementName)
        {
            if (element == null)
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(attributeOrElementName))
            {
                return null;
            }

            var attribute = element.Attribute(attributeOrElementName);
            if (attribute != null)
            {
                return attribute.Value;
            }

            var innerElement = element.Element(attributeOrElementName);
            if (innerElement != null)
            {
                return innerElement.Value;
            }

            return null;
        }
    }
}
