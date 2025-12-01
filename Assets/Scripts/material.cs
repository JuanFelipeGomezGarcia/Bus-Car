using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class material : MonoBehaviour
{
    public int valor;
    public TMP_Text puntos;
    public Material rojo;
    public Material verde;
    public GameObject registradora; 

    // Update is called once per frame
    void Update()
    {
        Renderer rend =registradora.GetComponent<Renderer>();

        if(valor<=float.Parse(puntos.text)){
            rend.material=verde;
        }
        else{

            rend.material=rojo;
        }
    }
}
