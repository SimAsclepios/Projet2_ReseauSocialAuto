using Projet2_BDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Projet2_BDD.ViewModels;

namespace Projet2_BDD.Dal
{
    public class dDal : IDal
    {
        private ContextBDD _context;
        public dDal()
        {
            _context = new ContextBDD();
        }

        public static dDal dald { get; set; }

        public Utilisateur AjouterUtilisateur(string prenom, string nom, string email, string password)
        {
            string motDePasse = EncodeMD5(password);
            Utilisateur user = new Utilisateur() { Prenom = prenom, Nom = nom, Email = email, Password = motDePasse };
            this._context.Utilisateurs.Add(user);
            this._context.SaveChanges();
            return user;
        }

        public int CreerDemande(string titre, Categorie categorie, string description, string budget, string imageName, int userId)
        {
            DemandeServiceImmateriel demandeServiceImmateriel = new DemandeServiceImmateriel 
            { Titre = titre, Categorie = categorie, Description = description, Budget = budget, ImageName = imageName, UtilisateurId = userId };

            demandeServiceImmateriel.DatePub = DateTime.Now;
            _context.DemandeServiceImmateriels.Add(demandeServiceImmateriel);
            _context.SaveChanges();
            return demandeServiceImmateriel.Id;
        }

        public int CreerProposer(string titre, string categorie, string prix, string description, string imageName, int userId)
        {
            ProposerServiceMateriel proposer = new ProposerServiceMateriel 
            { Titre = titre, Categorie = categorie, Prix = prix, Decription = description, ImageName = imageName, UtilisateurId = userId };

            proposer.DatePub = DateTime.Now;
            //proposer.Etat = "Publié";
            _context.ProposerServiceMateriels.Add(proposer);
            _context.SaveChanges();
            return proposer.Id;
        }

        public int CreerEvement(string titre, DateTime dateEvent, string lieu, string description, string imageName, string nomOrganisateur, int userId)
        {
            Evenement_Formation evenement = new Evenement_Formation 
            { Titre = titre, DateEvent = dateEvent, Lieu = lieu, Description = description, ImageName = imageName, NomOrganisateur = nomOrganisateur, UtilisateurId = userId};

            evenement.DatePub = DateTime.Now;
            _context.Evenement_Formations.Add(evenement);
            _context.SaveChanges();
            return evenement.Id;
        }

        public int CreerMsg(Message mail)
        {
            mail.DateMsg = DateTime.Now;
            _context.Messages.Add(mail);
            _context.SaveChanges();
            return mail.Id;
        }

        public int PublieMsg(string titrePub, string typePub, int idDestinataire)
        {
            Message confirmation = new Message
            {
                DateMsg = DateTime.Now,
                DestinataireId = idDestinataire,
                EmetteurId = 1,     // id de l'admin prédéfinis.   
                Msg = "Votre publication de " + typePub + " : " + titrePub + " vient d'être publié sur la plateforme. "
            };
            _context.Messages.Add(confirmation);
            _context.SaveChanges();
            return confirmation.Id;
        }

        public void ModifierProfil(Utilisateur prof)
        {
            _context.Utilisateurs.Update(prof);
            _context.SaveChanges();
        }

        public void ModifierDmd(DemandeServiceImmateriel newDmd)
        {
            newDmd.DatePub = DateTime.Now;
            newDmd.Etat = "En Attente";
             _context.DemandeServiceImmateriels.Update(newDmd);
             _context.SaveChanges();
        }

        public void ModifierMat(ProposerServiceMateriel newMat)
        {
            newMat.DatePub = DateTime.Now;
            newMat.Etat = "En Attente";
            _context.ProposerServiceMateriels.Update(newMat);
            _context.SaveChanges();
        }

        public void ModifierEvent(Evenement_Formation newEvent)
        {
            newEvent.DatePub = DateTime.Now;
            newEvent.Etat = "En Attente";
            _context.Evenement_Formations.Update(newEvent);
            _context.SaveChanges();
        }

        public void PublieDmd(DemandeServiceImmateriel newDmd)
        {
            newDmd.DatePub = DateTime.Now;
            newDmd.Etat = "Publié";
            _context.DemandeServiceImmateriels.Update(newDmd);
            _context.SaveChanges();
        }

        public void PublieMat(ProposerServiceMateriel newMat)
        {
            newMat.DatePub = DateTime.Now;
            newMat.Etat = "Publié";
            _context.ProposerServiceMateriels.Update(newMat);
            _context.SaveChanges();
        }

