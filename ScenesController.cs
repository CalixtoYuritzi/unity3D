using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Libreria para las escenas
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SampleScene()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void Descargas()
    {
        SceneManager.LoadScene("Descargas", LoadSceneMode.Single);
    }

    public void Camara()
    {
        SceneManager.LoadScene("Camara", LoadSceneMode.Single);
    }
}
