﻿namespace Xilium.CefGlue.WindowsForms
{
    using System;
    using System.Collections.Generic;
    using Xilium.CefGlue;

    internal sealed class CefWebClient : CefClient
    {
        private readonly CefWebBrowser _core;
        private readonly CefWebLifeSpanHandler _lifeSpanHandler;
        private readonly CefWebDisplayHandler _displayHandler;
        private emptyContextMenu _emptyContextMenu;
        

        public CefWebClient(CefWebBrowser core)
        {
            _core = core;
            _lifeSpanHandler = new CefWebLifeSpanHandler(_core);
            _displayHandler = new CefWebDisplayHandler(_core);
            _emptyContextMenu = new emptyContextMenu();
        }

        protected override CefLifeSpanHandler GetLifeSpanHandler()
        {
            return _lifeSpanHandler;
        }

        protected override CefDisplayHandler GetDisplayHandler()
        {
            return _displayHandler;
        }

        protected override CefContextMenuHandler GetContextMenuHandler()
        {
            return _emptyContextMenu;
        }


    }
}
