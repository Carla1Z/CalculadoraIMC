using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class IMC
    {
        private float result;

        public float Height { get; set; }
        public float Weight { get; set; }
        public float Result
        {
            get 
            {
                return ((Weight / Height) / Height) * 10000;
            }
        }

    }
}
