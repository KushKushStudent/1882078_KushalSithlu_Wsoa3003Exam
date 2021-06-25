using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool defaultOn;
    void Start()
    {
        if (defaultOn == false) {
            GetComponent<AreaEffector2D>().enabled = false;
            GetComponent<ParticleSystem>().enableEmission = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
    }
    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && defaultOn == true)
        {
            GetComponent<AreaEffector2D>().enabled = false;
            GetComponent<ParticleSystem>().enableEmission = false;
            defaultOn = false;
        } else if (Input.GetKeyDown(KeyCode.Mouse0) && defaultOn == false)
        {
            GetComponent<AreaEffector2D>().enabled = true;
            GetComponent<ParticleSystem>().enableEmission = true;
            defaultOn = true;
        }

    }
}
