class Instancia
{
    public string Nombre;
    public string Version;
    public string SistemaOperativo;
    public int Estado; 
}

class InstanciaProceso : Instancia
{
    public string DatosOrigen;
    public string DatosFin;

    public void Levantar()
    {
        Estado = 1;
        Console.WriteLine("La instancia de proceso " + Nombre + " se levantó correctamente.");
        Console.WriteLine("Acceso a datos de origen: " + DatosOrigen);
        Console.WriteLine("Acceso a datos de fin: " + DatosFin);
    }

    public void Bajar()
    {
        Estado = 0;
        Console.WriteLine("La instancia de proceso " + Nombre + " se bajó.");
    }
}

class InstanciaAplicacion : Instancia
{
    public string Lenguaje;
    public string VersionLenguaje;
    public string BaseDatos;

    public void Levantar()
    {
        Estado = 1;
        Console.WriteLine("La instancia de aplicación " + Nombre + " se levantó correctamente.");
        Console.WriteLine("Lenguaje instalado: " + Lenguaje + " versión " + VersionLenguaje);
        Console.WriteLine("Acceso a base de datos: " + BaseDatos);
    }

    public void Bajar()
    {
        Estado = 0;
        Console.WriteLine("La instancia de aplicación " + Nombre + " se bajó.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Instancia[] maquinas = new Instancia[4];

        maquinas[0] = new InstanciaProceso()
        {
            Nombre = "Misiones",
            Version = "1.0",
            SistemaOperativo = "Linux",
            DatosOrigen = "origen-db",
            DatosFin = "fin-db"
        };

        maquinas[1] = new InstanciaProceso()
        {
            Nombre = "BS AS",
            Version = "1.1",
            SistemaOperativo = "Linux",
            DatosOrigen = "entrada",
            DatosFin = "salida"
        };

        maquinas[2] = new InstanciaAplicacion()
        {
            Nombre = "Jardin America",
            Version = "2.0",
            SistemaOperativo = "Windows",
            Lenguaje = "C#",
            VersionLenguaje = "9.0",
            BaseDatos = "sql-server"
        };

        maquinas[3] = new InstanciaAplicacion()
        {
            Nombre = "Tabay",
            Version = "2.1",
            SistemaOperativo = "Linux",
            Lenguaje = "Python",
            VersionLenguaje = "3.10",
            BaseDatos = "mongo-db"
        };

        
        Console.WriteLine("\n=== LEVANTANDO ===\n");
        foreach (var m in maquinas)
        {
            if (m is InstanciaProceso)
                ((InstanciaProceso)m).Levantar();
            else
                ((InstanciaAplicacion)m).Levantar();

            Console.WriteLine();
        }

        
        Console.WriteLine("\n=== BAJANDO ===\n");
        foreach (var m in maquinas)
        {
            if (m is InstanciaProceso)
                ((InstanciaProceso)m).Bajar();
            else
                ((InstanciaAplicacion)m).Bajar();
        }

        Console.WriteLine("\nFin del programa.");
    }
}
