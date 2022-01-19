$("#ChoisirCategorie").change(function () {
    var valueselected = $("#ChoisirCategorie").val();

    if (valueselected == "Demande de Service") {
        $("#DemandeService").show();
        $("#ProposerMateriel").hide();
        $("#Evenement").hide();
        $("#Location").hide();
    }
    else if (valueselected == "Vendre un objet") {
        $("#DemandeService").hide();
        $("#ProposerMateriel").show();
        $("#Evenement").hide();
        $("#Location").hide();
    }
    else if (valueselected == "Proposer un évenement") {
        $("#DemandeService").hide();
        $("#ProposerMateriel").hide();
        $("#Evenement").show();
        $("#Location").hide();
    }
    else if (valueselected == "Proposer une Location") {
        $("#DemandeService").hide();
        $("#ProposerMateriel").hide();
        $("#Evenement").hide();
        $("#Location").show();
    }
    else {
        $("#DemandeService").hide();
        $("#ProposerMateriel").hide();
        $("#Evenement").hide();
        $("#Location").hide();
    }
});



$("#CategorieRecherche").change(function () {
    var valueselected = $("#CategorieRecherche").val();

    if (valueselected == "Les Demandes de Service") {
        $("#Dmd").show();
        $("#Mat").hide();
        $("#Event").hide();
        $("#Location").hide();
    }
    else if (valueselected == "Objets à Vendre") {
        $("#Dmd").hide();
        $("#Mat").show();
        $("#Event").hide();
        $("#Location").hide();
    }
    else if (valueselected == "Evenements et Formations") {
        $("#Dmd").hide();
        $("#Mat").hide();
        $("#Event").show();
        $("#Location").hide();
    }
    else if (valueselected == "Les Locations") {
        $("#Dmd").hide();
        $("#Mat").hide();
        $("#Event").hide();
        $("#Location").show();
    }
    else {
        $("#Dmd").hide();
        $("#Mat").hide();
        $("#Event").hide();
        $("#Location").hide();
    }
});