        public void PublieEvent(Evenement_Formation newEvent)
        {
            newEvent.DatePub = DateTime.Now;
            newEvent.Etat = "Publié";
            _context.Evenement_Formations.Update(newEvent);
            _context.SaveChanges();
        }

        public void RefusDmd(DemandeServiceImmateriel newDmd)
        {
            newDmd.DatePub = DateTime.Now;
            newDmd.Etat = "Refusé";
            _context.DemandeServiceImmateriels.Update(newDmd);
            _context.SaveChanges();
        }

        public void RefusMat(ProposerServiceMateriel newMat)
        {
            newMat.DatePub = DateTime.Now;
            newMat.Etat = "Refusé";
            _context.ProposerServiceMateriels.Update(newMat);
            _context.SaveChanges();
        }

        public void RefusEvent(Evenement_Formation newEvent)
        {
            newEvent.DatePub = DateTime.Now;
            newEvent.Etat = "Refusé";
            _context.Evenement_Formations.Update(newEvent);
            _context.SaveChanges();
        }

       

        public void SupprimerDmd(int id)
        {
            DemandeServiceImmateriel dmd = _context.DemandeServiceImmateriels.Find(id);
            dmd.Etat = "Fermé";
            //_context.DemandeServiceImmateriels.Remove(dmdASup);
            _context.DemandeServiceImmateriels.Update(dmd);
            _context.SaveChanges();
        }

        public void SupprimerMat(int id)
        {
            ProposerServiceMateriel mat = _context.ProposerServiceMateriels.Find(id);
            mat.Etat = "Fermé";
            //_context.ProposerServiceMateriels.Remove(matASup);
            _context.ProposerServiceMateriels.Update(mat);
            _context.SaveChanges();
        }

        public void SupprimerEvent(int id)
        {
            Evenement_Formation ef = _context.Evenement_Formations.Find(id);
            ef.Etat = "Fermé";
            //_context.Evenement_Formations.Remove(eventASup);
            _context.Evenement_Formations.Update(ef);
            _context.SaveChanges();
        }

        public void ClasserDmd(int id)
        {
            DemandeServiceImmateriel dmd = _context.DemandeServiceImmateriels.Find(id);
            dmd.Etat = "Classé";
            //_context.DemandeServiceImmateriels.Remove(dmdASup);
            _context.DemandeServiceImmateriels.Update(dmd);
            _context.SaveChanges();
        }

        public void ClasserMat(int id)
        {
            ProposerServiceMateriel mat = _context.ProposerServiceMateriels.Find(id);
            mat.Etat = "Fermé";
            //_context.ProposerServiceMateriels.Remove(matASup);
            _context.ProposerServiceMateriels.Update(mat);
            _context.SaveChanges();
        }

        public void ClasserEvent(int id)
        {
            Evenement_Formation ef = _context.Evenement_Formations.Find(id);
            ef.Etat = "Fermé";
            //_context.Evenement_Formations.Remove(eventASup);
            _context.Evenement_Formations.Update(ef);
            _context.SaveChanges();
        }


        public List<MsgUserViewModel> ObtenirMessagerie(int userId)
        {
            List<Message> listMsg = _context.Messages.Where(a => a.EmetteurId == userId || a.DestinataireId == userId).ToList();
            List<int> listDestinataire = new List<int>();
          //  List<Message> listDernierMsg = new List<Message>();
          //  List<Utilisateur> listContact = new List<Utilisateur>();
            List<MsgUserViewModel> listMessagerie = new List<MsgUserViewModel>();

            for  (int i=0; i < listMsg.Count; i++)
            {
                if ( !listDestinataire.Contains(listMsg[i].DestinataireId) && listMsg[i].DestinataireId != userId || !listDestinataire.Contains(listMsg[i].EmetteurId) && listMsg[i].EmetteurId != userId)
                {
                    if (listMsg[i].DestinataireId != userId) 
                    {
                        listDestinataire.Add(listMsg[i].DestinataireId);
                    }
                    if (listMsg[i].EmetteurId != userId)
                    {
                        listDestinataire.Add(listMsg[i].EmetteurId);
                    }
                }
            }

            // && listMsg[i].EmetteurId != userId && listMsg[i].DestinataireId != userId

            for (int i = listDestinataire.Count-1; i >= 0; i--)
            {
              //  listDernierMsg.Add (_context.Messages.Last ( m => m.DestinataireId == listDestinataire[i]));
              //  listContact.Add(_context.Utilisateurs.FirstOrDefault(u => u.Id == listDestinataire[i]));
                MsgUserViewModel msgUser = new MsgUserViewModel();
                
                List<Message> takeMsg = _context.Messages.Where(a => a.DestinataireId == listDestinataire[i] && a.EmetteurId == userId || a.EmetteurId == listDestinataire[i] && a.DestinataireId == userId ).ToList();
                msgUser.Mail = takeMsg[takeMsg.Count - 1];
                msgUser.Destinataire = _context.Utilisateurs.FirstOrDefault(u => u.Id == listDestinataire[i]);
                
                /*
                try
                {
                    msgUser.Mail = _context.Messages.Last(m => m.DestinataireId == listDestinataire[i]);
                    
                }
                catch
                {
                    Exception e;
                }
                */

                listMessagerie.Add(msgUser);
            }
            return listMessagerie;
        }

