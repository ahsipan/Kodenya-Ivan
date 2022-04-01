using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    public float amp;

    // Start is called before the first frame update

    void Update()
    {
        transform.position = new Vector3(0, Mathf.Sin(Time.time) * amp, 0);
        
    }
}
