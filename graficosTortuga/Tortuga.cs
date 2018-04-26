using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graficosTortuga
{
    class Tortuga
    {
        private int[,] _lienzo;
        private int _r;
        private int _c;
        private bool _pluma;
        private int _movimiento;

        public bool Pluma
        {
            get { return _pluma; }
            set { _pluma = value; }
        }

        public Tortuga ()
        {
            _lienzo = new int[20, 20];
            _r = 0;
            _c = 0;
            _pluma = false;
            _movimiento = 0;
        }

        public void GirarDerecha()
        {
            switch(_movimiento)
            {
                //Derecha
                case 0:
                    _movimiento = 3;
                    break;
                
                //Izquierda
                case 1:
                    _movimiento = 2;
                    break;
                
                //Arriba
                case 2:
                    _movimiento = 0;
                    break;
                
                //Abajo
                case 3:
                    _movimiento = 1;
                    break;
            }
        }

        public void GirarIzquierda()
        {
            switch (_movimiento)
            {
                case 0:
                    _movimiento = 2;
                    break;

                case 1:
                    _movimiento = 3;
                    break;

                case 2:
                    _movimiento = 1;
                    break;

                case 3:
                    _movimiento = 0;
                    break;
            }
        }

        public void Avanzar(int espacios)
        {
            switch (_movimiento)
            {
                //Derecha
                case 0:
                    for (int i = _c; i < _c + espacios; i++)
                    {
                        if (_pluma)
                            _lienzo[_r, i] = 1;
                    }

                    //Actualización de la posicion, _r queda igual
                    _c += espacios - 1;
                    break;

                //Izquierda
                case 1:
                    for (int i = _c; i > _c - espacios; i--)
                    {
                        if (_pluma)
                            _lienzo[_r, i] = 1;
                    }
                    _c -= espacios + 1;
                    break;

                //Arriba
                case 2:
                    for (int i = _r; i > _r - espacios; i--)
                    {
                        if (_pluma)
                            _lienzo[i, _c] = 1;
                    }
                    _r -= espacios + 1;
                    break;

                //Abajo
                case 3:
                    for (int i = _r; i < _r + espacios; i++)
                    {
                        if (_pluma)
                            _lienzo[i, _c] = 1;
                    }
                    _r += espacios - 1;
                    break;


            }
        }

        public string Graficar()
        {
            string dibujo = "";
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    dibujo += _lienzo[i, j] + " ";
                }
                dibujo += Environment.NewLine;
            }
            return dibujo += Environment.NewLine;
        }



        





    }
}