        public MessagesViewModels ObtenirMessage(int userId, int destinataireId)
        {
            MessagesViewModels viewModel = new MessagesViewModels();

            viewModel.Messages = _context.Messages.Where(a => a.EmetteurId == userId && a.DestinataireId == destinataireId || a.EmetteurId == destinataireId && a.DestinataireId == userId).ToList();
            viewModel.Destinataire = ObtenirUtilisateur(destinataireId);

            return viewModel;
        }
           

        public List<DemandeServiceImmateriel> RechService(string rech, int id)
        {
            return _context.DemandeServiceImmateriels.Where(a => a.Titre.Contains(rech) && a.Etat.Equals("Publié") && a.UtilisateurId != id || a.Description.Contains(rech) && a.Etat.Equals("Publié") && a.UtilisateurId != id || a.Categorie.Equals(rech) && a.Etat.Equals("Publié") && a.UtilisateurId != id).ToList();
        }
        public List<ProposerServiceMateriel> RechMateriel(string rech, int id)
        {
            
                return _context.ProposerServiceMateriels.Where(a => a.Titre.Contains(rech) && a.Etat.Equals("Publié") && a.UtilisateurId != id || a.Decription.Contains(rech) && a.Etat.Equals("Publié") && a.UtilisateurId != id || a.Categorie.Equals(rech) && a.Etat.Equals("Publié") && a.UtilisateurId != id).ToList();

            // List<ProposerServiceMateriel> listMat = _context.ProposerServiceMateriels.Where(a => a.Categorie.Contains(cat)).ToList();
            // List<ProposerServiceMateriel> listRech = new List<ProposerServiceMateriel>();


            /*
            for (int i = 0; i < listMat.Count(); i++)
            {
                if (listMat[i].Categorie.Contains(cat) && listMat[i].Titre.Contains()
                {
                    listRech.Add(listMat[i]);
                }
            }
            for (int i = 0; i < listMat.Count(); i++)

                return listMat;
        */
        }

        public List<Evenement_Formation> RechEvenement(string rech, int id)
        {
            return _context.Evenement_Formations.Where(a => a.Titre.Contains(rech) && a.Etat.Equals("Publié") && a.UtilisateurId != id || a.Description.Contains(rech) && a.Etat.Equals("Publié") && a.UtilisateurId != id || a.Equals(rech) && a.Etat.Equals("Publié") && a.UtilisateurId != id).ToList();
            }

        public List<DemandeServiceImmateriel> ObtenirListServicesImmateriel(int id)
        {
            return _context.DemandeServiceImmateriels.Where(d => d.Etat.Contains("Publié") && d.UtilisateurId != id).ToList();
        }

        public List<ProposerServiceMateriel> ObtenirListServicesMateriel(int id)
        {
            return _context.ProposerServiceMateriels.Where(m => m.Etat.Contains("Publié") && m.UtilisateurId != id).ToList();
        }

        public List<Evenement_Formation> ObtenirListEvenement(int id)
        {
            return _context.Evenement_Formations.Where(e => e.Etat.Contains("Publié") && e.UtilisateurId != id).ToList();
        }

