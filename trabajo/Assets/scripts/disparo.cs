using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    RaycastHit hit;
    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        if (Input.GetButton("Fire1"))
        {
            if(Physics.Raycast(ray,out hit, 100f)){
                if (hit.collider.gameObject.tag == "objetivo")
                {
                    Debug.Log("Acabas de acertar el objetivo");
                    hit.collider.gameObject.SendMessage("mediste");
                }
            }
        }
    }
}
