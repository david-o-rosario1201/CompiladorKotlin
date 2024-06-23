namespace CompiladorKotlin.Clases;

public class miBoolean
{
	public string nombre { get; set; }
	public bool valor { get; set; }

	public miBoolean(string nombre, bool valor)
	{
		this.nombre = nombre;
		this.valor = valor;
	}

	public miBoolean(string nombre)
	{
		this.nombre = nombre;
	}
}
