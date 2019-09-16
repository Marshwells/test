using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class saltar2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void next(string nombrenivel) {
        SceneManager.LoadScene(nombrenivel);
    }
}
