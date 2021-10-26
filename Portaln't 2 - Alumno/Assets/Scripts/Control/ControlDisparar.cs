using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDisparar : MonoBehaviour
{
    public float hitDistance = 10.0f;
    private AudioSource source;
    public AudioClip gunShot;
    public Camera camaraPrimeraPersona;

    // Start is called before the first frame update
    void Start()
    {
        source = gameObject.AddComponent<AudioSource>();
        source.clip = gunShot = Resources.Load<AudioClip>("effect_shot");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camaraPrimeraPersona.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;
            source.PlayOneShot(gunShot, 0.3f);

            if ((Physics.Raycast(ray, out hit) == true) && hit.distance < hitDistance)
            {
                Debug.Log("El rayo tocó al objeto: " + hit.collider.name);

                if (hit.collider.gameObject.name.Contains("Bot"))
                {
                    GameObject objetoTocado = hit.collider.gameObject;
                    ControlBot scriptObjetoTocado = (ControlBot)objetoTocado.GetComponentInParent((typeof(ControlBot)));

                    if (scriptObjetoTocado != null)
                    {
                        if (hit.collider.gameObject.name.Contains("Head"))
                        {
                            scriptObjetoTocado.headShot();
                        }
                        else
                        {
                            scriptObjetoTocado.recibirDaño();
                        }
                    }
                }
            }
        }
    }
}
