using ÁrvoreDinamica.Valorecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁrvoreDinamica.Nos
{
    class No
    {
        public string nome { get; set; }
        public bool final { get; set; }
        public bool random { get; set; }
        public bool usarGlobal { get; set; }
        public List<Valoracao> valoresNecessarios { get; set; }
        public List<Valoracao> valoresExistentes { get; set; }
        public List<Valoracao> valoresGlobaisNecessarios { get; set; }
       


        public No(string nome = "", bool final = false, bool random = false, List<Valoracao> valoresNecessarios = null,
            List<Valoracao> valoresExistentes = null, List<Valoracao> valoresGlobais = null, bool usarGlobal = false)
        {
            this.nome = nome;
            this.final = final;
            this.random = random;
            this.usarGlobal = usarGlobal;
            if (valoresNecessarios != null)
                this.valoresNecessarios = valoresNecessarios;
            else
                this.valoresNecessarios = new List<Valoracao>();
            if (valoresExistentes != null)
                this.valoresExistentes = valoresExistentes;
            else
                this.valoresExistentes = new List<Valoracao>();
            if (valoresGlobais != null)
                this.valoresGlobaisNecessarios = valoresGlobais;
            else
                this.valoresGlobaisNecessarios = new List<Valoracao>();
        }



    }
}
