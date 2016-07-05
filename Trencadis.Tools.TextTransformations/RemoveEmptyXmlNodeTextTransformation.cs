// ---------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="RemoveEmptyXmlNodeTextTransformation.cs" company="Trencadis">
// Copyright (c) 2016, Trencadis, All rights reserved
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------------------------

namespace Trencadis.Tools.TextTransformations
{
    using System.Linq;
    using System.Xml.Linq;

    using Trencadis.Tools.TextTransformations.Extensions;

    /// <summary>
    /// Removes empty xml nodes when the input is a xml document or fragment. 
    /// Concrete implementation if <see cref="ITextTransformation"/>
    /// </summary>
    public class RemoveEmptyXmlNodeTextTransformation : ITextTransformation
    {
        /// <summary>
        /// Transforms the input text by removing the empty xml nodes
        /// </summary>
        /// <param name="input">The input text (must be a xml document / fragment in order that any transformation to occur)</param>
        /// <returns>The transformation result</returns>
        public string ApplyTransformation(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            XElement xml;
            if ((!input.IsXml(out xml)) || (xml == null))
            {
                return input;
            }

            var emptyNodes = xml
                .Descendants()
                .Where(x => (!x.HasElements) && (!x.HasAttributes) && (string.IsNullOrWhiteSpace(x.Value)));

            if (emptyNodes != null)
            {
                emptyNodes.Remove();
            }

            return xml.ToString(SaveOptions.DisableFormatting);
        }
    }
}
