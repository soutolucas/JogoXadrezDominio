using System;

namespace JogoXadrezDominio
{
    public abstract class PecaXadrez
    {
        /// <summary>
        /// Deslocar a peça pelo tabuleiro
        /// </summary>
        public abstract void Mover();

        /// <summary>
        /// Eliminar a peça do adversário
        /// </summary>
        public void Capturar()
        {
            //Implementacao para capturar a peça
            throw new NotImplementedException();
        }

        /// <summary>
        /// Verifica a exitência de peça para capturar
        /// </summary>
        /// <returns></returns>
        public bool ExistePecaParaCapturar()
        {
            return true;
        }
    }
}
