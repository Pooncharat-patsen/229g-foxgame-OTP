using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Monster : MonoBehaviour
{
    private float timer = 0f;
    private float delay = 5f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delay )
        {
            Destroy( gameObject);
        }    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.CompareTag("monster"))
        {
            Destroy(collision.gameObject);
           
        }    
    }
}
