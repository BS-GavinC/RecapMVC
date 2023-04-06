namespace Recap.Models.Context
{
    public static class FakeDb
    {
        private static int _cpt = 0;

        public static int cpt { 
            get
            {
                _cpt++;
                return _cpt;
            }
        }

        public static List<User> Users = new List<User>(){
            new User("Jacqueline", "Dupont", "Jacqueline.Dupont@lacharantaise.fr", new List<string>(){"Pulp Fiction", "Les 8 Salopards"}),
            new User("Jean", "Lefevre", "Jean.Lefevre@example.com", new List<string>(){"Forrest Gump", "Le Parrain"}),
            new User("Marie", "Dubois", "Marie.Dubois@example.com", new List<string>(){"Star Wars", "Retour vers le futur"}),
            new User("Pierre", "Martin", "Pierre.Martin@example.com", new List<string>(){"La La Land", "Moulin Rouge"}),
            new User("Sophie", "Dupont", "Sophie.Dupont@example.com", new List<string>(){"La Reine des Neiges", "Le Roi Lion"}),
            new User("Luc", "Leroy", "Luc.Leroy@example.com", new List<string>(){"Harry Potter", "Le Seigneur des Anneaux"}),
            new User("Julie", "Chevalier", "Julie.Chevalier@example.com", new List<string>(){"Avengers", "Iron Man"}),
            new User("Francois", "Roux", "Francois.Roux@example.com", new List<string>(){"Jurassic Park", "King Kong"}),
            new User("Anne", "Bertrand", "Anne.Bertrand@example.com", new List<string>(){"Titanic", "Pearl Harbor"}),
            new User("Thomas", "Lambert", "Thomas.Lambert@example.com", new List<string>(){"Les Misérables", "Le Roi Arthur"}),
            new User("Laure", "Lecomte", "Laure.Lecomte@example.com", new List<string>(){"Le Fabuleux Destin d'Amélie Poulain", "Le Discours d'un roi"}),
            new User("Guillaume", "Girard", "Guillaume.Girard@example.com", new List<string>(){"Le Silence des Agneaux", "Seven"}),
            new User("Elodie", "Deschamps", "Elodie.Deschamps@example.com", new List<string>(){"Le Grand Bleu", "Le Cinquième Élément"}),
            new User("Antoine", "Martin", "Antoine.Martin@example.com", new List<string>(){"L'Arnacoeur", "Le Prénom"}),
            new User("Caroline", "Roussel", "Caroline.Roussel@example.com", new List<string>(){"La Planète des Singes", "Blade Runner"}),
            new User("Romain", "Bertrand", "Romain.Bertrand@example.com", new List<string>(){"E.T. l'extra-terrestre", "Rencontres du troisième type"}),
            new User("Nathalie", "Lemaire", "Nathalie.Lemaire@example.com", new List<string>(){"Dirty Dancing", "Flashdance"}),
            new User("Thierry", "Noël", "Thierry.Noel@example.com", new List<string>(){"Les Tontons Flingueurs", "Les Barbouzes"}),
            new User("Céline", "Lacombe", "Celine.Lacombe@example.com", new List<string>(){"La Guerre des Étoiles", "Blade Runner"})
        };
    }
}
