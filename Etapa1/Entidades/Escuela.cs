namespace CoreEscuela.Entidades 
{
    class Escuela 
    {

        string name;
        public string Name 
        {
            get {return "Copia de: " + name;} //De esta forma alguien podria preguntar por nombre. Pero no asignarlo.
            set {name=value.ToUpper();} // de esta forma pongo el nombre en mayuscula.
        }

        public int FundationYear {get;set;} // Hace lo mismo que la parte de arriba

        public string Country { get; set; }

        public string City { get; set; }

        /*public Escuela(string name, int year)
        {
            this.name = name; // El primer name,luego del trhis es miembro de la clase
            FundationYear = year;
        }*/

        public Escuela(string name, int year) => (Name, FundationYear) = (name, year); // Sintaxis del método constructor abreviado


    }
}
