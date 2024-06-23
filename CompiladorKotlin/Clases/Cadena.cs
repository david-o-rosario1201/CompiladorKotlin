namespace CompiladorKotlin.Clases;

public class Cadena
{
	public string nombre { get; set; }
	public string valor { get; set; }

	public Cadena(string nombre, string valor)
	{
		this.nombre = nombre;
		this.valor = valor;
	}

	public Cadena(string nombre)
	{
		this.nombre = nombre;
	}
}
