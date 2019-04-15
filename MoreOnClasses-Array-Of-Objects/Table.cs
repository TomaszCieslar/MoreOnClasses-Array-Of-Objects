namespace MoreOnClasses_Array_Of_Objects
{
    internal class Table
    {
        private float width;
        private float height;

        public Table()
        {

        }

        public Table(float w, float h)
        {
            this.width = w;
            this.height = h;
        }

        public float Width { get; set; }
        public float Height { get; set; }


        public void ShowData()
        {
            System.Console.WriteLine("Width: {0}, Height {1}", width, height);
        }
    }
}