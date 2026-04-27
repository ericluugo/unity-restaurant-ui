using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comensal
{
    public string nombre;
    public List<IConsumible> platos;

    public Comensal(string nombre)
    {
        this.nombre = nombre;
        platos = new List<IConsumible>();
    }

    public void AgregarConsumible(IConsumible plato)
    {
        platos.Add(plato);
    }

    public List<IConsumible> GetPlatos()
    {
        return platos;
    }

    public void LimpiarMenu()
    {
        Debug.Log("Platos antes limpiar: " + platos.Count);
        platos.Clear();
        Debug.Log("platos clear");
        Debug.Log("Platos tras limpiar: " + platos.Count);
    }
}

