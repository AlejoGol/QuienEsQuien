﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QEQB05.Models
{
    public class CategoríaP
    {
        int _Id;
        string _Nombre;

        public int Id { get => _Id; set => _Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }

        public CategoríaP()
        {
            _Id = -1;
            _Nombre = null;
        }

        public CategoríaP(int id, string nom)
        {
            _Id = id;
            _Nombre = nom;
        }
    }
}