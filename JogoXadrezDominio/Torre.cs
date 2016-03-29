using System;

namespace JogoXadrezDominio
{
    public class Torre : PecaXadrez
    {
        public override void Mover()
        {
            //Implementação para mover peça...

            if (ExistePecaParaCapturar()) Capturar();
        }
    }
}
