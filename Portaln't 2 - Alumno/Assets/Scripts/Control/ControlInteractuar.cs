using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlInteractuar : MonoBehaviour
{
    public float hitDistance = 10.0f;
    public Camera camaraPrimeraPersona;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = camaraPrimeraPersona.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            if ((Physics.Raycast(ray, out hit) == true) && hit.distance < hitDistance)
            {
                Debug.Log("El rayo tocó al objeto: " + hit.collider.name);

                if (hit.collider.gameObject.name.Contains("Caja"))
                {
                    GameObject objetoTocado = hit.collider.gameObject;
                    ControlObjeto scriptObjetoTocado = (ControlObjeto)objetoTocado.GetComponentInParent((typeof(ControlObjeto)));

                    if (scriptObjetoTocado != null)
                    {
                            scriptObjetoTocado.funcion();
                    }
                }
            }
        }
    }
}

