﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.AplicativoMOB.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Titulo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}