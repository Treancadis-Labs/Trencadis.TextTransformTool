using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trencadis.Tools.TextTransformations
{
    public static class TextTransformationsRunner
    {
        public static string RunTransformations(string input, IEnumerable<ITextTransformation> transformations)
        {
            var result = input;

            if (transformations != null)
            {
                foreach (ITextTransformation transformation in transformations)
                {
                    result = transformation.ApplyTransformation(result);
                }
            }

            return result;
        }
    }
}
