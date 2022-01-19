using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Models
{
    public class VoitureProfil
    {
		public int Id { get; set; }
		public int UtilisateurId { get; set; }
		public virtual Utilisateur Utilisateur { get; set; }
		[Required(ErrorMessage = "La marque du véhicule doit être précisée.")]
		public Marque Marque { get; set; }
		[Required(ErrorMessage = "Le modèle doit être indiquée.")]
		[Display(Name = "Modèle")]
		[MaxLength(20)]
		public string Modele { get; set; }
		public TypeEnergie Energie { get; set; }
		public TypeBoite Boite { get; set; }
		public int Km { get; set; }
		[Display(Name = "Année")]
		[RegularExpression(@"^(?:19|20)\d{2}$", ErrorMessage = "l'année n'est pas valide")]
		public string Annee { get; set; }
	}


	/*
	public enum MarqueV
	{
		Alfa_Romeo,
		Audi,
		BMW,
		Chrysler,
		Citroen,
		Dacia,
		DS,
		Fiat,
		Ford,
		Honda,
		Hyundai,
		Jeep,
		Kia,
		Lancia,
		Land_Rover,
		Mazda,
		Mercedes,
		Mini,
		Mitsubishi,
		Nissan,
		Opel,
		Peugeot,
		Renault,
		Saab,
		Seat,
		Skoda,
		Smart,
		Subaru,
		Suzuki,
		Tesla,
		Toyota,
		Volkswagen,
		Volvo,
		Autres
	}

	public enum TypeEnergieV
	{
		Bioéthanol,
		Diesel,
		Electrique,
		Essence,
		Hybride,
		GPL
	}

	public enum TypeBoiteV
	{
		Automatique,
		Manuelle
	}
	*/
}


