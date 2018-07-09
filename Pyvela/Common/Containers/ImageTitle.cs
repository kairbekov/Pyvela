namespace Pyvela.Common.Containers
{
    class ImageTitle
    {
        public string Title { get; set; }
        public int Image { get; set; }

        public ImageTitle(string Title, int ImageResource)
        {
            this.Title = Title;
            this.Image = ImageResource;
        }

        public static ImageTitle[] ConvertFrom(string[] Titles, int[] Images)
        {
            if (Titles.Length == Images.Length)
            {
                int length = Titles.Length;
                ImageTitle[] imageTitles = new ImageTitle[length];
                for (int i = 0; i < length; i++)
                {
                    imageTitles[i] = new ImageTitle(Titles[i], Images[i]);
                }
                return imageTitles;
            }
            else
            {
                return null;
            }
        }
    }
}