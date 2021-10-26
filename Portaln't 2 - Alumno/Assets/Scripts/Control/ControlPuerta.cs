using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPuerta : MonoBehaviour
{
    public float X;
    public float Y;
    public float Z;

    private void Start()
    {

    }
    public void abrir()
    {
            Vector3 rotation = new Vector3(X, Y, Z);
            transform.Rotate(rotation);
        Debug.Log("la puerta se abre");
    }
}
