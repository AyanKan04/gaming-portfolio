using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moving : MonoBehaviour
{   
    public float speed = 5f;
    public Animator animator;
    public Rigidbody2D rb;
    public static bool isStart = false;
    public GameObject[] positionBullet;
    public GameObject shield;
    public static int setupGun = 1;
    private static int saveGun;


    // Start is called before the first frame update
    void Start()
    {
        isStart = false;
        saveGun = setupGun;
        switch (saveGun)
        {
            case 1: Bullet1(); break;
            case 2: Bullet2(); break;
            case 3: Bullet3(); break;
        }

        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        AudioManager.instance.PlayMusic("Theme");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!isStart)
        {
            if (transform.position.y <= -3)
            {
                transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
            }
            else if (transform.position.y > -3)
            {
                StartCoroutine(TimeStart());
                return;
            }
                
        }
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (isStart)
        {
            if (IsWin())
            {
                StartCoroutine(CountDownTime());
                if (transform.position.y > 4f)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
            else
            {
                transform.position += new Vector3(moveHorizontal * speed * Time.deltaTime, moveVertical * speed * Time.deltaTime, 0f);
            }

        }

    }
    private IEnumerator TimeStart()
    {
        yield return new WaitForSeconds(3f);
        isStart = true;
    }
    private IEnumerator CountDownShield()
    {
        yield return new WaitForSeconds(3f);
        shield.SetActive(false);
    }
    private IEnumerator CountDownTime()
    {
        yield return new WaitForSeconds(2f);
        speed = 20f;
        transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
    }
    private IEnumerator SpeedDown()
    {
        yield return new WaitForSeconds(5f);
        speed -= 5;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BulletEnemy") || other.gameObject.CompareTag("Meteo") || other.gameObject.CompareTag("Enemy")|| other.gameObject.CompareTag("Boss"))
        {
            if (!IsWin())
            {
                HealthManager.health -= 1;
                Debug.Log($"con {HealthManager.health} hp");
                if (HealthManager.health <= 0)
                {
                    Destroy(gameObject);
                    AudioManager.instance.musicSource.Stop();
                    PauseControll.instance.GameOver();
                }
            }          
        }
        if (other.gameObject.CompareTag("LazeBoss"))
        {
            if (!IsWin())
            {
                HealthManager.health -= 3;
                Debug.Log($"con {HealthManager.health} hp");
                if (HealthManager.health <= 0)
                {
                    Destroy(gameObject);
                    AudioManager.instance.musicSource.Stop();
                    PauseControll.instance.GameOver();
                }
            }

        }
        if (other.gameObject.CompareTag("Hearts"))
        {
            AudioManager.instance.PlaySFX("Item");
            HealthManager.health += 1;            
        }
        if (other.gameObject.CompareTag("SpeedItem"))
        {
            AudioManager.instance.PlaySFX("Item");
            speed += 5f;
            StartCoroutine(SpeedDown());
        }
        if (other.gameObject.CompareTag("Bullet1"))
        {
            AudioManager.instance.PlaySFX("Item");
            Bullet1();
            

        }
        if (other.gameObject.CompareTag("Bullet2"))
        {
            AudioManager.instance.PlaySFX("Item");
            Bullet2();
            
        }
        if (other.gameObject.CompareTag("Bullet3"))
        {
            AudioManager.instance.PlaySFX("Item");
            Bullet3();
            
        }
        if (other.gameObject.CompareTag("Shield"))
        {
            AudioManager.instance.PlaySFX("Item");
            shield.SetActive(true);
            StartCoroutine(CountDownShield());
        }
    }
    private void Bullet1()
    {
        positionBullet[0].SetActive(true);
        positionBullet[1].SetActive(false);
        positionBullet[2].SetActive(false);
        setupGun = 1;
    }
    private void Bullet2()
    {
        positionBullet[0].SetActive(false);
        positionBullet[1].SetActive(true);
        positionBullet[2].SetActive(true);
        setupGun = 2;
    }
    private void Bullet3()
    {
        AudioManager.instance.PlaySFX("Item");
        positionBullet[0].SetActive(true);
        positionBullet[1].SetActive(true);
        positionBullet[2].SetActive(true);
        setupGun = 3;
    }
    public static bool IsWin()
    {
        if (SpawnEnemy.amout <= 0)
        {
            return true;
        }
        else return false;
    }
}
        
    

