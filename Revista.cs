
namespace Biblioteca_Hispana
{
    public class Revista : Material
    {
        public int NumeroEdicion { get; }

        public Revista(string codigo, string titulo, int numeroEdicion)
            : base(codigo, titulo)
        {
            NumeroEdicion = numeroEdicion;
        }

        public override int DiasDePrestamo => 5;

        public override decimal MultaPorDia => 5m;

        public override string Describir()
        {
            return base.Describir() + $" | Edición: {NumeroEdicion}";
        }
    }
}
