using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetierBdd
{
    public class GestionnaireBdd
    {
        // cnx sert à se connecter à la BDD
        private MySqlConnection cnx;
        // cmd sert à écrire nos requêtes SQL
        private MySqlCommand cmd;
        // dr me permet de récupérer le jeu d'enregistrement(s) de ma requête (SELECT)
        private MySqlDataReader dr;

        // Constructeur
        public GestionnaireBdd()
        {
            // La chaine va nous permettre de donner 
            // 1) le nom du serveur
            // 2) le nom de la base de données
            // 3) le nom de l'utilisateur
            // 4) le mot de passe
            string chaine = "Server=localhost;Database=ludotheque;Uid=root;Pwd=";
            cnx = new MySqlConnection(chaine);
            cnx.Open();
        }
    }
}
