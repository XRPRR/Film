namespace Film
{
    public class Acteur
    {
        public int idActeur;
        public string nomActeur;
        public string prenomActeur;
        public int anneeNaissance;

        public Acteur(int idActeur, string nomActeur, string prenomActeur, int anneeNaissance)

        {
            this.idActeur = idActeur;
            this.nomActeur = nomActeur;
            this.prenomActeur = prenomActeur;
            this.anneeNaissance = anneeNaissance;

        }

        public  (int id, string nom, string prenom, int annee) GetInstance()
        {
            return (idActeur, nomActeur, prenomActeur, anneeNaissance);
        }
        public int getAnneeNaissance()
        {
            return anneeNaissance;
        }
        public int getid() { return idActeur; }
        public string getNom() {  return nomActeur; }
        public string getPrenom() {  return prenomActeur; }
        public override string ToString()
        {
            return ($"Acteur n°{idActeur} : {nomActeur} {prenomActeur}, né en {anneeNaissance}");
        }
    }
}