        public AllPost ObtenirPublicationAttenteAdmin()
        {
            AllPost viewModel = new AllPost();
            viewModel.Dmd = _context.DemandeServiceImmateriels.Where(d => d.Etat.Contains("En Attente")).ToList();
            viewModel.Mat = _context.ProposerServiceMateriels.Where(d => d.Etat.Contains("En Attente")).ToList();
            viewModel.Event = _context.Evenement_Formations.Where(d => d.Etat.Contains("En Attente")).ToList();
            viewModel.Auto = _context.Voitures.Where(d => d.Etat.Contains("En Attente")).ToList();
            viewModel.LocMat = _context.BienMateriels.Where(d => d.Etat.Contains("En Attente")).ToList();
            viewModel.Covoit = _context.Covoiturages.Where(d => d.Etat.Contains("En Attente")).ToList();
            return viewModel;
        }

        public AllPost ObtenirPublicationLitigeAdmin()
        {
            AllPost viewModel = new AllPost();
            viewModel.Dmd = _context.DemandeServiceImmateriels.Where(d => d.Etat.Contains("Litige")).ToList();
            viewModel.Mat = _context.ProposerServiceMateriels.Where(d => d.Etat.Contains("Litige")).ToList();
            viewModel.Event = _context.Evenement_Formations.Where(d => d.Etat.Contains("Litige")).ToList();
            viewModel.Auto = _context.Voitures.Where(d => d.Etat.Contains("Litige")).ToList();
            viewModel.LocMat = _context.BienMateriels.Where(d => d.Etat.Contains("Litige")).ToList();
            viewModel.Covoit = _context.Covoiturages.Where(d => d.Etat.Contains("Litige")).ToList();
            return viewModel;
        }

        public AllPost ObtenirPublicationAdmin(string etatPub)
        {
            AllPost viewModel = new AllPost();
            viewModel.Dmd = _context.DemandeServiceImmateriels.Where(d => d.Etat.Contains(etatPub)).ToList();
            viewModel.Mat = _context.ProposerServiceMateriels.Where(d => d.Etat.Contains(etatPub)).ToList();
            viewModel.Event = _context.Evenement_Formations.Where(d => d.Etat.Contains(etatPub)).ToList();
            return viewModel;
        }
        public AllPost VoirNosPosts(int UserId)
        {
            // List<AllPost> nosPosts = new List<AllPost>();
            AllPost nosPosts = new AllPost();
            
            try
            {
                nosPosts.Dmd = _context.DemandeServiceImmateriels.Where(d => d.UtilisateurId == UserId).ToList();
            }
            catch
            {
                _ = nosPosts.Dmd;
            }

            
            try
            {
                nosPosts.Mat = _context.ProposerServiceMateriels.Where(m => m.UtilisateurId == UserId).ToList();
            }
            catch (Exception e)
            {
                _ = nosPosts.Mat;
            }

            try
            {
                nosPosts.Event = _context.Evenement_Formations.Where(ef => ef.UtilisateurId == UserId).ToList();
            }
            catch (Exception e)
            {
                _ = nosPosts.Event;
            }

            return nosPosts;
        }

        public List<DemandeServiceImmateriel> AfficherServicesImmateriel(int utilisateurId)
        {
            return _context.DemandeServiceImmateriels.ToList();
        }

        public List<Utilisateur> ObtenirUtilisateur()
        {
            return this._context.Utilisateurs.ToList();
        }
        public Utilisateur ObtenirUtilisateur(int id)
        {
            return this._context.Utilisateurs.FirstOrDefault(u => u.Id == id);
        }

        public Utilisateur ObtenirUtilisateur(string idString)
        {
            int id;
            if (int.TryParse(idString, out id))
            {
                return this.ObtenirUtilisateur(id);
            }
            return null;
        }

        public DemandeServiceImmateriel ObtenirServiceImmateriel(int id)
        {
            return this._context.DemandeServiceImmateriels.FirstOrDefault(u => u.Id == id);
        }

        public ProposerServiceMateriel ObtenirServicesMateriel(int id)
        {
            return this._context.ProposerServiceMateriels.FirstOrDefault(u => u.Id == id);
        }

        public Evenement_Formation ObtenirEvenement(int id)
        {
            return this._context.Evenement_Formations.FirstOrDefault(u => u.Id == id);
        }



        // Voiture //

        public List<Voiture> ObtenirVoiture()
        {
            return _context.Voitures.Where(v => v.Etat.Contains("Publié")).ToList();
        }

        public Voiture ObtenirVoiture(int id)
        {
            return this._context.Voitures.FirstOrDefault(u => u.Id == id);
        }

