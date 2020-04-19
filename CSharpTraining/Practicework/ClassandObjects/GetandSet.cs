using System;
using System.Collections.Generic;
using System.Text;

namespace Practicework.ClassandObjects
{
    class GetandSet
    {
        public string name { get; set; }
        public int number { get; set; }
        public double currency { get; set; }
        public long bignumber { get; set; }
        public string fname { get; set; }
        public char cname { get; set; }
        public GetandSet()
        {

        }
        public GetandSet(string sname,int num,double cur,long big,string fathername,char charname)
        {
            this.name = sname;
            this.number = num;
            this.currency = cur;
            this.bignumber = big;
            this.fname = fathername;
            this.cname = charname;
        }
    }
 
}
