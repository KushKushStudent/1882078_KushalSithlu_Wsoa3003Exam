using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameManager gm; public float speed = 1;
   
    public Rigidbody2D rb;

   public Vector3 ForceDirection;
    public float slowMoFactor=0.05f;
    public float slowMoLength = 2f;
    public float slowMoRecharge = 3f;
    public bool Slow = false;
    public Canvas winScreen;
    public TimeController timeController;
    // Start is called before the first frame update
    void Start()
    {
        winScreen.enabled = false;
        rb = transform.GetComponent<Rigidbody2D>();
        ForceDirection = transform.right * speed;
    }

    // Update is called once per frame
   
    void FixedUpdate()
    {
       
        rb.AddForce(ForceDirection);
        



    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {

            timeController.SlowMO();
        }
    }
    public void Move()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="End")
        {
            Time.timeScale = 0;
            winScreen.enabled = true;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Spikes")
        {
            gm.Restart();


        } else if (collision.transform.tag.Equals("TurnAround"))
        {

            var localVel = transform.InverseTransformDirection(rb.velocity);
       
            if (transform.localScale.x > 0)
            {

                ForceDirection = -transform.right * speed;
            }
            else if (transform.localScale.x < 0)
            {

                ForceDirection = transform.right * speed;
            }

            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;

            /*
            if (ForceDirection == transform.right * speed)
            {

                ForceDirection = -transform.right * speed;
                StartCoroutine(switchWait());
            }
            else if (ForceDirection == -transform.right * speed) {

                ForceDirection = transform.right * speed;
                StartCoroutine(switchWait());
            }*/
        }
       else if (collision.transform.tag == "Laser")
        {
            gm.Restart();


        }

    }





        IEnumerator switchWait() 
        {


            yield return new WaitForSeconds(1);
        }

    }
   
  
   

