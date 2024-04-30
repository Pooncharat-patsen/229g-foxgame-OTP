using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool facingRight = true;
    private Animator animator;
    public float speed = 10;
    public float jump = 15;
    private Rigidbody2D rb2D;
    public Animation animation;
    public Text gameOverText;
    public Text WinText;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb2D.velocity = new Vector2(move * speed, rb2D.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Flip();

        }
        if (Input.GetKey(KeyCode.D))
        {
            FlipBack();

        }
    }

    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        // เช่น ถ้าตำแหน่ง X เปลี่ยนไป
        if (move != 0)
        {
            // เล่น Animation Clip ที่ชื่อ "Walk" ใน Animator Controller
            animator.Play("run");
        }
        else
        {
            // เล่น Animation Clip ที่ชื่อ "Idle" ใน Animator Controller
            animator.Play("fox");
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Win")
        {
            WinText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        if (collision.tag == "spikes")
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
    void Flip()
    {
        // กลับด้านตัวละครเมื่อกดปุ่ม A
        facingRight = false;
        Vector3 newScale = transform.localScale;
        newScale.x = -1;
        transform.localScale = newScale;
    }
    void FlipBack()
    {
        // กลับด้านตัวละครเมื่อกดปุ่ม A
        facingRight = true;
        Vector3 newScale = transform.localScale;
        newScale.x = 1;
        transform.localScale = newScale;
    }
}
