using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apuntar : MonoBehaviour
{
    enum tipodeapuntado { click, mantener };
    [SerializeField] tipodeapuntado apuntado;
    // Start is called before the first frame update
    public float velocidad;
    public float zoom;
    private float zoominicial;
    public Vector3 posapuntado;
    private Vector3 posinicial;
    bool apuntando;
    private void Awake()
    {
        posinicial = this.transform.localPosition;
        zoominicial = Camera.main.fieldOfView;
    }
    private void Update()
    {
        if (apuntado == tipodeapuntado.click)
        {
            if (Input.GetButton("Fire2"))
            {
                apuntando = !apuntando;
            }
        }
        if (apuntado == tipodeapuntado.mantener)
        {
            if (Input.GetButton("Fire2"))
            {
                apuntando = true;
            }
            else
            {
                apuntando = false;
            }
        }
        sistemaapuntado(apuntando);
    }
    private void sistemaapuntado(bool _apuntado)
    {
        if (_apuntado)
        {
            this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, posapuntado, velocidad * Time.deltaTime);
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, zoom, velocidad * Time.deltaTime);
        }
        else
        {
            this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, posinicial, velocidad * Time.deltaTime);
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, zoominicial, velocidad * Time.deltaTime);
        }
    }
}
