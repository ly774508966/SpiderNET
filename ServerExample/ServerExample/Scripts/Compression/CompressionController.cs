﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ServerExample.Scripts.Compression
{
    public class CompressionController : Controller
    {
        [CompressFilter]
        public string GET_KEY(string version)
        {
            return "version=" + version;
        }

        [CompressFilter]
        public string LOGIN(string udid, byte platform)
        {
            return "udid=" + udid + "&platform=" + platform;
        }
    }
}
