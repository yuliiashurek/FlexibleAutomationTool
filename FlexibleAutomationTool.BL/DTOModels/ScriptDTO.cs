using FlexibleAutomationTool.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.DTOModels
{
    internal class ScriptsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Queue<Key> Keys { get; set; }
        public Queue<Mouse> Mouses { get; set; }
    }
}
