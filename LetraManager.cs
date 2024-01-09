using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LetraManager : MonoBehaviour
{
    public string palabra = "";
    public bool esMayuscula = false;
    public bool alt = false;
    public Text cuadroTexto;
    Letra[] letras;

    public static LetraManager lm;

    private void Awake()
    {
        lm = this;
        letras = GetComponentsInChildren<Letra>();
    }

    public void AnyadirLetra(string letra)
    {
        palabra += letra;
        cuadroTexto.text = palabra;
    }

    public void PulsarMayus()
    {
        esMayuscula = !esMayuscula;
        for (int i = 0; i < letras.Length; i++)
        {
            letras[i].ShowLetter();
        }
    }

    public void PulsarAlt()
    {
        alt = !alt;
        for (int i = 0; i < letras.Length; i++)
        {
            letras[i].ShowLetter();
        }
    }
}
