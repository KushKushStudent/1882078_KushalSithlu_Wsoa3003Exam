using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    // Start is called before the first frame update
    public float slowMoFactor = 0.05f;
    public float slowMoLength = 6f;
    public float slowMoRecharge = 3f;
   
    void Start()
    {
        
    }
    private void Update()
    {
        
        Time.timeScale += (1f / slowMoLength) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }
    // Update is called once per frame
  

   public void SlowMO()
    {
        Time.timeScale = slowMoFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }
}
