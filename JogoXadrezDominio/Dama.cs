using System;

namespace JogoXadrezDominio
{
    public class Dama : PecaXadrez
    {
        public override void Mover()
        {
            //Implementação para mover peça...

            if (ExistePecaParaCapturar()) Capturar();
        }
    }
}
