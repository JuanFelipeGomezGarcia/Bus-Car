using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntaje : MonoBehaviour
{
    public TMP_Text puntos;

    public void SumarPuntos(float valor)
    {
        puntos.text = (float.Parse(puntos.text) - valor).ToString();
    }
}
