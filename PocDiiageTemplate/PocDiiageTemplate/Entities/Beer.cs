using System;
using System.Collections.Generic;
using System.Text;

namespace PocDiiageTemplate
{
    public class Beer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string tagline { get; set; }
        public string first_brewed { get; set; }
        public string description { get; set; }
        public string image_url { get; set; }
        public double abv { get; set; }
        public int ibu { get; set; }
        public int target_fg { get; set; }
        public int target_og { get; set; }
        public int ebc { get; set; }
        public int srm { get; set; }
        public double ph { get; set; }
        public int attenuation_level { get; set; }
        public Volume volume { get; set; }
        public BoilVolume boil_volume { get; set; }
        public Method method { get; set; }
        public Ingredients ingredients { get; set; }
        public List<string> food_pairing { get; set; }
        public string brewers_tips { get; set; }
        public string contributed_by { get; set; }
    }
}
