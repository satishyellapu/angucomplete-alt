using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftOverFeast
{
    public class ResponseModel
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public string JsonString { get; set; }
        public object Data { set; get; }
    }
}
