namespace MesFilms
{
    public class Eleve
    {
        public int idEleve;
        public string nomEleve;
        public string prenomEleve;
        public int anneeNaissance;

        public Eleve(int idEleve, string nomEleve, string prenomEleve, int anneeNaissance)
        {
            this.idEleve = idEleve;
            this.nomEleve = nomEleve;
            this.prenomEleve = prenomEleve;
            this.anneeNaissance = anneeNaissance;
        }
        public override string ToString()
        {
            return ($"Élève n°{idEleve} : {prenomEleve} {nomEleve} née en : {anneeNaissance}");
        }
        public int GetAnneeNaissance()
        {
            return this.anneeNaissance;
        }
        public string GetNomEleve() 
        {
            return nomEleve;
        }
        public string GetprenomEleve()
        {
            return prenomEleve;
        }
        public int GetidEleve()
        {
            return idEleve;
        }   
    }
}