using UnityEngine;
using System.Collections;
//---------------------------------------------------
public class Mover : MonoBehaviour 
{
    public float MaxSpeed = 10f;
    private Transform ThisTransform = null;
    float h;
    float v;
    public float RotateSpeed = 90f;
    //---------------------------------------------------
    // Use this for initialization
    void Awake () 
    {
        ThisTransform = GetComponent<Transform>();
    }
    //---------------------------------------------------
    // Update is called once per frame
    void Update () 
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        ThisTransform.position += ThisTransform.forward * v * MaxSpeed * Time.deltaTime;
        

        ThisTransform.rotation *= Quaternion.Euler(new Vector3(0, RotateSpeed
            * Time.deltaTime * h, 0));
    }
    //---------------------------------------------------
}