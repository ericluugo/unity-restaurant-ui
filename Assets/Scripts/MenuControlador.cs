using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class MenuControlador : MonoBehaviour
{
    public ControladorPrincipal controlador;

    // ---------------- PRIMEROS PLATOS ----------------

    public void AñadirEnsalada()
    {
        controlador.AgregarConsumible(new Plato("Ensalada", 11, TipoConsumible.Primer));
        controlador.pantallas.MostrarSegundos();
    }

    public void AñadirCrema()
    {
        controlador.AgregarConsumible(new Plato("Crema", 7, TipoConsumible.Primer));
        controlador.pantallas.MostrarSegundos();
    }

    public void AñadirVichyssoise()
    {
        controlador.AgregarConsumible(new Plato("Vichyssoise", 13.5f, TipoConsumible.Primer));
        controlador.pantallas.MostrarSegundos();
    }

    public void AñadirHuevosRotos()
    {
        controlador.AgregarConsumible(new Plato("Huevos Rotos", 9, TipoConsumible.Primer));
        controlador.pantallas.MostrarSegundos();
    }

    public void AñadirArroz()
    {
        controlador.AgregarConsumible(new Plato("Arroz", 11.5f, TipoConsumible.Primer));
        controlador.pantallas.MostrarSegundos();
    }

    public void AñadirLasagna()
    {
        controlador.AgregarConsumible(new Plato("Lasaña", 10.5f, TipoConsumible.Primer));
        controlador.pantallas.MostrarSegundos();
    }

    // ---------------- SEGUNDOS PLATOS ----------------

    public void AñadirSolomillo()
    {
        controlador.AgregarConsumible(new Plato("Solomillo con patatas y espárragos", 17.5f, TipoConsumible.Segundo));
        controlador.pantallas.MostrarPostres();
    }

    public void AñadirMerluza()
    {
        controlador.AgregarConsumible(new Plato("Merluza a la plancha", 22f, TipoConsumible.Segundo));
        controlador.pantallas.MostrarPostres();
    }

    public void AñadirHamburguesa()
    {
        controlador.AgregarConsumible(new Plato("Hamburguesa", 13.9f, TipoConsumible.Segundo));
        controlador.pantallas.MostrarPostres();
    }

    public void AñadirSalmon()
    {
        controlador.AgregarConsumible(new Plato("Salmón al horno", 19.6f, TipoConsumible.Segundo));
        controlador.pantallas.MostrarPostres();
    }

    // ---------------- POSTRES ----------------

    public void AñadirTartaQueso()
    {
        controlador.AgregarConsumible(new Plato("Tarta de queso", 6, TipoConsumible.Postre));
        controlador.pantallas.MostrarBebidas();
    }

    public void AñadirBrownie()
    {
        controlador.AgregarConsumible(new Plato("Brownie", 4, TipoConsumible.Postre));
        controlador.pantallas.MostrarBebidas();
    }

    public void AñadirTartaChocolate()
    {
        controlador.AgregarConsumible(new Plato("Tarta de chocolate", 6, TipoConsumible.Postre));
        controlador.pantallas.MostrarBebidas();
    }

    public void AñadirTortitas()
    {
        controlador.AgregarConsumible(new Plato("Tortitas", 8, TipoConsumible.Postre));
        controlador.pantallas.MostrarBebidas();
    }

    public void AñadirMacedonia()
    {
        controlador.AgregarConsumible(new Plato("Macedonia de temporada", 3, TipoConsumible.Postre));
        controlador.pantallas.MostrarBebidas();
    }

    public void AñadirTartaManzana()
    {
        controlador.AgregarConsumible(new Plato("Tarta de manzana", 6, TipoConsumible.Postre));
        controlador.pantallas.MostrarBebidas();
    }

    // ---------------- BEBIDAS ----------------

    public void AñadirAgua()
    {
        controlador.AgregarConsumible(new Bebida("Agua", 2));
        controlador.pantallas.MostrarCafes();
    }

    public void AñadirAguaConGas()
    {
        controlador.AgregarConsumible(new Bebida("Agua con gas", 2.5f));
        controlador.pantallas.MostrarCafes();
    }

    public void AñadirCerveza()
    {
        controlador.AgregarConsumible(new Bebida("Cerveza", 2.7f));
        controlador.pantallas.MostrarCafes();
    }

    public void AñadirAquarius()
    {
        controlador.AgregarConsumible(new Bebida("Aquarius", 3));
        controlador.pantallas.MostrarCafes();
    }

    public void AñadirCocaCola()
    {
        controlador.AgregarConsumible(new Bebida("Coca-cola", 3));
        controlador.pantallas.MostrarCafes();
    }

    public void AñadirFanta()
    {
        controlador.AgregarConsumible(new Bebida("Fanta", 3));
        controlador.pantallas.MostrarCafes();
    }

    public void AñadirSprite()
    {
        controlador.AgregarConsumible(new Bebida("Sprite", 3));
        controlador.pantallas.MostrarCafes();
    }

    public void AñadirFuzeTea()
    {
        controlador.AgregarConsumible(new Bebida("FuzeTea", 3));
        controlador.pantallas.MostrarCafes();
    }

    public void AñadirZumoNaranja()
    {
        controlador.AgregarConsumible(new Bebida("Zumo de naranja", 3.5f));
        controlador.pantallas.MostrarCafes();
    }

    public void AñadirZumoMango()
    {
        controlador.AgregarConsumible(new Bebida("Zumo de mango", 3.5f));
        controlador.pantallas.MostrarCafes();
    }

    // ---------------- CAFÉS ----------------

    public void AñadirCafeLeche()
    {
        controlador.AgregarConsumible(new Cafe("Café con leche", 2));
        controlador.FinalizarMenu();
    }

    public void AñadirCapuccino()
    {
        controlador.AgregarConsumible(new Cafe("Capuccino", 3.5f));
        controlador.FinalizarMenu();
    }

    public void AñadirAmericano()
    {
        controlador.AgregarConsumible(new Cafe("Americano", 1.5f));
        controlador.FinalizarMenu();
    }

    public void AñadirCafeIrlandes()
    {
        controlador.AgregarConsumible(new Cafe("Irlandés", 7.5f));
        controlador.FinalizarMenu();
    }
}

