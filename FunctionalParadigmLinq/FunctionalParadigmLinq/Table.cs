namespace FunctionalParadigmLinq
{
    internal class Table
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public float Length { get; set; }

        public Table() { }
        public Table(float w, float l, float h)
        {
            Width = w;
            Length = l;
            Height = h;
        }
        public float CalculateArea(float w, float l)
        {
            return w * l;
        }
    }
}