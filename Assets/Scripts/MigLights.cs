using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MigLights : MonoBehaviour
{
    [SerializeField] private Light mig;
    [SerializeField] private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            mig.enabled = false;
           
        }
         if(timer < -1)
        {
            timer = 1;
        }
        if(timer > 0)
        {
            mig.enabled = true;
        }
    }
}
