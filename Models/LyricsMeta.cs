﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GminorApi.Models
{


    public class LyricsMeta
    {
        private string lyrics = string.Empty;
        private string script_tracking_url = string.Empty;
        private string lyrics_copyright = string.Empty;
        private string snippet = string.Empty;

        public string Script_tracking_url { get => script_tracking_url; set => script_tracking_url = value; }
        public string Lyrics_copyright { get => lyrics_copyright; set => lyrics_copyright = value; }
        public string Snippet { get => snippet; set => snippet = value; }
        public string Lyrics { get => lyrics; set => lyrics = value; }
    }
}