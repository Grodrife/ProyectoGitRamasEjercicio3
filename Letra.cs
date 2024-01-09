using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letra : MonoBehaviour
{
    public string lower;
    public string upper;
    public string alt;
    
    public void OnClick()
    {
        if (LetraManager.lm.alt)
        {
            LetraManager.lm.AnyadirLetra(alt);
        } else if (LetraManager.lm.esMayuscula)
        {
            LetraManager.lm.AnyadirLetra(upper);
        } else
        {
            LetraManager.lm.AnyadirLetra(lower);
        }   
    }

    public void ShowLetter()
    {
        if (LetraManager.lm.alt)
        {
            GetComponentInChildren<Text>().text = alt;
        }
        else if (LetraManager.lm.esMayuscula)
        {
            GetComponentInChildren<Text>().text = upper;
        }
        else
        {
            GetComponentInChildren<Text>().text = lower;
        }
    }
}
