using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIEstadosContrlador : MonoBehaviour
{
    public ControladorPrincipal controlador;
    public UIPantallasControlador pantallas;

    public TextMeshProUGUI miCestaPrimero;
    public TextMeshProUGUI miCestaSegundo;
    public TextMeshProUGUI miCestaPostre;

    public TextMeshProUGUI textoEstado1;
    public TextMeshProUGUI textoEstado2;
    public TextMeshProUGUI textoEstado3;

    public Slider sliderPrimeros;
    public Slider sliderSegundos;
    public Slider sliderPostre;

    public Button recogerPrimero;
    public Button recogerSegundo;
    public Button recogerPostre;
    public Button pagarPedido;

    private bool inicio = true;
    private bool primerosRecogidos = false;
    private bool segundosRecogidos = false;
    private bool postresRecogidos = false;

    void Start()
    {
        recogerPrimero.interactable = false;
        recogerSegundo.interactable = false;
        recogerPostre.interactable = false;
        pagarPedido.interactable = false;
    }

    public void platosPrimeros()
    {
       miCestaPrimero.text = controlador.cestaPorTipo(TipoConsumible.Primer);
    }
    public void platosSegundos()
    {
        miCestaSegundo.text = controlador.cestaPorTipo(TipoConsumible.Segundo);
    }
    public void platosPostres()
    {
        miCestaPostre.text = controlador.cestaPorTipo(TipoConsumible.Postre);
    }

    public void IniciarProgreso()
    {
        StartCoroutine(LlenarBarra(sliderPrimeros, 5f, textoEstado1));
 
    }

    IEnumerator LlenarBarra(Slider slider, float duracion,TextMeshProUGUI estado)
    {
        slider.value = 0;
        float t = 0;

        while (t < duracion)
        {
            t += Time.deltaTime;
            slider.value = t / duracion;
            // Estados según el valor
            if (slider.value < 0.33f)
            {
                estado.text = "Pedido";
            }
            else if (slider.value < 1f)
            {
                estado.text = "En preparación";
            }

            yield return null;
        }

        slider.value = 1f;
        estado.text = "Servido";

        ActualizarEstado();
    }

    public void ActualizarEstado()
    {
        // PRIMEROS
        if (sliderPrimeros.value == 1 && inicio)
        {
            recogerPrimero.interactable = true;
        }
           

        // SEGUNDOS (solo si primeros recogidos)
        if (sliderSegundos.value == 1 && primerosRecogidos)
        {
            recogerSegundo.interactable = true;
        }
            

        // POSTRES (solo si segundos recogidos)
        if (sliderPostre.value == 1 && segundosRecogidos)
        {
            recogerPostre.interactable = true;
        }

        if (postresRecogidos)
        {
            pagarPedido.interactable = true;
        }
    }

    public void recogerPrimerPlato()
    {
        inicio = false;
        primerosRecogidos = true;
        recogerPrimero.interactable = false;
        StartCoroutine(LlenarBarra(sliderSegundos, 5f, textoEstado2));
    }

    public void recogerSegundoPlato()
    {
        primerosRecogidos = false;
        segundosRecogidos = true;
        recogerSegundo.interactable = false;
        StartCoroutine(LlenarBarra(sliderPostre, 5f, textoEstado3));
    }
    
    public void recogerPostrePlato()
    {
        segundosRecogidos = false;
        postresRecogidos = true;
        recogerPostre.interactable = false;
    }
    public void pagarCuenta()
    {
        pantallas.MostrarPantallaPago();
    }

    public void resetBooleanos()
    {
        inicio = true;
        primerosRecogidos = false;
        segundosRecogidos = false;
        postresRecogidos = false;

        recogerPrimero.interactable = false;
        recogerSegundo.interactable = false;
        recogerPostre.interactable = false;
        pagarPedido.interactable = false;

        sliderPrimeros.value = 0;
        sliderSegundos.value = 0;
        sliderPostre.value = 0;

        textoEstado1.text = "";
        textoEstado2.text = "";
        textoEstado3.text = "";

    }

}

