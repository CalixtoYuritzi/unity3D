using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caController : MonoBehaviour
{
    public GameObject avion;
    private Vector3 distancia = new Vector3(0,4,-6);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = avion.transform.position + distancia;
    }
}
