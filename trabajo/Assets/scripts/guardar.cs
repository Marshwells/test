using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardar : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("X") != 0.0f) {
            player.position = new Vector3(PlayerPrefs.GetFloat("X"), PlayerPrefs.GetFloat("Y"), PlayerPrefs.GetFloat("Z"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("X", player.position.x);
        PlayerPrefs.SetFloat("Y", player.position.y);
        PlayerPrefs.SetFloat("Z", player.position.z);
    }
}
