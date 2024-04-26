namespace ModeloDatos
{
    public class Pagina
    {
        public Pagina()
        {
            Titulo = String.Empty;
            Contenido = String.Empty;
            FechaPublicacion = String.Empty;
            Tematicas = new List<string>();
        }

        public  string Titulo { get; set; }
        
        public string Contenido { get; set; }

        public string FechaPublicacion { get; set; }

        public  List<string> Tematicas { get; set; }

    }
}