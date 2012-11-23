using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RivDic
{
    class IdLabelItem
    {
        public IdLabelItem(string id, string label)
        {
            Id = id;
            Label = label;
        }

        public string Id { get; set; }

        public string Label { get; set; }

        public override string ToString()
        {
            return Label;
        }
    }
}
