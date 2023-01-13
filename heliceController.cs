using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heliceController : MonoBehaviour
{
    public float speedHelice = 2000.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speedHelice);
        
    }
}
