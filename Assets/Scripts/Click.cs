using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Click : MonoBehaviour
{
    // Start is called before the first frame update
    public int numeroescena;
    public TMP_Text puntos;
    public int valor;
    public void OnMouseDown()
    {
        if(float.Parse(puntos.text)>=valor){
            Debug.Log("click");
            SceneManager.LoadScene(numeroescena);
            puntos.text=(float.Parse(puntos.text) - valor).ToString();
         }
         else{
            Debug.Log("no tiene");
         }
        }      
}
