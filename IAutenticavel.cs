﻿using ByteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.SistemaInterno
{
    public interface IAutenticavel
    {
        public bool Autenticar(string login, string senha); // o "bool" sempre espera um "return"!!!!

    }
}
