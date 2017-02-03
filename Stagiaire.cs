using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ift229;

namespace TP1
{
    class Stagiaire
    {
        public Regex m_RegexTéléphone = new Regex("^\\d{3}-\\d{3}-\\d{4}$");


        public Stagiaire(int p_IdStagiaire, string p_Nom, string p_Téléphone, List<Stage> p_MonListeDeStages)
        {
            this.IdStagiaire = p_IdStagiaire;
            this.Nom = p_Nom;
            this.téléphone =p_Téléphone;

        }
        public int IdStagiaire
        {
            get
            {
                return this.m_IdStagiaire;
            }
            set
            {
                Assertion.Précondition(value > 0, "Votre numéro est inférieur à zéro, il faut saisir des nombres supérieurs à zéro.");
                this.m_IdStagiaire = value;

            }
        }

        public string Nom
        {
            get
            {
                return this.m_Nom;

            }
            set
            {
                Assertion.Précondition(!string.IsNullOrEmpty(value), "La chaîne de caractère est vide");
                this.m_Nom = value;
            }

        }
        
        public string téléphone
        {
            get
            {
                return this.m_Téléphone;

            }

            set
            {
                
                Assertion.Précondition(!this.m_RegexTéléphone.IsMatch(value), "Mauvais format");
                this.m_Téléphone = value;
            }
        }

        private int m_IdStagiaire;
        private string m_Nom;
        private string m_Téléphone;
        private List<Stage> m_MonListeDeStages;
       
    }
}
