using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement; //importing SceneManagement Library 



public class playercontroller : MonoBehaviour
{

    public float speed;
    private SpriteRenderer sr;
    public bool hasPasta = false;

    //sprite variables 
    public Sprite upSprite;
    public Sprite leftSprite;
    public Sprite rightSprite;
    public Sprite frontSprite;

    //audio variables
    public AudioSource soundEffects;
    public AudioClip itemCollect;
    public AudioSource doorEnter;
    public AudioSource[] sounds;

    // public Rigidbody2D rb;

    public static playercontroller instance;
    // Start is called before the first frame update
    void Start()
    {
       sr= GetComponent<SpriteRenderer>();
        if(instance != null)
        {
            Destroy(gameObject);
        }

        instance= this; //reassign the instance to the current player 
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition=transform.position;

        //go up
        if (Input.GetKey("w"))
        {
            newPosition.y += speed;
            //change sprite to up sprite
            sr.sprite = upSprite;
        }

        //go left
        if (Input.GetKey("a"))
        {
            newPosition.x -= speed;
            sr.sprite = leftSprite;
        }


        //go down
        if(Input.GetKey("s"))
        {
            newPosition.y -= speed;
            sr.sprite = frontSprite;

        }

        //go right
        if (Input.GetKey("d"))
        {
            newPosition.x += speed;
            sr.sprite = rightSprite;

        }


        transform.position = newPosition;


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if colliding with a game object with speficic tag 
        if (collision.gameObject.tag.Equals("arrow1"))
        {
            Debug.Log("change scence");
            SceneManager.LoadScene("home");
        }

        if (collision.gameObject.tag.Equals("Pasta"))
        {
            Debug.Log("obtained Pasta");
            hasPasta = true; //player has the Pasta now

        }

        if (collision.gameObject.tag.Equals("door2") && hasPasta == true)
        {
            Debug.Log("unlocked door!");
            SceneManager.LoadScene(2); //take to new scene

        }
        

       


    }


}

