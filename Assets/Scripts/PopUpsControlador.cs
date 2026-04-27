using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpControlador : MonoBehaviour
{
    public GameObject ensalada, calabaza, vichyssoise, huevos, arroz, lasagna, hamburguesa, merluza, salmon, solomillo,
        tartaQueso, brownie, tartaChoco, tortitas, macedonia, tartaManzana, cafeConLeche, capuccino, americano, irlandes, pagoTarjeta, tarjetaAceptada;

    public void Mostrar(GameObject panel) => panel.SetActive(true);
    public void Ocultar(GameObject panel) => panel.SetActive(false);

}

