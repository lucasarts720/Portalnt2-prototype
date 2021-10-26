using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlObjeto : MonoBehaviour
{
    bool attached = false;
    public GameObject caja;
    public GameObject parent;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    public void funcion()
    {
        if (attached)
        {
            drop();
        }
        else
        {
            attach(parent);
        }

    }

    public void drop ()
    {
        //code
        transform.parent = null;
        attached = false;
        rb.isKinematic = false;
    }

    void attach(GameObject parent)
    {
        //code
        caja.transform.parent = parent.transform;
        attached = true;
        rb.isKinematic = true;
    }
}
