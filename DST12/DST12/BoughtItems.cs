using System;
using System.Collections.Generic;
using System.Text;

namespace DST12
{
    class BoughtItems
    {
        public string pcode { get; private set; }
        public string pname { get; private set; }
        public int pprice { get; private set; }
        public int pstock { get; private set; }
        public BoughtItems(string pcode, string pname, int pprice, int pstock)
        {
            this.pcode = pcode;
            this.pname = pname;
            this.pprice = pprice;
            this.pstock = pstock;
        }
    }
}
