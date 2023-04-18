using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeCalc.Model
{
    public class MainModel
    {
        private string dollar;
        private string won;

        public string Dollar { get => dollar; set => dollar = value; }
        public string Won { get => won; set => won = value; }
    }
}
