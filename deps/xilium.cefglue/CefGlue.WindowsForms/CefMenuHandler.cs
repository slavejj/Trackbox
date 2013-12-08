namespace Xilium.CefGlue.WindowsForms
{
    internal sealed class CefMenuHandler : CefContextMenuHandler
    {
        protected override void OnBeforeContextMenu(CefBrowser browser, CefFrame frame, CefContextMenuParams state, CefMenuModel model)
        {
            model.Clear();
        }
    }
}
