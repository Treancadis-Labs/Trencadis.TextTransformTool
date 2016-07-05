// ---------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="RemoveXmlNodeTextTransformation.cs" company="Trencadis">
// Copyright (c) 2016, Trencadis, All rights reserved
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------------------------

namespace Trencadis.Tools.TextTransformations.Transformations.Xml
{
    using System;
    using System.Xml.Linq;
    using System.Xml.XPath;

    using Trencadis.Tools.TextTransformations.Extensions;

    /// <summary>
    /// Removes xml nodes matched by an xpath expression when the input is a xml document or fragment. 
    /// Concrete implementation if <see cref="ITextTransformation"/>
    /// </summary>
    public class RemoveXmlNodeTextTransformation : ITextTransformation
    {
        /// <summary>
        /// Holds the xpath expression that identifies the nodes to be removed
        /// </summary>
        private readonly string xpath;

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveXmlNodeTextTransformation"/>
        /// </summary>
        /// <param name="xpath">The xpath expression that identifies the nodes to be removed</param>
        public RemoveXmlNodeTextTransformation(string xpath)
        {
            if (string.IsNullOrEmpty(xpath))
            {
                throw new ArgumentNullException("xpath");
            }

            this.xpath = xpath;
        }

        /// <summary>
        /// Transforms the input text by removing the xml nodes that match a xpath expression
        /// </summary>
        /// <param name="input">The input text (must be a xml document / fragment in order that any transformation to occur)</param>
        /// <returns>The transformation result</returns>
        public string ApplyTransformation(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            XDocument xml;
            if ((!input.IsXml(out xml)) || (xml == null))
            {
                return input;
            }

            var nodes = xml.XPathSelectElements(this.xpath);
            if (nodes != null)
            {
                nodes.Remove();
            }

            return xml.ToStringWithDeclaration(SaveOptions.DisableFormatting);
        }
    }
}
