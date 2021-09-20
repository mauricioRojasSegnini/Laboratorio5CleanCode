using System;
using System.Reflection.Metadata;

namespace LabCleanCode
{
    public class BosqueEncantado
    {
        private int[,] matrizBosque;
        private int cantidadFilas;
        private int cantidadColumnas;
        public int LAGOS = 1;
        public int ARBOL = 2;

        public BosqueEncantado(int filas, int columnas)
        {
            cantidadFilas = filas;
            cantidadColumnas = columnas;
            matrizBosque = new int[cantidadFilas, cantidadColumnas];
            double numeroAleatorio;
            int int_decision;
            for (int f = 0; f < cantidadFilas; ++f)
            {
                for (int c = 0; c < cantidadColumnas; ++c)
                {
                    numeroAleatorio = (Math.random() * 3) + 1;
                    int_decision = (int)numeroAleatorio;
                    if (int_decision == 1)
                    {
                        matrizBosque[f,c] = 1;
                    }
                    if (int_decision == 2)
                    {
                        matrizBosque[f,c] = 2;
                    }

                    if (int_decision == 3)
                    {
                        matrizBosque[f,c] = 3;
                    }
                    if (int_decision != 3 && int_decision != 2 && int_decision != 1)
                    {
                        numeroAleatorio = (Math.random() * 3) + 1;
                    }
                }
            }
        }



        public void Cambiarnumerosdelbosque()
        {
            for (int fila = 0; fila < cantidadFilas; ++fila)
            {
                for (int columna = 0; columna < cantidadColumnas; ++columna)
                { 
                    int contadorLagos = cantidadLagos(fila,columna,matrizBosque);
                    int contadorArboles = cantidadArboles(fila, columna, matrizBosque);
                    if (matrizBosque[fila,columna] == 2)
                    {
                        if (contadorLagos >= 4)
                        {
                            matrizBosque[fila,columna] = 1;
                        }
                        else
                        {
                            if (contadorArboles > 4)
                            {
                                matrizBosque[fila,columna] = 2;
                            }
                        }
                    }
                    if (matrizBosque[fila,columna] == 1)
                    {
                        if (contadorLagos < 3)
                            matrizBosque[fila,columna] = 3;
                    }

                    if (matrizBosque[fila,columna] == 3)
                    {
                        if (contadorArboles >= 3)
                            matrizBosque[fila,columna] = 2;
                    }
                }
            }
			Pantalla p = new Pantalla(matrizBosque);
			string s=p.crear();
			//imp pantalla
        }

        public int cantidadLagos(int fila, int columna, var matriz)
        {
            int contadorLagos = 0;
            for (int estaFila = fila - 1; estaFila <= fila + 1; ++estaFila)
            {
                for (int estaColumna = columna - 1; estaColumna <= columna + 1; ++estaColumna)
                {
                    if (estaFila != fila && estaColumna != columna)
                    {
                        if (0 <= estaFila && 0 <= estaColumna && fila < cantidadFilas && columna < cantidadColumnas)
                        {
                            if (matriz[fila, columna] == LAGOS)
                                ++contadorLagos;
                        }
                    }
                }
            }
            return contadorLagos;
        }

        public int cantidadArboles(int fila, int columna, var pmatriz)
        {
            int contadorArboles = 0;
            for (int estaFila = fila - 1; estaFila <= fila + 1; ++estaFila)
            {
                for (int estaColumna = columna - 1; estaColumna <= columna + 1; ++estaColumna)
                {
                    if (!(estaFila == fila && estaColumna == columna))
                    {
                        if (0 <= estaFila && 0 <= estaColumna && fila < cantidadFilas && columna < cantidadColumnas)
                        {
                            if (pmatriz[fila, columna] == ARBOL)
                                ++contadorArboles;
                        }
                    }
                }
            }
            return contadorArboles;
        }
    }
}