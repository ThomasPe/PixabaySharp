namespace PixabaySharp.Enums
{
    /// <summary>
    /// Choose between retrieving high resolution images and image details. 
    /// 
    /// </summary>
    public enum ResponseGroup
    {
        /// <summary>
        /// Access images up to a dimension of 960 x 720 px. 
        /// </summary>
        ImageDetails,

        /// <summary>
        /// Access images greater than a dimension of 960 x 720 px. 
        /// </summary>
        HighResolution
    }
}