        public int CreerVoiture(int utilisateurId, Marque marque, string modele, TypeEnergie energie, TypeBoite boite, int km, string annee, DateTime dispoDebut, DateTime dispoFin, int montantJour, int montantKm, string description, string imageName)
        {
            Voiture voiture = new Voiture
            { UtilisateurId = utilisateurId, Marque = marque, Modele = modele, Energie = energie, Boite = boite, Km = km, Annee = annee, ImageName = imageName };
            voiture.Titre = marque + " " + modele;
            _context.Voitures.Add(voiture);
            _context.SaveChanges();
            return voiture.Id;
        }

        public void ModifierVoiture(int id, int utilisateurId, Marque marque, string modele, TypeEnergie energie, TypeBoite boite, int km, string annee, DateTime dispoDebut, DateTime dispoFin, int montantJour, int montantKm, string description, string imageName)
        {
            Voiture carOld = _context.Voitures.Find(id);
            if (carOld != null)
            {
                carOld.UtilisateurId = utilisateurId;
                carOld.Marque = marque;
                carOld.Modele = modele;
                carOld.Energie = energie;
                carOld.Boite = boite;
                carOld.Km = km;
                carOld.Annee = annee;
                carOld.DispoDebut = DateTime.Now;
                carOld.DispoFin = DateTime.Now;
                carOld.MontantJour = montantJour;
                carOld.MontantKm = montantKm;
                carOld.Description = description;
                carOld.ImageName = imageName;

                _context.SaveChanges();
            }
        }

        public void SupprimerVoiture(int id)
        {
            Voiture voiture = _context.Voitures.Find(id);
            if (voiture != null)
            {
                _context.Voitures.Remove(voiture);
                _context.SaveChanges();
            }
        }

        // Covoiturage //

        public List<Covoiturage> ObtenirCovoiturage()
        {
            return _context.Covoiturages.Where(v => v.Etat.Contains("Publié")).ToList();
        }

        public Covoiturage ObtenirCovoiturage(int id)
        {
            return this._context.Covoiturages.FirstOrDefault(u => u.Id == id);
        }

        public int CreerCovoiturage(string villeDepart, string villeArrivee, string villeEtape, DateTime dateDepart, int nbPlace, int prix, string description)
        {
            Covoiturage covoit = new Covoiturage
            { VilleDepart = villeDepart, VilleArrivee = villeArrivee, VilleEtape = villeEtape, DateDepart = dateDepart, NbPlace = nbPlace, Prix = prix, Description = description };

            _context.Covoiturages.Add(covoit);
            _context.SaveChanges();
            return covoit.Id;
        }

        public void ModifierCovoiturage(int id, int voitureId, string villeDepart, string villeArrivee, string villeEtape, DateTime dateDepart, int nbPlace, int prix, string description)
        {
            Covoiturage covoitOld = _context.Covoiturages.Find(id);
            if (covoitOld != null)
            {
                covoitOld.VilleDepart = villeDepart;
                covoitOld.VilleArrivee = villeArrivee;
                covoitOld.VilleEtape = villeEtape;
                covoitOld.DateDepart = DateTime.Now;
                covoitOld.NbPlace = nbPlace;
                covoitOld.Prix = prix;
                covoitOld.Description = description;

                _context.SaveChanges();
            }
        }

        public void SupprimerCovoiturage(int id)
        {
            Covoiturage covoit = _context.Covoiturages.Find(id);
            if (covoit != null)
            {
                _context.Covoiturages.Remove(covoit);
                _context.SaveChanges();
            }
        }

        // Location //

        public int CreerLocation(int utilisateurId, Rubrique rubrique)
        {
            Location location = new Location
            { UtilisateurId = utilisateurId, Rubrique = rubrique };
            _context.Locations.Add(location);
            _context.SaveChanges();
            return location.Id;
        }

        public List<Location> ObtenirLocation()
        {
            return _context.Locations.ToList();
        }

        public Location ObtenirLocation(int id)
        {
            return this._context.Locations.FirstOrDefault(u => u.Id == id);
        }

        public List<Location> AfficherLocation(int voitureId)
        {
            return _context.Locations.ToList();
        }

        public void ModifierLocation(int id, int utilisateurId, string titre, Rubrique rubrique)
        {
            Location locOld = _context.Locations.Find(id);
            if (locOld != null)
            {
                locOld.UtilisateurId = utilisateurId;
                locOld.Titre = titre;
                locOld.Rubrique = rubrique;

                _context.SaveChanges();
            }
        }

        // Location Bien Matériel //

