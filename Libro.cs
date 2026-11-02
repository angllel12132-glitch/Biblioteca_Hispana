
namespace Biblioteca_Hispana
{
    public class Libro : Material
    {
        public string Autor { get; }

        public Libro(string codigo, string titulo, string autor)
            : base(codigo, titulo)
        {
            Autor = autor;
        }

        public override int DiasDePrestamo => 14;

        public override decimal MultaPorDia => 10m;

        public override string Describir()
        {
            return base.Describir() + $" | Autor: {Autor}";
        }
    }
}
