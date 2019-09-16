using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetivo : MonoBehaviour
{
    public int vida;
    public int enemigos = 5;
    
    public void mediste() {
        if (vida > 0) {
            vida -= 5;
        }
        if (vida <= 0)
        {
            Debug.Log("lo mataste");
            Destroy(gameObject);
        }
        
    }
   
}
