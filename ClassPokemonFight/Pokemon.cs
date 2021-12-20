using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPokemonFight
{
    internal class Pokemon
    {
        //Properties
        string PokemonNameJthi = "";
        string TypeJthi = "";
        string TypeImagePathJthi = "";
        string ImgPathJthi = "";
        //Constructor
        public Pokemon(string c_PokemonNameJthi, string c_TypeJthi, string c_imagePathJthi)
        {
            PokemonNameJthi = c_PokemonNameJthi;
            TypeJthi = c_TypeJthi;
            TypeImagePathJthi = c_imagePathJthi;
        }
        //Get and set
        public string GetName()
        {
            return PokemonNameJthi;
        }

        public string GetType()
        {
            return TypeJthi;
        }

        public string GetAll()
        {
            return PokemonNameJthi + " " + TypeJthi;
        }

        public string GetImg()
        {
           // System.Drawing.Bitmap Fire = new System.Drawing.Bitmap(Properties.Resources.Fire);
            return TypeImagePathJthi;
        }


        //Methods
    }
}
