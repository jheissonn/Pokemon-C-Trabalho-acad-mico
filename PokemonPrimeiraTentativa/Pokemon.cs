using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPrimeiraTentativa
{
    class Pokemon
    {
        public int identificador;
        public string nome;
        public Image imagem;
        public string evolucao;
        public int altura;
        public int peso;
        int efeito ;

        public Pokemon() { }
        public Pokemon(int id,string nme,Image img,String evlcao,int alt,int pes,int efto)
        {
            identificador = id;
            nome = nme;
            imagem = img;
            evolucao = evlcao;
            altura = alt;
            peso = pes;
            efeito = efto;
        }
       



    }
}
