using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision) // con colision colision se agarra la info de la colision
    {
        // Debug.Log("Contacto con " + collision.gameObject.name);
        if (collision.gameObject.name == "Player")  // solo se destruye si el objeto entra en contacto con player
        {
            Destroy(gameObject);  // gameObject en misnucua se hace referencia al objeto que contiene el script.   Destroy(collision.gameObject); --> Con esto desaparece el barril (destruye la colision del gameObject¿)
        }

        

    }
}
