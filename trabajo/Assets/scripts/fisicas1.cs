using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fisicas1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-1f, 1f);
        GetComponent<Rigidbody>().AddForce(new Vector3 (x, 0f,1f) * 20f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
