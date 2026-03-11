using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film
{
    internal class Film
    {
        private string titre;
        private string annee;
        private string genre;
        private Acteur acteurPrincipal;
        private int idFilm;
        public string resume;

        public Film(string titre, string annee, string genre, Acteur acteurPrincipal, int idFilm, string resume)
        {
            this.titre = titre;
            this.annee = annee;
            this.genre = genre;
            this.acteurPrincipal = acteurPrincipal;
            this.idFilm = idFilm;
            this.resume = resume;
        }
        public string getannee() {return annee;}
        public string getgenre() { return genre;}
        public int getidFilm() { return idFilm;}
        public string getresume() { return resume;}
        public Acteur getacteurPrincipal() {  return acteurPrincipal;}
        public string gettitre() { return titre; }
        public override string ToString()
        {
            return ($"Le film {titre} fait en {annee} de genre {genre} avec comme ID :{idFilm} et comme acteur principal {acteurPrincipal.ToString()}");
        }
    }
}
