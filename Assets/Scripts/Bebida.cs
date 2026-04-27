using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bebida : IConsumible
{
    public string nombre;
    public float precio;

    public Bebida(string nombre, float precio)
    {
        this.nombre = nombre;
        this.precio = precio;
    }

    public string GetNombre() => nombre;
    public float GetPrecio() => precio;
    public TipoConsumible GetTipo() => TipoConsumible.Bebida;
}

