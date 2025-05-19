using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // agregado

public class RespawnOnFall : MonoBehaviour
{
    public float yRespawnValue;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yRespawnValue)  // accedo al transform del objeto del script (fpsControler en este caso)
        {
            // Debug.Log("Me caí :C");
            SceneManager.LoadScene("FPS Parkour"); // Vuelve a cargar la escena

        }


    }
}
