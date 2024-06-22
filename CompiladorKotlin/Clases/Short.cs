namespace CompiladorKotlin.Clases;

public class Short
{
	public string nombre { get; set; }
	public short valor { get; set; }

	public Short(string nombre, short valor)
	{
		this.nombre = nombre;
		this.valor = valor;
	}

	public Short(string nombre)
	{
		this.nombre = nombre;
	}
}
