namespace Recap.Models
{
    public static class FakeDb
    {
        public static List<User> Users = new List<User>(){
            new User(1, "Jacqueline", "Dupont", "Jacqueline.Dupont@lacharantaise.fr", new List<string>(){"Pulp Fiction", "Les 8 Salopards"}),
            new User(2, "Jean", "Lefevre", "Jean.Lefevre@example.com", new List<string>(){"Forrest Gump", "Le Parrain"}),
            new User(3, "Marie", "Dubois", "Marie.Dubois@example.com", new List<string>(){"Star Wars", "Retour vers le futur"}),
            new User(4, "Pierre", "Martin", "Pierre.Martin@example.com", new List<string>(){"La La Land", "Moulin Rouge"}),
            new User(5, "Sophie", "Dupont", "Sophie.Dupont@example.com", new List<string>(){"La Reine des Neiges", "Le Roi Lion"}),
            new User(6, "Luc", "Leroy", "Luc.Leroy@example.com", new List<string>(){"Harry Potter", "Le Seigneur des Anneaux"}),
            new User(7, "Julie", "Chevalier", "Julie.Chevalier@example.com", new List<string>(){"Avengers", "Iron Man"}),
            new User(8, "Francois", "Roux", "Francois.Roux@example.com", new List<string>(){"Jurassic Park", "King Kong"}),
            new User(9, "Anne", "Bertrand", "Anne.Bertrand@example.com", new List<string>(){"Titanic", "Pearl Harbor"}),
            new User(10, "Thomas", "Lambert", "Thomas.Lambert@example.com", new List<string>(){"Les Misérables", "Le Roi Arthur"}),
            new User(11, "Laure", "Lecomte", "Laure.Lecomte@example.com", new List<string>(){"Le Fabuleux Destin d'Amélie Poulain", "Le Discours d'un roi"}),
            new User(12, "Guillaume", "Girard", "Guillaume.Girard@example.com", new List<string>(){"Le Silence des Agneaux", "Seven"}),
            new User(13, "Elodie", "Deschamps", "Elodie.Deschamps@example.com", new List<string>(){"Le Grand Bleu", "Le Cinquième Élément"}),
            new User(14, "Antoine", "Martin", "Antoine.Martin@example.com", new List<string>(){"L'Arnacoeur", "Le Prénom"}),
            new User(15, "Caroline", "Roussel", "Caroline.Roussel@example.com", new List<string>(){"La Planète des Singes", "Blade Runner"}),
            new User(16, "Romain", "Bertrand", "Romain.Bertrand@example.com", new List<string>(){"E.T. l'extra-terrestre", "Rencontres du troisième type"}),
            new User(17, "Nathalie", "Lemaire", "Nathalie.Lemaire@example.com", new List<string>(){"Dirty Dancing", "Flashdance"}),
            new User(18, "Thierry", "Noël", "Thierry.Noel@example.com", new List<string>(){"Les Tontons Flingueurs", "Les Barbouzes"}),
            new User(19, "Céline", "Lacombe", "Celine.Lacombe@example.com", new List<string>(){"La Guerre des Étoiles", "Blade Runner"})
        };
    }
}
