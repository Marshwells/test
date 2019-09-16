using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidodisparo : MonoBehaviour
{
    public AudioClip pissound;
    AudioSource fuentesonido;
    // Start is called before the first frame update
    void Start()
    {
        fuentesonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            fuentesonido.clip = pissound;
            fuentesonido.Play();
        }
    }
}
