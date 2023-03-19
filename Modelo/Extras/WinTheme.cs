using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Modelo.Extras
{
    public class WinTheme
    {

        public Color PanelPadre;
        public Color PanelTitulo;
        public Color FuenteTitulo;
        public Color PanelBotones;
        public Color PanelInferior;
        public Color FuenteInferior;

        //Color defecto
        private static readonly Color PanelBotonesD = Color.Gray;
        private static readonly Color PanelPabreD = Color.Black;
        private static readonly Color PanelTituloD = Color.FromArgb(64, 64, 64);
        private static readonly Color FuenteTituloD = Color.Black ;
        private static readonly Color PanelInferiorD = Color.Silver;
        private static readonly Color FuenteInferiorD = Color.FromArgb(64, 64, 64);

        //Color azul
        private static readonly Color PanelBotonesA = Color.FromArgb(69, 68, 168);
        private static readonly Color PanelPabreA = Color.FromArgb(22, 22, 54);
        private static readonly Color PanelTituloA = Color.FromArgb(92, 92, 130);
        private static readonly Color FuenteTituloA = Color.Black;
        private static readonly Color PanelInferiorA = Color.FromArgb(129, 129, 181);
        private static readonly Color FuenteInferiorA = Color.FromArgb(64, 64, 64);

        //Color verde
        private static readonly Color PanelBotonesV = Color.FromArgb(31, 105, 70);
        private static readonly Color PanelPabreV = Color.FromArgb(17, 56, 31);
        private static readonly Color PanelTituloV = Color.FromArgb(50, 168, 113);
        private static readonly Color FuenteTituloV = Color.Black;
        private static readonly Color PanelInferiorV = Color.FromArgb(109, 181, 147);
        private static readonly Color FuenteInferiorV = Color.FromArgb(64, 64, 64);

        //Color amarillo
        private static readonly Color PanelBotonesAm = Color.FromArgb(209, 160, 0);
        private static readonly Color PanelPabreAm = Color.FromArgb(84, 65, 0);
        private static readonly Color PanelTituloAm = Color.FromArgb(161, 123, 0);
        private static readonly Color FuenteTituloAm = Color.Black;
        private static readonly Color PanelInferiorAm = Color.FromArgb(217, 181, 65);
        private static readonly Color FuenteInferiorAm = Color.FromArgb(64, 64, 64);
        
        public void ElegirTema(string tema)
        {
            if (tema == "defecto")
            {
                PanelPadre = PanelPabreD;
                PanelTitulo = PanelTituloD;
                FuenteTitulo = FuenteTituloD;
                PanelBotones = PanelBotonesD;
                PanelInferior = PanelInferiorD;
                FuenteInferior = FuenteInferiorD;
            }

            if (tema == "azul")
            {
                PanelPadre = PanelPabreA;
                PanelTitulo = PanelTituloA;
                FuenteTitulo = FuenteTituloA;
                PanelBotones = PanelBotonesA;
                PanelInferior = PanelInferiorA;
                FuenteInferior = FuenteInferiorA;
            }

            if (tema == "verde")
            {
                PanelPadre = PanelPabreV;
                PanelTitulo = PanelTituloV;
                FuenteTitulo = FuenteTituloV;
                PanelBotones = PanelBotonesV;
                PanelInferior = PanelInferiorV;
                FuenteInferior = FuenteInferiorV;
            }

            if (tema == "amarillo")
            {
                PanelPadre = PanelPabreAm;
                PanelTitulo = PanelTituloAm;
                FuenteTitulo = FuenteTituloAm;
                PanelBotones = PanelBotonesAm;
                PanelInferior = PanelInferiorAm;
                FuenteInferior = FuenteInferiorAm;
            }
        }
    }
}
