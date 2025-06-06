using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public float cost = 5;

    // para conectar con otro script hay que crear una variable del tipo del que me quiero conectar
    public MoneyManager moneyManager; // para conectarse con MoneyManager que está em el player

     void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>(); // busca en la escena un componente del tipo entre <  >. Si hay mas de uno agarra el priemro que encuentra entonces solo se usa cuando hay solo un tipo de este elemento en la escena.
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))  // compara tags porque es más eficiente. para que ande hay que cambiar la tag de player
        {
            if (moneyManager.UpdateMoney(-cost)) // llama a la función que creamos --> UpdateMoney en el script moneyManager.  Luego de chequear el tag, llama a la función UpdateMoney y si se ejecuta la condición destruye el objeto con el que se hizo contacto
            {
                Destroy(gameObject);
            }
        }
    }
}
