﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class save_var : MonoBehaviour
{
   
    public int difficulty;
    public static save_var Instance;


    private void Awake()
    {
        Instance = this;
    }

    public string[] eng = {"SETTINGS",
        "PLAY",
        "CHOOSE THE EMOTION THAT YOU WANT",
        "ASK THE OTHER PLAYERS TO SHOW YOU THE EMOTION CARD YOU CHOSE. DID ANYBODY FOUND IT?",
        "NO",
        "YES",
        "ASK THEM TO TELL A STORY ABOUT IT",
        "NEXT",
        "WHO TOLD THE MOST RELEVANT STORY?",
        "NEXT",
        "GIVE THE TABLET TO THE NEXT PLAYER",
        "NEXT",
        "LANGUAGE",
        "VOLUME",
        "DIFFICULTY LEVEL",
        "EASY",
        "DIFFICULT",
        "BACK",
        "BACK",
        "BACK",
        "BACK",
        "HAPPY",
        "SAD",
        "ANGER",
        "SURPRISE",
        "FEAR",
        "DISGUSTE",
        "HAPPY",
        "SAD",
        "ANGER",
        "SURPRISE",
        "FEAR",
        "DISGUSTE",
        "CHOOSE CHARACTER",
        "BACK" };

   

    public string[] gre = {
        "ΡΥΘΜΙΣΕΙΣ",
        "ΠΑΙΧΝΙΔΙ",
        "ΠΑΤΑ ΣΤΗΝ ΚΑΡΤΑ ΣΥΝΑΙΣΘΗΜΑΤΟΣ ΠΟΥ ΘΕΛΕΙΣ",
        "ΖΗΤΑ ΝΑ ΣΟΥ ΔΕΙΞΟΥΝ ΤΗΝ ΚΑΡΤΑ ΣΥΝΑΙΣΘΗΜΑΤΟΣ ΠΟΥ ΔΙΑΛΕΞΕΣ. ΤΗ ΒΡΗΚΕ ΚΑΠΟΙΟΣ;",
        "ΟΧΙ",
        "ΝΑΙ",
        "ΖΗΤΑ ΣΕ ΟΣΟΥΣ ΒΡΗΚΑΝ ΤΟ ΣΥΝΑΙΣΘΗΜΑ ΝΑ ΠΟΥΝ ΜΙΑ ΣΧΕΤΙΚΗ ΙΣΤΟΡΙΑ",
        "ΕΠΟΜΕΝΟ",
        "ΠΟΙΟΣ ΕΙΠΕ ΤΗΝ ΚΑΛΥΤΕΡΗ ΙΣΤΟΡΙΑ ?",
        "ΕΠΟΜΕΝΟ",
        "ΔΩΣΕ ΣΤΟΝ ΕΠΟΜΕΝΟ ΠΑΙΚΤΗ ΤΟ TABLET",
        "ΕΠΟΜΕΝΟ",
        "ΓΛΩΣΣΑ",
        "ΕΝΤΑΣΗ ΗΧΟΥ",
        "ΕΠΙΠΕΔΟ ΔΥΣΚΟΛΙΑΣ",
        "ΕΥΚΟΛΟ",
        "ΔΥΣΚΟΛΟ",
        "ΠΙΣΩ",
        "ΠΙΣΩ",
        "ΠΙΣΩ",
        "ΠΙΣΩ",
        "ΧΑΡΑ",
        "ΛΥΠΗ",
        "ΘΥΜΟΣ",
        "ΕΚΠΛΗΞΗ",
        "ΦΟΒΟΣ",
        "ΑΗΔΙΑ",
        "ΧΑΡΑ",
        "ΛΥΠΗ",
        "ΘΥΜΟΣ",
        "ΕΚΠΛΗΞΗ",
        "ΦΟΒΟΣ",
        "ΑΗΔΙΑ",
        "ΔΙΑΛΕΞΕ ΧΑΡΑΚΤΗΡΑ",
        "ΠΙΣΩ",
        "ΠΛΗΡΟΦΟΡΙΕΣ"};

    public string[] rom =
    {   "SETARI",
        "JOACĂ",
        "ALEGE EMOȚIA PE CARE O DOREȘTI",
        "CERE-LE CELORLAȚI JUCĂTORI SĂ VĂ ARATE CARDUL CU EMOȚIE PE CARE L-AI ALES. L-A GĂSIT CINEVA ?",
        "NU",
        "DA",
        "CERE-LE SĂ SPUNĂ O POVESTE DESPRE EA",
        "URMĂTORUL",
        "CINE A SPUS CEA MAI RELEVANTĂ POVESTE?",
        "URMĂTORUL",
        "DĂ TABLETA URMĂTORULUI JUCĂTOR",
        "URMĂTORUL",
        "IN CE LIMBA",
        "STABILEȘTE VOLUMUL",
        "NIVELUL DE DIFICULTATE",
        "UȘOR",
        "DIFICIL",
        "ÎNAPOI",//OR SPATE
        "ÎNAPOI",
        "ÎNAPOI",
        "ÎNAPOI",
        "FERICIT",
        "TRIST",
        "FURIE",
        "SURPRIZĂ",
        "FRICĂ",
        "DEZGUST",
        "FERICIT",
        "TRIST",
        "FURIE",
        "SURPRIZĂ",
        "FRICĂ",
        "DEZGUST",
        "ALEGE CÂȚI JUCĂTORI VOR JUCA",
        "ÎNAPOI","INFORMATII"
    };

   public string[] italian=
    {
        "IMPOSTAZIONI",//1
        "GIOCARE",//
        "SCEGLI L’EMOZIONE CHE VUOI",
        "CHIEDI AI GIOCATORI DI MOSTARTI LA CARTA CON L’ EMOZIONE CHE HANNO SCELTO. QUALCUNO HA TROVATO QUELLA GIUSTA?",
        "NO",
        "SI",
        "CHIEDI A LORO DI RACCONTARE UNA STORIA",
        "IL PROSSIMO",
        "CHI DICE LA STORIA PIÙ RILEVANTE?",
        "IL PROSSIMO",
        "DARE IL TABLET AL PROSSIMO GIOCATORE",
        "IL PROSSIMO",
        "LE LINGUE",
        "VOLUME",
        "LIVELLO DI DIFFICOLTÀ",
        "FELICITA’",
        "DIFFICILE",
        "INDIETRO",
        "INDIETRO",
        "INDIETRO",
        "INDIETRO",
        "FELICITA’",
        "TRISTEZZA",
        "RABBIA",
        "SORPRESA",
        "PAURA",
        "DISGUSTO",
        "FELICITA’",
        "TRISTEZZA",
        "RABBIA",
        "SORPRESA",
        "PAURA",
        "DISGUSTO",
        "SCEGLI QUANTI GIOCATORI GIOCHERANNO",//not sure
        "INDIETRO"};//35


    public string[] italian2 =
   {
        "IMPOSTAZIONI",//1
        "GIOCARE",//
        "SCEGLI L’EMOZIONE CHE VUOI",
        "CHIEDI AI GIOCATORI DI MOSTARTI LA CARTA CON L’ EMOZIONE CHE HANNO SCELTO. QUALCUNO HA TROVATO QUELLA GIUSTA?",
        "NO",
        "SI",
        "CHIEDI A LORO DI RACCONTARE UNA STORIA",
        "IL PROSSIMO",
        "CHI DICE LA STORIA PIÙ RILEVANTE?",// <---- this text is removed
        "IL PROSSIMO",
        "DARE IL TABLET AL PROSSIMO GIOCATORE",
        "IL PROSSIMO",
        "LE LINGUE",
        "VOLUME",
        "LIVELLO DI DIFFICOLTÀ",
        "FACILE",
        "DIFFICILE",
        "INDIETRO",
        "INDIETRO",
        "INDIETRO",
        "INDIETRO",
        "FELICITA’",
        "TRISTEZZA",
        "RABBIA",
        "SORPRESA",
        "PAURA",
        "DISGUSTO",
        "FELICITA’",
        "TRISTEZZA",
        "RABBIA",
        "SORPRESA",
        "PAURA",
        "DISGUSTO",
        "SCEGLI QUANTI GIOCATORI GIOCHERANNO",// changed to Scegli il personaggio
        "INDIETRO"};//35

}



