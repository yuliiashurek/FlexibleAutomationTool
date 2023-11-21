using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.IServices
{
    public interface IParseHtmlService<T>
    {

        public Task ParseHtmlToItem(HtmlTagsClass model = null);
        public bool IsInRepository(T item);
        public void AddItem(T item);
    }
}
