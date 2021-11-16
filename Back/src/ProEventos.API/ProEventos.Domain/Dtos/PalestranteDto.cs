﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProEventos.Domain.Dtos
{
    public class PalestranteDto
    {
        public string Nome { get; set; }
        public string MinuCurriculo { get; set; }
        public string ImagemURL { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        public IEnumerable<PalestranteDto> Palestrantes { get; set; }
    }
}