        public int CreerBienMateriel(int utilisateurId, string titre, DateTime dispoDebut, DateTime dispoFin, int montantJour, string description, string imageName)
        {
            BienMateriel bm = new BienMateriel
            { UtilisateurId = utilisateurId, Titre = titre, DispoDebut = dispoDebut, DispoFin = dispoFin, MontantJour = montantJour, Description = description, ImageName = imageName };
            _context.BienMateriels.Add(bm);
            _context.SaveChanges();
            return bm.Id;
        }

        public List<BienMateriel> ObtenirBienMateriel()
        {
            return _context.BienMateriels.Where(v => v.Etat.Contains("Publié")).ToList();
        }

        public BienMateriel ObtenirBienMateriel(int id)
        {
            return this._context.BienMateriels.FirstOrDefault(u => u.Id == id);
        }

        public List<BienMateriel> AfficherBienMateriel(int utilisateurId)
        {
            return _context.BienMateriels.ToList();
        }

        public void ModifierBienMateriel(int id, int utilisateurId, string titre, DateTime dispoDebut, DateTime dispoFin, int montantJour, string description, string imageName)
        {
            BienMateriel bmOld = _context.BienMateriels.Find(id);
            if (bmOld != null)
            {
                bmOld.UtilisateurId = utilisateurId;
                bmOld.Titre = titre;
                bmOld.DispoDebut = dispoDebut;
                bmOld.DispoFin = dispoFin;
                bmOld.MontantJour = montantJour;
                bmOld.Description = description;
                bmOld.ImageName = imageName;

                _context.SaveChanges();
            }
        }

        public void SupprimerBienMateriel(int id)
        {
            BienMateriel bm = _context.BienMateriels.Find(id);
            if (bm != null)
            {
                _context.BienMateriels.Remove(bm);
                _context.SaveChanges();
            }
        }


        //A quoi sert Tag ?
        public List<Tag> ObtenirTag()
        {
            return _context.Tags.ToList();
        }
        public int CreerTag(string name, string slug)
        {
            Tag tag = new Tag { Name = name, Slug = slug };
            _context.Tags.Add(tag);
            _context.SaveChanges();
            return tag.ID;
        }



        private string EncodeMD5(string motDePasse)
        {
            string motDePasseSel = "Automobile" + motDePasse + "ASP.NET MVC";
            return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.Default.GetBytes(motDePasseSel)));
        }

        public void Dispose()
        {
            _context.Dispose();
        }
        
        public void DeleteCreateDatabase()
        {
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
        }

        public Utilisateur Authentifier(string prenom, string password)
        {
            string motDePasse = EncodeMD5(password);
            Utilisateur user = this._context.Utilisateurs.FirstOrDefault(u => u.Prenom == prenom && u.Password == motDePasse);
            return user;
        }



        /*
        public void ModifierService(int id, string titre, Categorie categorie, string description, string budget, string imageName, int userId)
        {
            DemandeServiceImmateriel dmdOld = _context.DemandeServiceImmateriels.Find(id);
            if (dmdOld != null)
            {
                dmdOld.Titre = titre;
                dmdOld.Categorie = categorie;
                dmdOld.Description = description;
                dmdOld.Budget = budget;
                dmdOld.DatePub = DateTime.Now;
                dmdOld.ImageName = imageName;
                dmdOld.UtilisateurId = userId;
                _context.DemandeServiceImmateriels.Update(dmdOld);

                _context.SaveChanges();
            }
        }
        */



        /*
        public int CreerCommentaire(string email, string pseudo, string contenu, DateTime publication)
        {
            Commentaire commentaire = new Commentaire { Email = email, Pseudo = pseudo, Contenu = contenu, Publication = publication };
            _context.Comments.Add(commentaire);
            _context.SaveChanges();
            return commentaire.ID;
        }

         // Methodes et Model commentaire à modifier : Faire plutot un commentaire sur un profil après réalisation d'un service.

        public List<Commentaire> ObtenirCommentaire()
        {
            return _context.Comments.ToList();
        }
        */


        /*
        public List<Post> ObtenirPost()
        {
            return _context.Posts.ToList();
        }
        public int CreerPost(string Pseudo, string titre, string contenu, string imageName)
        {
            Post post = new Post { Pseudo = Pseudo, Titre = titre, Contenu = contenu, ImageName = imageName };
            _context.Posts.Add(post);
            _context.SaveChanges();
            return post.ID;
        }
        */


    }
}

