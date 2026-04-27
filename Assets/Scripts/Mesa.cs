using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections.Generic;

public class Mesa
{
    public List<Comensal> comensales = new List<Comensal>();

    public void AgregarComensal(Comensal c)
    {
        comensales.Add(c);
    }

    public List<Comensal> GetComensales()
    {
        return comensales;
    }
}

