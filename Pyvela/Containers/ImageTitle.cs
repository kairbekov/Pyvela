namespace Pyvela.Containers
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
    }

}