using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
{
    public float velocidad;//Velocidad de movimientos

    private float forward;
    private float right;//Movimiento

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Recuperar si presiono flecha arriba
        forward = Input.GetAxis("Vertical");
        //Recuperar si se presionó flecha der-izq
        right = Input.GetAxis("Horizontal");
        //Metodo para mover un GameObject (Acelerar - reversa)
        //direccion * velocidad * tiempo
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime * forward);
        //Metodo para mover un GameObject (Derecha - izquierda)
        transform.Translate(Vector3.right * velocidad * Time.deltaTime * right);
        
    }
}
