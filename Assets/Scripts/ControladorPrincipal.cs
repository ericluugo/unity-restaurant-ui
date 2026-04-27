using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControladorPrincipal : MonoBehaviour
{
    public UIPantallasControlador pantallas;
    public UIComensalesControlador comensalesUI;
    public MenuControlador menu;
    public UIEstadosContrlador estados;
    public Mesa mesa;

    public TextMeshProUGUI miCesta;
    


    public Comensal comensal1;
    public Comensal comensal2;
    public Comensal comensal3;
    public Comensal comensal4;
    public Button enviarPedido;
    public GameObject panelCafes;

    private Comensal turnoComensal;

    void Start()
    {
        ResetearSistema();

    }

    public void cambiarInicioAComensal()
    {
        pantallas.MostrarPantallaComensales();
        comensalesUI.DesactivarBotonesModificar();
    }

    public void ElegirMenu(int turno)
    {
        Debug.Log("ElegirMenu ejecutado con index = " + turno);
        switch (turno)
        {
            case 1:
                turnoComensal = comensal1;
                break;
            case 2:
                turnoComensal = comensal2;
                break;
            case 3:
                turnoComensal = comensal3;
                break;
            case 4:
                turnoComensal = comensal4;
                break;
        }
        Debug.Log("turnoComensal asignado a: " + turnoComensal);

        pantallas.MostrarPrimeros();
    }

    public void ModificarMenu(int turno)
    {
        Debug.Log("ElegirMenu ejecutado con index = " + turno);
        switch (turno)
        {
            case 1:
                turnoComensal = comensal1;
                break;
            case 2:
                turnoComensal = comensal2;
                break;
            case 3:
                turnoComensal = comensal3;
                break;
            case 4:
                turnoComensal = comensal4;
                break;
        }

        turnoComensal.LimpiarMenu();

        Debug.Log("turnoComensal asignado a: " + turnoComensal);

        pantallas.MostrarPrimeros();
    }

    public void AgregarConsumible(IConsumible item)
    {
        turnoComensal.AgregarConsumible(item);
    }

    public void FinalizarMenu()
    {
        if (!mesa.comensales.Contains(turnoComensal))
        {
            mesa.AgregarComensal(turnoComensal);
        }

        comensalesUI.MarcarComensalComoFinalizado(turnoComensal);
        miCesta.text = cesta();
        actualizarEnviarPedido();
        pantallas.MostrarPantallaComensales();
        panelCafes.SetActive(false);
    }

    public void actualizarEnviarPedido()
    {
        if(mesa.comensales.Count == comensalesUI.cantidadComensales)
        {
            enviarPedido.interactable = true;
        }
    }

    public string cesta()
    {
        string resultado = "";

        for (int i = 0; i < mesa.comensales.Count; i++)
        {
            var com = mesa.comensales[i];
            resultado += com.nombre+ "\n";

            foreach (var c in com.platos)
            {
                resultado += $" - {c.GetNombre()} {c.GetPrecio()}€\n";
            }

            resultado += "\n"; // separación entre comensales
        }
        Debug.Log(resultado);
        return resultado;
    }

    public string cestaPorTipo(TipoConsumible tipo)
    {
        string resultado = "";

        foreach (var com in mesa.comensales)
        {
            resultado += com.nombre + "\n";

            foreach (var c in com.platos)
            {
                if (c.GetTipo() == tipo)
                    resultado += $" - {c.GetNombre()}\n";
            }

            resultado += "\n";
        }

        return resultado;
    }

    public string calculoPrecio()
    {
        float total = 0f;

        foreach (var com in mesa.comensales)
        {
            foreach (var plato in com.platos)
            {
                total += plato.GetPrecio();
            }
        }

        return $"Subtotal: {total} €";
    }

    public void MostrarPopupTemporal(GameObject popup)
    {
        StartCoroutine(PopupTemporal(popup, 5f));
    }

    private IEnumerator PopupTemporal(GameObject popup, float segundos)
    {
        popup.SetActive(true);
        yield return new WaitForSeconds(segundos);
        ResetearSistema();
        popup.SetActive(false);
    }

    public void ResetearSistema()
    {
        mesa = new Mesa();

        comensal1 = null;
        comensal2 = null;
        comensal3 = null;
        comensal4 = null;

        estados.resetBooleanos();

        miCesta.text = "";

        turnoComensal = null;

        comensalesUI.DesactivarBotonesModificar();
        comensalesUI.ActivarBotonesElegir();
        comensalesUI.empezarPedido.interactable = false;
        enviarPedido.interactable = false;
        pantallas.resetPantallas();
    }

}
