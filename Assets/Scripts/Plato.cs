using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plato : IConsumible
{
    public string nombre;
    public float precio;
    public TipoConsumible tipo;

    public Plato(string nombre, float precio, TipoConsumible tipo)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.tipo = tipo;
    }

    public string GetNombre() => nombre;
    public float GetPrecio() => precio;
    public TipoConsumible GetTipo() => tipo;
}

