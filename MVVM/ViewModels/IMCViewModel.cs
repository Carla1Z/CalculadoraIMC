using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC.MVVM.ViewModels
{
    public class IMCViewModel
    {
        public Models.IMC IMC { get; set; }
        public IMCViewModel()
        {
            IMC = new Models.IMC();
            IMC.Height = 170;
            IMC.Weight = 80;
        }
    }
}
