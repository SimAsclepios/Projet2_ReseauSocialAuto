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
                // Nous supprimons la base si elle existe puis nous la cr�ons
                using (dDal ctx = new dDal())
                {
                    // Nous supprimons et cr�ons la db avant le test
                    ctx.DeleteCreateDatabase();
                    // Nous cr�ons un lieu de vacances
                    ctx.CreerAdherent("Cheyma", "Ayed", "shaymma.ayed@outlook.fr");

                    // Nous v�rifions que le lieu a bien �t� cr��
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

