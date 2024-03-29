﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        #region Atributos
        private int dni;
        private long cuit;
        private string nombre, tdni;
        private char sexo;
        private DateTime fechanac;
        #endregion

        #region Constructores
        public Persona()
        {
            dni = 0;
            cuit = 0;
            nombre = string.Empty;
            sexo = '\0';
            tdni = string.Empty;
            fechanac = DateTime.MinValue;
        }
        #endregion

        #region Propiedades
        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        public long CUIT
        {
            get { return cuit; }
            set { cuit = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Tdni
        {
            get { return tdni; }
            set { tdni = value; }
        }

        public DateTime FechaNac
        {
            get { return fechanac; }
            set { fechanac = value; }
        }


        #endregion

        #region Metodos
        public DateTime ConvUTC(DateTime dt){ fechanac = dt.ToUniversalTime(); return fechanac; }
        #endregion
    }
}

