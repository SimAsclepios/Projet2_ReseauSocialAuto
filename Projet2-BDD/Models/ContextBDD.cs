using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projet2_BDD.Models;

namespace Projet2_BDD.Models
{
    public class ContextBDD : IdentityDbContext
    {
        public DbSet<Utilisateur> Utilisateurs{ get; set; }



        //public DbSet<Adresse> Adresses { get; set; }
        public DbSet<DemandeServiceImmateriel> DemandeServiceImmateriels { get; set; }
        public DbSet<ProposerServiceMateriel> ProposerServiceMateriels { get; set; }
        public DbSet<Messagerie> Messageries { get; set; }
        public DbSet<Evenement_Formation> Evenement_Formations { get; set; }
        public DbSet<Commentaire> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Message> Messages { get; set; }

        public DbSet<Voiture> Voitures { get; set; }
        public DbSet<Covoiturage> Covoiturages { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<BienMateriel> BienMateriels { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=admin;database=RSA");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Messagerie>().HasOne<AppUser>(a => a.AppUser).
                WithMany(d => d.Messageries).HasForeignKey(d => d.UtilisateurId);
        }
        public void InitializeDb()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            /*
             this.Messageries.AddRange(
                 new Messagerie
                 {
                     Id = 1,
                     UserName = "Disney",
                    Message= "000000000"
                 },
                 new Messagerie
                 {
                     Id = 2,
                     UserName = "Chambord",
                    Message= "111111111"
                 }
             );
            */

            this.Utilisateurs.AddRange(
                  new Utilisateur
                  {
                      Id = 1,
                      Prenom = "Admin",
                      Nom = "RSA",
                      Email = "rsa.plateforme@gmail.com",
                      Password = "1C-F6-D5-9B-EB-C7-B4-B8-76-6D-8F-AC-6A-12-51-C2",
                      Role = "Admin",
                      Ville = "Lille",
                      Departement = Departement.Nord,
                      PhotoProfil = ""
                  },

                  new Utilisateur
                  {
                      Id = 2,
                      Prenom = "Paul",
                      Nom = "Martinez",
                      Email = "popol@gmail.com",
                      Password = "72-CB-91-71-99-54-18-AD-B6-79-FF-AF-FE-85-DC-1C",
                      Role = "Write",
                      Ville = "Saint-Omer",
                      Departement = Departement.Pas_de_Calais,
                      PhotoProfil = ""
                  },

                  new Utilisateur
                  {
                      Id = 3,
                      Prenom = "Bruce",
                      Nom = "Wayne",
                      Email = "brucewayne@gotham.com",
                      Password = "88-E3-EC-21-BE-1F-F2-37-80-4D-6D-7A-1B-76-80-23",
                      Role = "Write",
                      PhotoProfil = ""
                  }
                  );

            this.Voitures.AddRange(
               new Voiture
               {
                   Id = 1,
                   UtilisateurId = 2,
                   Marque = Marque.Citroen,
                   Modele = "C3",
                   Energie = TypeEnergie.Diesel,
                   Boite = TypeBoite.Manuelle,
                   Km = 105000,
                   Annee = "2015"
               },

               new Voiture
               {
                   Id = 2,
                   UtilisateurId = 3,
                   Marque = Marque.BMW,
                   Modele = "iX3",
                   Energie = TypeEnergie.Electrique,
                   Boite = TypeBoite.Automatique,
                   Km = 55000,
                   Annee = "2020"
               }
           );
            this.ProposerServiceMateriels.AddRange(
            new ProposerServiceMateriel
            {
                Id = 1,
                UtilisateurId = 2,
                Categorie = "Pièce Auto",
                DatePub = DateTime.Now,
                Titre = "Plaquette de frein",
                Decription = "Bonjour, je vend une plaquette de frein que j'ai en stock",
                Etat = "Publié",
                ImageName = "",
                Prix = "35",
                Prenom = "",
                
            });

            this.SaveChanges();
        }
    }
     

}
