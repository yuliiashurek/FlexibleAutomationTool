using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.Interpretator
{
    public interface IExpressions
    {
        public Task InterpratAsync(Context context);
    }
}
