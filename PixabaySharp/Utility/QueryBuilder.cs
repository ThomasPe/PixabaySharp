using System;
using System.Collections.Generic;
using System.Text;

namespace PixabaySharp.Utility
{
    public class QueryBuilder
    {
        public string Query { get; set; }
        public Lang Language { get; set; }
        public string Id { get; set; }
        public ResponseGroup ResponseGroup { get; set; }
        public ImageType ImageType{ get; set; }
        public Orientation Orientation { get; set; }
        public Category Category { get; set; }
        public int MinWidth { get; set; }
        public int MinHeight { get; set; }
        public bool IsEditorsChoice { get; set; }
        public bool IsSafeSearch { get; set; }
        public Order Order { get; set; }
        public int Page { get; set; }
        public int PerPage { get; set; }


        public override string ToString()
        {
            // Build query string
            return "";
        }
    }

    


    public enum Lang
    {
        cs, da, de, en, es, fr, id, it, hu, nl, no, pl, pt, ro, sk, fi, sv, tr, vi, th, bg, ru, el, ja, ko, zh
    }

    public enum ResponseGroup
    {
        ImageDetails, HighResolution
    }

    public enum ImageType
    {
        all, photo, illustration, vector 
    }

    public enum Orientation
    {
        all, horizontal, vertical 
    }

    public enum Category
    {
        fashion, nature, backgrounds, science, education, people, feelings, religion, health, places, animals, industry, food, computer, sports, transportation, travel, buildings, business, music
    }

    public enum Order
    {
        popular, latest
    }
}
