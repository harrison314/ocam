using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocam
{
    interface IPageProcessor
    {
        PageTemplate<PageModel> ProcessFile(string src, string dst, string name, PageModel model, StartTemplate<StartModel> startTemplate, Action<string, string> writer);
    }
}
