﻿using System;

namespace JogoXadrezDominio
{
    public class Cavalo : PecaXadrez
    {
        public override void Mover()
        {
            //Implementação para mover peça...

            if (ExistePecaParaCapturar()) Capturar();
        }
    }
}
