using System;
using System.Text;

namespace PixabaySharp.Utility
{
    public class ImageQueryBuilder
    {
        public string Query { get; set; }
        public Lang? Language { get; set; }
        public string Id { get; set; }
        public ResponseGroup? ResponseGroup { get; set; }
        public ImageType? ImageType{ get; set; }
        public Orientation? Orientation { get; set; }
        public Category? Category { get; set; }
        public int? MinWidth { get; set; }
        public int? MinHeight { get; set; }
        public bool? IsEditorsChoice { get; set; }
        public bool? IsSafeSearch { get; set; }
        public Order? Order { get; set; }
        public int? Page { get; set; }
        public int? PerPage { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();
            // Build query string

            if (!String.IsNullOrEmpty(Query))
            {
                sb.Append($"&q={HttpTools.UriEncode(Query)}");
            }
            if (Language != null)
            {
                sb.Append($"&lang={Language.ToString().ToLower()}");
            }
            if (!String.IsNullOrEmpty(Id))
            {
                sb.Append($"&id={Id}");
            }
            if(ResponseGroup != null)
            {
                if(ResponseGroup == Utility.ResponseGroup.HighResolution)
                    sb.Append($"&response_group=high_resolution");
                else
                    sb.Append($"&response_group=image_details");
            }
            if (ImageType != null)
            {
                sb.Append($"&image_type={ImageType.ToString().ToLower()}");
            }
            if (Orientation != null)
            {
                sb.Append($"&orientation={Orientation.ToString().ToLower()}");
            }
            if (Category != null)
            {
                sb.Append($"&category={Category.ToString().ToLower()}");
            }
            if(MinWidth != null && MinWidth != 0)
            {
                sb.Append($"&min_width={MinWidth.ToString().ToLower()}");
            }
            if (MinHeight != null && MinHeight != 0)
            {
                sb.Append($"&min_height={MinHeight.ToString().ToLower()}");
            }
            if(IsEditorsChoice != null)
            {
                sb.Append($"&editors_choice={IsEditorsChoice.ToString().ToLower()}");
            }
            if(IsSafeSearch != null)
            {
                sb.Append($"&safesearch={IsSafeSearch.ToString().ToLower()}");
            }
            if (Order != null)
            {
                sb.Append($"&order={Order.ToString().ToLower()}");
            }
            if (Page != null)
            {
                sb.Append($"&page={Page}");
            }
            if (PerPage != null)
            {
                sb.Append($"&per_page={PerPage}");
            }

            return sb.ToString();
        }
    }

    


    public enum Lang
    {
        CS, DA, DE, EN, ES, FR, ID, IT, HU, NL, NO, PL, PT, RO, SK, FI, SV, TR, VI, TH, BG, RU, EL, JA, KO, ZH
    }

    public enum ResponseGroup
    {
        ImageDetails, HighResolution
    }

    public enum ImageType
    {
        All, Photo, Illustration, Vector 
    }

    public enum Orientation
    {
        All, Horizontal, Vertical 
    }

    public enum Category
    {
        Fashion, Nature, Backgrounds, Science, Education, People, Feelings, Religion, Health, Places, Animals, Industry, Food, Computer, Sports, Transportation, Travel, Buildings, Business, Music
    }

    public enum Order
    {
        Popular, Latest
    }
}
