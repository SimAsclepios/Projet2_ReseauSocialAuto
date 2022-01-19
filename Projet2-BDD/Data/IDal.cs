using Projet2_BDD.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2_BDD.Models
{
    interface IDal : IDisposable
    {
        
        Utilisateur AjouterUtilisateur(string prenom, string nom, string email, string password);
        int CreerDemande(string titre, Categorie categorie, string Description, string budget, string imageName, int userId);
        int CreerProposer(string titre, string categorie, string prix, string description, string imageName, int userId);
        int CreerEvement(string titre, DateTime dateEvent, string lieu, string description, string imageName, string nomOrganisateur, int userId);
        int CreerMsg(Message mail);

        int PublieMsg(String titrePub, String typePub, int idDestinataire);

        void PublieDmd(DemandeServiceImmateriel newDmd);
        void PublieMat(ProposerServiceMateriel newMat);
        void PublieEvent(Evenement_Formation newEvent);
        void RefusDmd(DemandeServiceImmateriel newDmd);
        void RefusMat(ProposerServiceMateriel newMat);
        void RefusEvent(Evenement_Formation newEvent);



        void ModifierProfil(Utilisateur prof);
        void ModifierDmd(DemandeServiceImmateriel newDmd);
        void ModifierMat(ProposerServiceMateriel newMat);
        void ModifierEvent(Evenement_Formation newEvent);
        
        void SupprimerDmd(int id);
        void SupprimerMat(int id);
        void SupprimerEvent(int id);
        
        void ClasserDmd(int id);
        void ClasserMat(int id);
        void ClasserEvent(int id);


        MessagesViewModels ObtenirMessage(int userId, int destinataireId);
        List<MsgUserViewModel> ObtenirMessagerie(int userId);
        List<DemandeServiceImmateriel> RechService(string rech, int id);
        List<ProposerServiceMateriel> RechMateriel(string rech, int id);
        List<Evenement_Formation> RechEvenement(string rech, int id);
        List<DemandeServiceImmateriel> ObtenirListServicesImmateriel(int id);
        List<ProposerServiceMateriel> ObtenirListServicesMateriel(int id);
        List<Evenement_Formation> ObtenirListEvenement(int id);
        AllPost ObtenirPublicationAttenteAdmin();
        AllPost ObtenirPublicationLitigeAdmin();
        AllPost VoirNosPosts(int UserId);

        Utilisateur ObtenirUtilisateur(int UserId);
        Utilisateur ObtenirUtilisateur(string IdString);
        DemandeServiceImmateriel ObtenirServiceImmateriel(int id);
        ProposerServiceMateriel ObtenirServicesMateriel(int id);
        Evenement_Formation ObtenirEvenement(int id);


        // Voiture //

        List<Voiture> ObtenirVoiture();

        Voiture ObtenirVoiture(int id);

        int CreerVoiture(int utilisateurId, Marque marque, string modele, TypeEnergie energie, TypeBoite boite, int km, string annee, DateTime dispoDebut, DateTime dispoFin, int montantJour, int montantKm, string description, string imageName);

        void ModifierVoiture(int id, int utilisateurId, Marque marque, string modele, TypeEnergie energie, TypeBoite boite, int km, string annee, DateTime dispoDebut, DateTime dispoFin, int montantJour, int montantKm, string description, string imageName);

        void SupprimerVoiture(int id);

        List<Covoiturage> ObtenirCovoiturage();

        Covoiturage ObtenirCovoiturage(int id);

        int CreerCovoiturage(string villeDepart, string villeArrivee, string villeEtape, DateTime dateDepart, int nbPlace, int prix, string description);

        void ModifierCovoiturage(int id, int voitureId, string villeDepart, string villeArrivee, string villeEtape, DateTime dateDepart, int nbPlace, int prix, string description);

        void SupprimerCovoiturage(int id);

        // Location //

        List<Location> ObtenirLocation();

        public Location ObtenirLocation(int id);

        int CreerLocation(int utilisateurId, Rubrique rubrique);

        void ModifierLocation(int id, int utilisateurId, string titre, Rubrique rubrique);

        //void SupprimerLocation(int id);

        // Location Bien Matériel //

        List<BienMateriel> ObtenirBienMateriel();

        public BienMateriel ObtenirBienMateriel(int id);

        int CreerBienMateriel(int utilisateurId, string titre, DateTime dispoDebut, DateTime dispoFin, int montantJour, string description, string imageName);

        void ModifierBienMateriel(int id, int utilisateurId, string titre, DateTime dispoDebut, DateTime dispoFin, int montantJour, string description, string imageName);

        void SupprimerBienMateriel(int id);


        Utilisateur Authentifier(string prenom, string password);
        void DeleteCreateDatabase();


        //Ajout 
        List<Utilisateur> ObtenirUtilisateur();


        //A quoi sert le Tag ?
        List<Tag> ObtenirTag();
        int CreerTag(string Name, string Slug);

        //  void ModifierService(int id, string titre, Categorie categorie, string description, string budget, string imageName, int userId);

        // int CreerCommentaire(string email, string pseudo, string contenu, DateTime publication);
        //List<Commentaire> ObtenirCommentaire();
        /* Methodes et Model commentaire à modifier : Faire plutot un commentaire sur un profil après réalisation d'un service.
            Commentaire sur publication -> Plutot faire apparaitre les devis en attente de validation ou refus sur une publication ?
        */



    }

}
