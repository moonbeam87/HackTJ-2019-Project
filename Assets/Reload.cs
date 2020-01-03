using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Scene sc = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        Scene sc = SceneManager.GetActiveScene();

        SceneManager.LoadScene(sc.buildIndex);

    }
}
