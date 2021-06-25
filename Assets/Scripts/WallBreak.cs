using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBreak : MonoBehaviour
{
    public float clickTime=1f;
    public int clickCount=0;
    public float startTime;
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
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            startTime = Time.time;

            if ((Time.time - startTime) < clickTime)
            {
                clickCount++;
                if (clickCount == 3)
                {

                    selfDestruct();
                }

            }
            else 
            {
                clickCount = 0;
            }
        
        
        }
    }
    void selfDestruct() 
    {
        Destroy(gameObject);
    
    }

}
