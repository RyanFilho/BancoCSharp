﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Banco
{
    class Cofre
    {
        public Cedulas cedulas { get; private set; }

        public Cofre()
        {
        }
        public Cofre(int notasDe100, int notasDe50, int notasDe20, int notasDe10, int notasDe5, int notasDe2)
        {
            Adicionar(notasDe100, notasDe50, notasDe20, notasDe10, notasDe5, notasDe2);            
        }
        public int GetTotal() {
            return Utilitarios.ValorDasNotas(cedulas);
        }
        public void Adicionar(int valor)
        {
            cedulas = Utilitarios.ValorDoDinheiro(valor); 
        }
        public void Adicionar(int notasDe100, int notasDe50, int notasDe20, int notasDe10, int notasDe5, int notasDe2)
        {
            cedulas.Add(Notas.Cem, notasDe100);
            cedulas.Add(Notas.Cinquenta, notasDe50);
            cedulas.Add(Notas.Vinte, notasDe20);
            cedulas.Add(Notas.Dez, notasDe10);
            cedulas.Add(Notas.Cinco, notasDe5);
            cedulas.Add(Notas.Dois, notasDe2);
        }

        public void Adicionar(Notas nota, int valor)
        {
            cedulas.Add(nota, valor);
        }


    }
}
