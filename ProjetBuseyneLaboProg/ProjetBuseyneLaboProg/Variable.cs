using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace ProjetBuseyneLaboProg
{
    class Variable
    {
        public static string username;
        public static string password;
        public static OleDbConnection conn;
        public static OleDbCommand cmd;
        public static OleDbDataReader dtrd;

        public static string pseudoConnection;
        public static int listing;
        public static string RangeID;
        public static string RangeID2;
        public static int compteurEquipe = 0;
        public static string IDPremierTournoi;
        public static int langue = 0;

        public static int grade;

        public static char[] motNonCrypte;
        public static char[] motCrypte;
        public static string motStringCrypte;
    }

    class langage
    {
        public static string LogPageTitreFR = "Gestion de tournois de jeux";
        public static string LogPageTitreEN = "Gaming tournament managing";
        public static string LogPageUserFR = "Nom d'utilisateur : ";
        public static string LogPageUserEN = "Username :";
        public static string LogPagePasswordFR = "Mot de passe :";
        public static string LogPagePasswordEN = "Password :";
        public static string UniBoutonFermerFR = "Fermer";
        public static string UniBoutonFermerEN = "Close";
        public static string LogPageSeConnecterFR = "Se connecter";
        public static string LogPageSeConnecterEN = "Sign in";
        public static string LogPageSignUpFR = "Créer un compte";
        public static string LogPageSignUpEN = "Sign up";

        public static string UniConfirmerFR = "Confirmer";
        public static string UniConfirmerEN = "Confirm";
        public static string ReglageTitreFR = "Réglages";
        public static string ReglageTitreEN = "Settings";
        public static string ReglageLangueFR = "Langues";
        public static string ReglageLangueEN = "Language :";

        public static string PageAccueilTitreFR = "Gestion de tournois de jeux";
        public static string PageAccueilTitreEN = "Gaming tournament managing";
        public static string PageAccueilCréerOrgaFR = "Créer organisation";
        public static string PageAccueilCréerOrgaEN = "Create organisation";
        public static string PageAccueilCréerTournoiFR = "Créer tournoi";
        public static string PageAccueilCréerTournoiEN = "Create tournament";
        public static string PageAccueilVoirTournoiFR = "Voir les tournois";
        public static string PageAccueilVoirTournoiEN = "Show tournaments";
        public static string PageAccueilTopDesJeuxFR = "Top des jeux";
        public static string PageAccueilTopDesJeuxEN = "Top games";
        public static string PageAccueilGestionFR = "Gérer mon tournoi";
        public static string PageAccueilGestionEN = "Manage my tournament";
        public static string PageAccueilCloreFR = "Clore un tournoi";
        public static string PageAccueilCloreEN = "Close a tournament";

        public static string CreerOrgaTitreFR = "Création d'une organisation";
        public static string CreerOrgaTitreEN = "Create an organisation";
        public static string CreerOrgaNomFR = "Nom de l'organisation :";
        public static string CreerOrgaNomEN = "Name of the organisation : ";
        public static string CreerOrgaNomRespFR = "Nom du responsable :";
        public static string CreerOrgaNomRespEN = "Responsable name :";

        public static string CreerTournoiTitreFR = "Créer un tournoi";
        public static string CreerTournoiTitreEN = "Create a tournament";
        public static string CreerTournoiNomFR = "Nom du tournoi :";
        public static string CreerTournoiNomEN = "Name of the tournament :";
        public static string CreerTournoiTypeFR = "Type de tournoi :";
        public static string CreerTournoiTypeEN = "Tournament type :";

        public static string GestionTournoiTitreFR = "Gestion du tournoi";
        public static string GestionTournoiTitreEN = "Tournament managing";
        public static string GestionTournoiListeFR = "Tournois";
        public static string GestionTournoiListeEN = "Tournaments";
        public static string GestionTournoiRechercheTFR = "Recherche :";
        public static string GestionTournoiRechercheTEN = "Search :";
        public static string GestionTournoiNomTFR = "Nom :";
        public static string GestionTournoiNomTEN = "Name :";
        public static string GestionTournoiCalendrierFR = "Calendrier :";
        public static string GestionTournoiCalendrierEN = "Calendar :";
        public static string GestionTournoiRechercherFR = "Rechercher";
        public static string GestionTournoiRechercherEN = "Search";
        public static string GestionTournoiPrenomFR = "Prénom :";
        public static string GestionTournoiPrenomEN = "First name :";
        public static string GestionTournoiRangFR = "Rang :";
        public static string GestionTournoiRangEN = "Rank :";
        public static string GestionTournoiEquipeFR = "Equipe :";
        public static string GestionTournoiEquipeEN = "Team :";
        public static string GestionTournoiRajouterFR = "Rajouter";
        public static string GestionTournoiRajouterEN = "Add";

        public static string VoirTournoiTitreFR = "Liste des tournois";
        public static string VoirTournoiTitreEN = "Tournaments list";
        public static string VoirTournoiNomTFR = "Nom du tournoi :";
        public static string VoirTournoiNomTEN = "Tournament name :";
        public static string VoirTournoiTypeTFR = "Type de tournoi :";
        public static string VoirTournoiTypeTEN = "Tournament type :";
        public static string VoirTournoiListeFR = "Liste :";
        public static string VoirTournoiListeEN = "List :";

        public static string TopDesJeuxTitreFR = "Top des jeux";
        public static string TopDesJeuxTitreEN = "Top games";

        public static string CloreTournoiTitreFR = "Clore un tournoi";
        public static string CloreTournoiTitreEN = "Close tournament";
        public static string CloreTournoiTournoiListeFR = "Tournois :";
        public static string CloreTournoiTournoiListeEN = "Tournaments";
        public static string CloreTournoiRechercheFR = "Recherche :";
        public static string CloreTournoiRechercheEN = "Search :";
        public static string CloreTournoiNomTFR = "Nom :";
        public static string CloreTournoiNomTEN = "Name :";
        public static string CloreTournoiCalendrierFR = "Calendrier :";
        public static string CloreTournoiCalendrierEN = "Calendar :";
        public static string CloreTournoiPointsFR = "Attribuer les points aux équipes";
        public static string CloreTournoiPointsEN = "Assign points to teams";
        public static string CloreTournoiBTArchivesFR = "Voir les archives";
        public static string CloreTournoiBTArchivesEN = "View archives";
        public static string CloreTournoiBTCloreFR = "Clore le tournoi";
        public static string CloreTournoiBTCloreEN = "Close tournament";

        public static string CreerCompteTitreFR = "Création du compte";
        public static string CreerCompteTitreEN = "Create an account";
        public static string CreerCompteUserNameFR = "Nom de compte :";
        public static string CreerCompteUserNameEN = "Username :";
        public static string CreerCompteMDPFR = "Mot de passe :";
        public static string CreerCompteMDPEN = "Password :";
        public static string CreerCompteMDPAFR = "Retaper le mot de passe :";
        public static string CreerCompteMDPAEN = "Password again :";
        public static string CreerCompteBTRetourFR = "Retour";
        public static string CreerCompteBTRetourEN = "Back";

        public static string ArchivesTournoiFR = "Tournois";
        public static string ArchivesTournoiEN = "Tournaments";
        public static string ArchivesScoresFR = "Equipes et scores";
        public static string ArchivesScoresEN = "Teams and points";
        public static string ArchivesVainqueurFR = "Equipe vainqueur";
        public static string ArchivesVainqueurEN = "Winning team";
    }
}
