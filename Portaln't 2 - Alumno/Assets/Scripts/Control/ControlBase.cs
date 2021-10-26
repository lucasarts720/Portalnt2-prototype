using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBase : MonoBehaviour
{
    public GameObject puerta;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Caja"))
        {
            ControlPuerta Abrir = puerta.GetComponent(typeof(ControlPuerta)) as ControlPuerta;
            Debug.Log("la caja entro");
            Abrir.abrir();
        }
    }
}
