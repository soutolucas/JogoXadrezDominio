using System;

namespace JogoXadrezDominio
{
    public class Rei : PecaXadrez
    {
        public override void Mover()
        {
            //Implementação para mover peça...

            if (ExistePecaParaCapturar()) Capturar();
        }
    }
}
