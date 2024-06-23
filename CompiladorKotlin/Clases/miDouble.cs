namespace CompiladorKotlin.Clases;

public class miDouble
{
	public string nombre { get; set; }
	public double valor { get; set; }

	public miDouble(string nombre, double valor)
	{
		this.nombre = nombre;
		this.valor = valor;
	}

	public miDouble(string nombre)
	{
		this.nombre = nombre;
	}
}
