using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIComensalesControlador : MonoBehaviour
{
    public ControladorPrincipal controlador;
    public GameObject panel1, panel2, panel3, panel4;
    public Button empezarPedido;
    public int cantidadComensales;
    
    public void MostrarComensales(int cantidad)
    {
        if (cantidad >= 1) controlador.comensal1 = new Comensal("Comensal 1");
        if (cantidad >= 2) controlador.comensal2 = new Comensal("Comensal 2");
        if (cantidad >= 3) controlador.comensal3 = new Comensal("Comensal 3");
        if (cantidad >= 4) controlador.comensal4 = new Comensal("Comensal 4");
        actualizarEmpezarPedido();
        panel1.SetActive(cantidad >= 1);
        panel2.SetActive(cantidad >= 2);
        panel3.SetActive(cantidad >= 3);
        panel4.SetActive(cantidad >= 4);
        cantidadComensales = cantidad;
    }

    public void actualizarEmpezarPedido()
    {
        if(controlador.comensal1 != null)
        {
            empezarPedido.interactable = true;
        }
    }

    public Button modificarMenu1, modificarMenu2, modificarMenu3, modificarMenu4, elegirMenu1, elegirMenu2, elegirMenu3, elegirMenu4;
    
    public void DesactivarBotonesModificar()
    {
        modificarMenu1.interactable = false;
        modificarMenu2.interactable = false;
        modificarMenu3.interactable = false;
        modificarMenu4.interactable = false;
    }

    public void ActivarBotonesElegir()
    {
        elegirMenu1.interactable = true;
        elegirMenu2.interactable = true;
        elegirMenu3.interactable = true;
        elegirMenu4.interactable = true;
    }

    public void MarcarComensalComoFinalizado(Comensal comensal)
    {
        if (comensal == controlador.comensal1)
        {
            elegirMenu1.interactable = false;
            modificarMenu1.interactable = true;
        }
        else if (comensal == controlador.comensal2)
        {
            elegirMenu2.interactable = false;
            modificarMenu2.interactable = true;
        }
        else if (comensal == controlador.comensal3)
        {
            elegirMenu3.interactable = false;
            modificarMenu3.interactable = true;
        }
        else if (comensal == controlador.comensal4)
        {
            elegirMenu4.interactable = false;
            modificarMenu4.interactable = true;
        }
    }
}

