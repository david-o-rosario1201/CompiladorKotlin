namespace CompiladorKotlin.Clases;

public class Long
{
	public string nombre { get; set; }
	public long valor { get; set; }

	public Long(string nombre, long valor)
	{
		this.nombre = nombre;
		this.valor = valor;
	}

	public Long(string nombre)
	{
		this.nombre = nombre;
	}
}
