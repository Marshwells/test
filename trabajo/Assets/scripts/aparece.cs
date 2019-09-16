using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparece : MonoBehaviour
{
    public GameObject prefabs;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefabs, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
