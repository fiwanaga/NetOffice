﻿using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;

using NetOffice.Tools;
using NetOffice.OfficeApi.Enums;
using NetOffice.OutlookApi.Tools;

namespace Sample.Addin
{
    /// <summary>
    /// The main addin for MS-Word. The Addin use the base class COMAddin from NetOffice.WordApi.Tools.
    /// Learn more about the NetOffice Tools namespace: http://netoffice.codeplex.com/wikipage?title=Tools_EN
    /// </summary>
    [GuidAttribute("60875BD5-C5A5-4315-8954-BEEF3112DA82"), ProgId("Sample.TwitterAddin"), ComVisible(true)]
    [COMAddin("Outlook Twitter Addin", "This Addin provides Twitter functionality", 3)]
    public class ThisAddin : COMAddin
    {
        public ThisAddin()
        {
            NetOffice.DebugConsole.FileName = @"C:\LogFile.txt";
            NetOffice.DebugConsole.Mode = NetOffice.ConsoleMode.LogFile;

            // we create the taskpane
            TaskPanes.Add(typeof(TwitterPane), "Twitter - NetOffice Sample");
            TaskPanes[0].DockPosition = MsoCTPDockPosition.msoCTPDockPositionRight;
            TaskPanes[0].DockPositionRestrict = MsoCTPDockPositionRestrict.msoCTPDockPositionRestrictNoHorizontal;
            TaskPanes[0].Width = 300;
            TaskPanes[0].Visible = true;
        }
    }
}
