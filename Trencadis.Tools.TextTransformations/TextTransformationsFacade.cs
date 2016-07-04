using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Trencadis.Tools.TextTransformations.Factories;

namespace Trencadis.Tools.TextTransformations
{
    public static class TextTransformationsFacade
    {
        public static IEnumerable<ITextTransformation> CreateFromXmlFile(string path)
        {
            if(string.IsNullOrEmpty(path))
            {
                return Enumerable.Empty<ITextTransformation>();
            }

            if(!File.Exists(path))
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

        public static IEnumerable<ITextTransformation> CreateFromXmlContent(string xml)
        {
            if(string.IsNullOrWhiteSpace(xml))
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
