public class Persona
{
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public int Edad { get; set; }
}

public class MiembroDeLaComunidad : Persona
{

}

public class Empleado : MiembroDeLaComunidad
{

}

public class Estudiante : MiembroDeLaComunidad
{

}

public class ExAlumno : MiembroDeLaComunidad
{

}

public class Docente : Empleado
{

}

public class Administrativo : Empleado
{

}

public class Administrador : Docente
{

}

public class Maestro : Docente
{

}
