namespace ListaDeEmpleados;

public class Empleado{
    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public DateTime Nacimiento { get; set; }

    public char EstadoCivil { get; set; }

    public char Genero { get; set; }

    public DateTime Ingreso { get; set; }

    public double sueldo { get; set; }

    public enum cargos { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador }

    public cargos Cargo { get; set; }

    public DateTime calcularAntiguedad(DateTime ingreso)
    {
        DateTime actual = DateTime.Now;
        int anio = actual.Year - ingreso.Year;
        int mes = actual.Month - ingreso.Month;
        if(mes < 0) 
        { 
            anio -= 1; 
            mes += 12; 
        }
        int dia = actual.Day - ingreso.Day;
        if(dia < 0)
        {
            mes -= 1;
            if(mes < 0)
            {
                anio -= 1;
                mes += 12;
            }
            
            dia += 30; 
        }
        DateTime antiguedad = new DateTime(anio, mes, dia);
        return antiguedad;
    }

    public DateTime calcularEdad(DateTime nacimiento)
    {
        DateTime actual = DateTime.Now;
        int anio = actual.Year - nacimiento.Year;
        int mes = actual.Month - nacimiento.Month;
        if(mes < 0) 
        { 
            anio -= 1; 
            mes += 12; 
        }
        int dia = actual.Day - nacimiento.Day;
        if(dia < 0)
        {
            mes -= 1;
            if(mes < 0)
            {
                anio -= 1;
                mes += 12;
            }
            dia += 30; 
        }
        DateTime edad = new DateTime(anio, mes, dia);
        return edad;
    }

    public DateTime calcularJubilacion(DateTime nacimiento, char genero)
    {
        DateTime edad = calcularEdad(nacimiento);
        int anio, mes = 12 - edad.Month, dia = 30 - edad.Day;
        if(genero == 'F')
        {
            anio = 60 - edad.Year;
        }
        else
        {
            anio = 65 - edad.Year;
        }
        DateTime jubilacion = new DateTime(anio-1, mes, dia);
        return jubilacion;
    }

    public void salario(double sueldo, DateTime antiguedad, cargos Cargo, char estado)
    {
        double salario;
        if(antiguedad.Year < 20)
        {
            salario = sueldo * (0.01 * antiguedad.Year);
        }
        else
        {
            salario = sueldo * 0.25;
        }
        if(Cargo == Empleado.cargos.Ingeniero || Cargo == Empleado.cargos.Especialista)
        {
            salario *= 1.5;
        }
        if(estado == 'C')
        {
            salario += 15000;
        }
        salario += sueldo;
        Console.WriteLine($"El salario es de {salario}");
    }
}