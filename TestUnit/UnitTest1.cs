using Projet2_BDD.Dal;
using Projet2_BDD.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestUnit
{
    public class UnitTest1
    {
        
      
            [Fact]

            public  void Creer_Adherent_Verification()
            {
                // Nous supprimons la base si elle existe puis nous la créons
                using (dDal ctx = new dDal())
                {
                    // Nous supprimons et créons la db avant le test
                    ctx.DeleteCreateDatabase();
                    // Nous créons un lieu de vacances
                    ctx.CreerAdherent("Cheyma", "Ayed", "shaymma.ayed@outlook.fr");

                    // Nous vérifions que le lieu a bien été créé
                    List<Adherent> Adherents = ctx.ObtenirAdherent();
                    Assert.NotNull(Adherents);
                    Assert.Single(Adherents);
                    Assert.Equal("Cheyma", Adherents[0].Nom);
                    Assert.Equal("Ayed", Adherents[0].Prenom);
                    Assert.Equal("shaymma.ayed@outlook.fr", Adherents[0].Email);
                }
            }
        }
    }

