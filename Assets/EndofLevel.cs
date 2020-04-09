using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndofLevel : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        bool EndLevel = GameObject.Find("Player").GetComponent("EndofLevel");
        if (EndLevel)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
