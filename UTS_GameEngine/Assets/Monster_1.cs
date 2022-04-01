using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_1 : MonoBehaviour
{
     public float amp;

    // Start is called before the first frame update
    void start()
    {


    }
    void Update()
    {
        transform.position = new Vector3(4, Mathf.Sin(Time.time) * amp, 0);
        
    }
}
