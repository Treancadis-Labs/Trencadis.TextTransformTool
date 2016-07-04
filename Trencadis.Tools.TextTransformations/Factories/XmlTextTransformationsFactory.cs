using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Trencadis.Tools.TextTransformations.Factories
{
    public class XmlTextTransformationsFactory : ITextTransformationsFactory
    {
        private readonly IEnumerable<XElement> elements;

        public XmlTextTransformationsFactory(IEnumerable<XElement> elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("elements");
            }

            this.elements = elements;
        }

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

            return null;
        }

        protected virtual ITextTransformation CreateRegexReplaceTextTransformation(XElement element)
        {
            if (element == null)
            {
                return null;
            }

            var pattern = ReadAttributeOrInnerElementValue(element, "pattern");

            var replacement = ReadAttributeOrInnerElementValue(element, "replacement");

            if ((!string.IsNullOrEmpty(pattern)) && (!string.IsNullOrEmpty(replacement)))
            {
                var transformation = new RegexReplaceTextTransformation(pattern, replacement);

                return transformation;
            }

            return null;
        }

        protected virtual ITextTransformation CreateStringReplaceTextTransformation(XElement element)
        {
            if (element == null)
            {
                return null;
            }

            var pattern = ReadAttributeOrInnerElementValue(element, "pattern");

            var replacement = ReadAttributeOrInnerElementValue(element, "replacement");

            if ((!string.IsNullOrEmpty(pattern)) && (!string.IsNullOrEmpty(replacement)))
            {
                var transformation = new StringReplaceTextTransformation(pattern, replacement);

                return transformation;
            }

            return null;
        }

        protected string ReadAttributeOrInnerElementValue(XElement element, string attributeOrElementName)
        {
            if(element == null)
            {
                return null;
            }

            if(string.IsNullOrWhiteSpace(attributeOrElementName))
            {
                return null;
            }

            var attribute = element.Attribute(attributeOrElementName);
            if(attribute != null)
            {
                return attribute.Value;
            }

            var innerElement = element.Element(attributeOrElementName);
            if(innerElement != null)
            {
                return innerElement.Value;
            }

            return null;
        }
    }
}
