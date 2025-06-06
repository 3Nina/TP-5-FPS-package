using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour  // se vuelve el script en una clase¿  --> por eso se conecta con tipos  (tiene que ser public)
{
    public float money;
    public UiManager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UiManager>();
    }

    public bool UpdateMoney(float amount)
    {
        if (money + amount < 0) // si la cant de plata es menor a la compra no deja comprar. Premite vender si la venta vale mas que la cant de money.
        {
            // impedir la compra
            Debug.Log("Dinero insuficiente");
            return false;  // nos devuelve que es falso
        } 
        else
        {
            money += amount;  // le suma la cant de money a amount y se guara (actualiza) el valor de la variable money
            uiManager.UpdateMoneyText(money.ToString()); // llama la función del script UiManager  (Lo conectamos antes)
            return true; 
        }
        
    }
}
