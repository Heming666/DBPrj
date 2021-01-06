using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class ListItem
    {
        public ListItem()
        { }
        public ListItem(string text,string value)
        {
            Text = text;
            Value = value;
        }
        public string Text { get; set; }
        public string Value { get; set; }
    }
}
