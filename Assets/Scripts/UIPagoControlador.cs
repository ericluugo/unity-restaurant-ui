using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIPagoControlador : MonoBehaviour
{
    public ControladorPrincipal controlador;
    public UIPantallasControlador pantallas;

    public TextMeshProUGUI miCesta;
    public TextMeshProUGUI precioFinal;
    // Start is called before the first frame update

    public void updateCesta()
    {
        miCesta.text = controlador.cesta();
        precioFinal.text = controlador.calculoPrecio();
    }

    public void ocultarPrecio()
    {
        precioFinal.text = "";
    }

    public void mostrarPrecio()
    {
        precioFinal.text = controlador.calculoPrecio();
    }
}
