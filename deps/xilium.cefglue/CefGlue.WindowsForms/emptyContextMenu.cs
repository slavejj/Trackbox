using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xilium.CefGlue;

namespace Xilium.CefGlue.WindowsForms
{
    internal sealed class emptyContextMenu : CefContextMenuHandler
    {
        protected override void OnBeforeContextMenu(CefBrowser browser, CefFrame frame, CefContextMenuParams state, CefMenuModel model)
        {
            model.Clear();
        }
    }
}
