using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float timePast;
    public float speed = 5f;
    public float jumpSpeed = 7f;

    //Jump
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    private bool isTouchingGround;

    private Animator animator;
    private static bool isGameOver = false;
    private Rigidbody2D rb;

    private ScoreManager scoreManager;

    private float timeDesc;
    //private bool isSpeedUp = false;
    private float speedFoodTimer = 3f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            return;
        }
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        timePast += Time.deltaTime;
        if (timePast >= 5f)
        {
            if (speed < 20f)
                speed++;
            timePast = 0;
        }
        float moveHorizontal = Input.GetAxis("Horizontal");
        bool isMoving = moveHorizontal != 0;
        animator.SetBool("isMoving", isMoving);
        if (isMoving)
        {
            if (moveHorizontal < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else if (moveHorizontal > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            transform.position += new Vector3(moveHorizontal * speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            rb.velocity = new Vector2(animator.velocity.x, jumpSpeed);
        }
        

        //thiet lap isSpeedFood trang thai False(khong thuc hien) ---- chi thuc hien khi la True (sau khi xay ra va cham giua Char & Food)
        //if (isSpeedUp)
        //{
        //    //tao thoi gian timeDesc de tinh thoi gian hieu luc
        //    timeDesc += Time.deltaTime;
        //    //neu thoi gian troi qua lon hon hoac bang thoi gian hieu luc ban dau
        //    if (timeDesc >= speedFoodTimer)
        //    {
        //        //speed giam 5f, thiet lap isSpeedFood ve lai False de ngung thuc hien tru speed
        //        speed -= 5f;
        //        isSpeedUp = false;
        //        //reset timeDesc
        //        timeDesc = 0f;
        //    }     

        //}
    }
    private IEnumerator SpeedDown()
    {
        yield return new WaitForSeconds(5f);
        speed -= 5;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Gold"))
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            ScoreManager.AddScore(1);
        }
        if (other.gameObject.CompareTag("SpeedFood"))
        {            
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            ScoreManager.AddScore(1);

            //khi Charactor va cham SpeedFood thi tang 5 speed
            speed += 5f;
            StartCoroutine(SpeedDown());
            //thiet lap isSpeedFood = True --- thuc hien tinh thoi gian hieu luc tang toc
            //isSpeedUp = true;
        }
        if (other.gameObject.CompareTag("GoldUp"))
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();

            //tang random tu 2-3 score
            int randomScore = Random.Range(2, 3);
            Debug.Log($"Socre tang {randomScore}");
            ScoreManager.AddScore(randomScore);
        }
        if (other.gameObject.CompareTag("Apple"))
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();

            //tang x2-x5 score
            int randomScore = Random.Range(2, 5);
            int scoreUp = ScoreManager.score * randomScore;
            Debug.Log($"Socre X{randomScore}");
            ScoreManager.AddScore(scoreUp);
        }
        if (other.gameObject.CompareTag("Boom"))
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();

            //tru 1 score
            ScoreManager.AddScore(-1);
        }
        if (other.gameObject.CompareTag("Dead"))
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            Dead();
        }
        if (other.gameObject.CompareTag("ReducedTime"))
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            //Giam time tu 5-10 giay
            int randomScore = Random.Range(5, 10);
            Debug.Log($"Time tang {randomScore}");
            ScoreManager.SetTime(-randomScore);
        }
        if (other.gameObject.CompareTag("IncreaseTime"))
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            //Tang time tu 5-10 giay
            int randomScore = Random.Range(5, 10);
            Debug.Log($"Time tang {randomScore}");
            ScoreManager.SetTime(randomScore);
        }
       
    }
    private void Dead()
    {
        ScoreManager.IsDead();
    }
    public static void SetGameOver()
    {
        isGameOver = true;
    }
}
