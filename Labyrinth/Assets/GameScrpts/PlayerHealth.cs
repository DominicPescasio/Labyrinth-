using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public int health = 4;
    public Text healthText;
   
    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "Damage")
        {
            health--;
            if (health <= 0)
            {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
        }
    }
}
