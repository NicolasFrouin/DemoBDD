using System;

namespace MetierBdd
{
    public class Categorie
    {
        public int NumCateg { get; set; }
        public string LibelleCateg { get; set; }
        public string PhotoCateg { get; set; }

        public Categorie(int unNum, string unLibelle, string unePhoto)
        {
            NumCateg = unNum;
            LibelleCateg = unLibelle;
            PhotoCateg = unePhoto;
        }
    }
}
