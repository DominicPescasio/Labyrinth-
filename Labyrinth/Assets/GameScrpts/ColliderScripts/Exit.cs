using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "Exit")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
}
