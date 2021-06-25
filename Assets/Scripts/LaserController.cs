using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    public GameObject laser;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void trigger()
    {
       
       
    }
 private  void OnMouseOver(){ 
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.StopPlayback();
            laser.active = false;
            anim.enabled = false;
            
        }
    }
}
