namespace ShapeWorld.Domain.Models
{
    public class Triangle : Shape
    {
        public virtual double Base { get; set; }
        public virtual double Height { get; set; }

        public override double Surface()
        {
            return (Base * Height) / 2;
        }

        // public new double Volume()
        // {
        //     return 1234;
        // }
        public Triangle() : base(2) { }
    }
}