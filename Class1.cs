using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LevelControl : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bob"))
        {
            SceneManager.LoadScene("Level2");
        }
    }

}