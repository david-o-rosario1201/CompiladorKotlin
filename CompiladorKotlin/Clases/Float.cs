namespace CompiladorKotlin.Clases;

public class Float
{
	public string nombre { get; set; }
	public float valor { get; set; }

	public Float(string nombre, float valor)
	{
		this.nombre = nombre;
		this.valor = valor;
	}

	public Float(string nombre)
	{
		this.nombre = nombre;
	}
}
