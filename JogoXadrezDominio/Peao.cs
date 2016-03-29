using System;

namespace JogoXadrezDominio
{
    public class Peao : PecaXadrez
    {
        public override void Mover()
        {
            //Implementação para mover peça...

            if (ExistePecaParaCapturar()) Capturar();
        }
    }
}
