﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil
//     Les modifications apportées à ce fichier seront perdues si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------
namespace PMonteurPartie
{
	using System;
    using PJoueur;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
    using PPartie;

	public class CreateurPartie
	{
        // monteur de la partie
		public MonteurCreationPartieAbstraite _monteur
		{
			get;
			set;
		}

        // pour fabriquer une partie
		public void construire(int taille, List<Joueur> liste)
		{
            _monteur.creerNouvellePartie(taille, liste);
		}

        // obtenir partie
        public Partie getPartie()
        {
            return _monteur.recupererPartie();
        }

        // constructeur
		public CreateurPartie()
		{
            _monteur = new MonteurCreationPartie();
		}

	}
}

