using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Models
{
	public class Utilisateur
	{
		public Utilisateur()
		{
			Role = "Write";
			Etat = "Ok";
		}
		public int Id { get; set; }
		[Display(Name = "Prénom")]
		public string Prenom { get; set; }
		public string Nom { get; set; }
		public string Email { get; set; }
		[Display(Name = "Mot de passe")]
		public string Password { get; set; }
		public string Role { get; set; }

		public string Ville { get; set; }
		public Departement Departement { get; set; }
		public string PhotoProfil { get; set; }
		public string Etat { get; set; }    // Avertissement et bloqué
		public DateTime DateCreationCompte { get; set; }
		public DateTime DateFinAbonnemment { get; set; }


		// Le stockage d'un objet adresse dans une colonne bdd de l'objet Utilisateur fonctionne ??
		// Sinon faire clé	/OU/	Mettre ici tous les attributs d'adresse (le plus simple)
		//public Adresse AdresseUser { get; set; }
	}








	public enum Departement
	{
Ain,
Aisne,
Allier,
Alpes_de_Haute_Provence,
Hautes_Alpes,
Alpes_Maritimes,
Ardèche,
Ardennes,
Ariège,
Aube,
Aude,
Aveyron,
Bouches_du_Rhône,
Calvados,
Cantal,
Charente,
Charente_Maritime,
Cher,
Corrèze,
Corse,
Côte_d_Or,
Côtes_d_Armor,
Creuse,
Dordogne,
Doubs,
Drôme,
Eure,
Eure_et_Loir,
Finistère,
Gard,
Haute_Garonne,
Gers,
Gironde,
Hérault,
Ille_et_Vilaine,
Indre,
Indre_et_Loire,
Isère,
Jura,
Landes,
Loir_et_Cher,
Loire,
Haute_Loire,
Loire_Atlantique,
Loiret,
Lot,
Lot_et_Garonne,
Lozère,
Maine_et_Loire,
Manche,
Marne,
Haute_Marne,
Mayenne,
Meurthe_et_Moselle,
Meuse,
Morbihan,
Moselle,
Nièvre,
Nord,
Oise,
Orne,
Pas_de_Calais,
Puy_de_Dôme,
Pyrénées_Atlantiques,
Hautes_Pyrénées,
Pyrénées_Orientales,
Bas_Rhin,
Haut_Rhin,
Rhône,
Haute_Saône,
Saône_et_Loire,
Sarthe,
Savoie,
Haute_Savoie,
Paris,
Seine_Maritime,
Seine_et_Marne,
Yvelines,
Deux_Sèvres,
Somme,
Tarn,
Tarn_et_Garonne,
Var,
Vaucluse,
Vendée,
Vienne,
Haute_Vienne,
Vosges,
Yonne,
Territoire_de_Belfort,
Essonne,
Hauts_de_Seine,
Seine_St_Denis,
Val_de_Marne,
Val_d_Oise,
//Guadeloupe,
//Martinique,
//Guyane,
//La_Réunion,
//Mayotte
			
	}
}
