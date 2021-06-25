using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class PlatformRotater : MonoBehaviour
{
    public bool verticalPlatform;//If value is true,platform will flp to be vertical, if false, platform will become horizontal when clicked
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    

    private void OnMouseOver()
    {
        if (verticalPlatform == false && Input.GetKeyDown(KeyCode.Mouse0) )
        {
            this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 180f);
       
            verticalPlatform = true;
           
        }
        else if (verticalPlatform ==true && Input.GetKeyDown(KeyCode.Mouse0) )
        {
            this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90f);
            
            verticalPlatform = false;

        }

    }
    public IEnumerator RotateWait()
    {

      yield  return   new WaitForSeconds(2f);
    }

}


