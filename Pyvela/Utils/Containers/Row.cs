namespace Pyvela.Utils.Containers
{
    class Row
    {
        //private string Column1 = "auto_increment"
        public string Column2 { get; set; }
        public string Column3 { get; set; }
        public string Column4 { get; set; }

        public Row(string Column2, string Column3, string Column4)
        {
            this.Column2 = Column2;
            this.Column3 = Column3;
            this.Column4 = Column4;
        }
    }
}