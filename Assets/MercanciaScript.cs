using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public float cost = 5;
    public MoneyManager moneyManager; // para conectarse con el money manager del player

     void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>(); // busca en la escena un componente del tipo entre <  >. Si hay mas de uno agarra el priemro que encuentra entonces solo se usa cuando hay solo un tipo de este elemento en la escena.
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))  // compara tags porque es más eficiente. para que ande hay que cambiar la tag de player
        {
            moneyManager.UpdateMoney(-cost); // llama a la función que creamos --> UpdateMoney en el script moneyManager. 
            Destroy(gameObject);
        }
    }
}
