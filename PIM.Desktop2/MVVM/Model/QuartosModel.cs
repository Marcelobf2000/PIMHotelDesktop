﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PIM.Desktop.MVVM.Model
{
    public class QuartosModel
    {
        //public QuartosModel(string _NomeQuarto, decimal _ValorQuarto, int _QuantiaCamas, int _QuantiaBanheiros, int _ImgQuarto)
        //{
        //    Nome_quarto = _NomeQuarto;
        //    Valor_quarto = _ValorQuarto;
        //    Quantia_camas = _QuantiaCamas;
        //    Quantia_banheiros = _QuantiaBanheiros;
        //    Img_quarto = _ImgQuarto;

        //}

        public string Nome_quarto { get; set; }

        public int Valor_quarto { get; set; }

        public int Quantia_camas { get; set; }

        public int Quantia_banheiros { get; set; }

        public int Img_quarto { get; set; }

    }
}
