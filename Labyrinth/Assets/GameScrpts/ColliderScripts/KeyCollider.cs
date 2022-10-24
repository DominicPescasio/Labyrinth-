using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollider : MonoBehaviour
{
    public int Key = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "Key")
        {
            Key++;
            Destroy(collision.gameObject);
        }

    }
}
