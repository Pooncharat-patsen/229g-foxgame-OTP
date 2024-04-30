using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float MoveSpeed;
    public float Jump;
    public Text gameOverText;
    public Text WinText;

    public LayerMask ground;

    public GameObject player;

    Collider2D col;
    Rigidbody2D rb;

    Animator anim;

    bool isGround;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Win")
        {
            WinText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        if(collision.tag == "spikes")
        {
            gameOverText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        if (collision.tag == "monster")
        {
            gameOverText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
