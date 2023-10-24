using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.IServices
{
    internal interface IParseHtmlService<T>
    {

        public T ParseHtmlToItem();
        public bool IsInRepository(T item);
        public void AddItem(T item);
    }
}
