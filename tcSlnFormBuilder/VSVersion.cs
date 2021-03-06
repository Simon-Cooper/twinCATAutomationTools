﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcSlnFormBuilder
{
    public class VSVersion
    {
        public static readonly VSVersion VS_2010 = new VSVersion("VisualStudio.DTE.10.0");
        public static readonly VSVersion VS_2012 = new VSVersion("VisualStudio.DTE.11.0");
        public static readonly VSVersion VS_2013 = new VSVersion("VisualStudio.DTE.12.0");
        public static readonly VSVersion VS_2015 = new VSVersion("VisualStudio.DTE.14.0");
        public static readonly VSVersion VS_2017 = new VSVersion("VisualStudio.DTE.15.0");
        public static readonly VSVersion VS_2019 = new VSVersion("VisualStudio.DTE.16.0");
        public static readonly VSVersion TWINCAT_SHELL = new VSVersion("TcXaeShell.DTE.15.0");

        public String DTEDesc;
        private VSVersion(String DTEDesc)
        {
            this.DTEDesc = DTEDesc;
        }
        public static String ReturnVersion(string appID)
        {
            switch (appID)
            {
                case "VS_2010":
                    return VSVersion.VS_2010.DTEDesc;
                case "VS_2012":
                    return VSVersion.VS_2012.DTEDesc;
                case "VS_2013":
                    return VSVersion.VS_2013.DTEDesc;
                case "VS_2015":
                    return VSVersion.VS_2015.DTEDesc;
                case "VS_2017":
                    return VSVersion.VS_2017.DTEDesc;
                case "VS_2019":
                    return VSVersion.VS_2019.DTEDesc;
                case "TWINCAT_SHELL":
                    return VSVersion.TWINCAT_SHELL.DTEDesc;
                default:
                    return VSVersion.TWINCAT_SHELL.DTEDesc;
            }
        }

    }
}
