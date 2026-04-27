using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPantallasControlador : MonoBehaviour 
{
    public GameObject pantallaInicio;
    public GameObject pantallaComensales;
    public GameObject panelPrimeros;
    public GameObject panelSegundos;
    public GameObject panelPostres;
    public GameObject panelBebidas;
    public GameObject panelCafes;
    public GameObject panelEstados;
    public GameObject panelPago;

    void Start()
    {
        pantallaInicio.SetActive(true);
        pantallaComensales.SetActive(false);
        panelPrimeros.SetActive(false);
        panelSegundos.SetActive(false);
        panelPostres.SetActive(false);
        panelBebidas.SetActive(false);
        panelCafes.SetActive(false);
        panelEstados.SetActive(false);
        panelPago.SetActive(false);
    }

    public void MostrarPantallaInicio()
    {
        pantallaInicio.SetActive(true);
        pantallaComensales.SetActive(false);
    }

    public void MostrarPantallaComensales()
    {
        pantallaInicio.SetActive(false);
        pantallaComensales.SetActive(true);
    }

    public void MostrarPrimeros()
    {
        panelPrimeros.SetActive(true);
        pantallaComensales.SetActive(false);
    }

    public void MostrarSegundos()
    {
        panelSegundos.SetActive(true);
        panelPrimeros.SetActive(false);
    }

    public void MostrarPostres()
    {
        panelPostres.SetActive(true);
        panelSegundos.SetActive(false);
    }

    public void MostrarBebidas()
    {
        panelBebidas.SetActive(true);
        panelPostres.SetActive(false);
    }

    public void MostrarCafes()
    {
        panelCafes.SetActive(true);
        panelBebidas.SetActive(false);
    }

    public void MostrarPantallaEstados()
    {
        panelEstados.SetActive(true);
        pantallaComensales.SetActive(false);
    }

    public void MostrarPantallaPago()
    {
        panelPago.SetActive(true);
        panelEstados.SetActive(false);
    }

    public void resetPantallas()
    {
        pantallaInicio.SetActive(true);
        pantallaComensales.SetActive(false);
        panelPrimeros.SetActive(false);
        panelSegundos.SetActive(false);
        panelPostres.SetActive(false);
        panelBebidas.SetActive(false);
        panelCafes.SetActive(false);
        panelEstados.SetActive(false);
        panelPago.SetActive(false);
    }
}

