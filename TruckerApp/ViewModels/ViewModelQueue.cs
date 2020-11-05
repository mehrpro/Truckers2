using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckerApp.ViewModels
{
    public class ViewModelQueue
    {
        public short Number { get; set; }
        public byte GroupCommission { get; set; }
        public byte TypeFk { get; set; }
        public System.DateTime DateTimeRegister { get; set; }
        public int DriverIdFk { get; set; }
        public byte StatusFk { get; set; }
        public short ComosiunIdFk { get; set; }
        public int SeriesIdFk { get; set; }
        public bool? Mandeh { get; set; }
    }
}
