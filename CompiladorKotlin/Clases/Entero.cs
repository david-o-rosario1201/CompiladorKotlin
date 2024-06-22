namespace CompiladorKotlin.Clases;

public class Entero
{
	public string nombre { get; set; }
	public int valor { get; set; }

	public Entero(string nombre, int valor)
	{
		this.nombre = nombre;
		this.valor = valor;
	}

	public Entero(string nombre)
	{
		this.nombre = nombre;
	}
}
