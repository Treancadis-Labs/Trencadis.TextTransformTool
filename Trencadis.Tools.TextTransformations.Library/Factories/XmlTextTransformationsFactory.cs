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

            var pattern = element.Attribute("pattern");

            var replacement = element.Attribute("replacement");

            if ((pattern != null) && (!string.IsNullOrEmpty(pattern.Value)) && (replacement != null) && (!string.IsNullOrEmpty(replacement.Value)))
            {
                var transformation = new RegexReplaceTextTransformation(pattern.Value, replacement.Value);

                return transformation;
            }

            return null;
        }

        protected virtual ITextTransformation CreateStringReplaceTextTransformation(XElement element)
        {
            var pattern = element.Attribute("pattern");

            var replacement = element.Attribute("replacement");

            if ((pattern != null) && (!string.IsNullOrEmpty(pattern.Value)) && (replacement != null) && (!string.IsNullOrEmpty(replacement.Value)))
            {
                var transformation = new StringReplaceTextTransformation(pattern.Value, replacement.Value);

                return transformation;
            }

            return null;
        }
    }
}
