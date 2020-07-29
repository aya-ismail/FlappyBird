using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bird : MonoBehaviour

{
    Rigidbody2D rb2d;
    public float speed = 5f;
    [SerializeField]
    private float flapForce = 20f;
    bool isDead;

    public GameObject ReplayButton;
    int Score =0;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()

    {
        //Time.timeScale = 0;
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.right * speed * Time.deltaTime;

        ReplayButton.SetActive(false);
       

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        isDead = true;
        rb2d.velocity = Vector2.zero;
        ReplayButton.SetActive(true);

        GetComponent<Animator>().SetBool("isDead", true);
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDead) { 

        rb2d.velocity = Vector2.right * speed * Time.deltaTime;
        rb2d.AddForce(Vector2.up * flapForce);
        }
        
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Score")
        {
            Score++;
            scoreText.text = Score.ToString();
        }
    }

    public void Replay() {
        SceneManager.LoadScene(0);
    }
    public void Unfreese() { Time.timeScale = 1; }

   
    }






