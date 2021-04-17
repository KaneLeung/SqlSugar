using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugar
{
    public class PageModel
    {
        /// <summary>
        /// Current Page Index
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// Page Size
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// Data Count
        /// </summary>
        public int Count { get; set; }
    }
}