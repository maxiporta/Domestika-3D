using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    public int fuerza;

    void Update()
    {
        if(Input.GetKey(KeyCode.F)){
            GetComponent<Rigidbody>().AddForce(0,fuerza,0);
        }
    }
}