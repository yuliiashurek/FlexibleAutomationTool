﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.DL.Models
{
    public class Script : Entity
    {
        public string Name { get; set; }
        public Queue<Key> Keys { get; set; }
        public Queue<Mouse> Mouses { get; set; }
    }
}
