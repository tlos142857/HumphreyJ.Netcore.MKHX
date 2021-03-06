﻿using System;
using System.Collections.Generic;

namespace HumphreyJ.NetCore.MKHX.DataBase
{
    public partial class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Keywords { get; set; }
        public string Type { get; set; }
        public string Server { get; set; }
        public string Thumbnail { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime EditTime { get; set; }
        public DateTime AccessTime { get; set; }
        public int AccessCount { get; set; }
        public string Content { get; set; }
    }
}
