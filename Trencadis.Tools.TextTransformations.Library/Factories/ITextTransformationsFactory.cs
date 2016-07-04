using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trencadis.Tools.TextTransformations.Factories
{
    public interface ITextTransformationsFactory
    {
        IEnumerable<ITextTransformation> CreateTextTransformations();
    }
}
