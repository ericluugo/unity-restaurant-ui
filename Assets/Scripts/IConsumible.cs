using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IConsumible
{
    string GetNombre();
    float GetPrecio();
    TipoConsumible GetTipo();
}

