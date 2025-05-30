using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;

    public void UpdateMoney(float amount)
    {
        if (money + amount < 0) // si la cant de plata es menor a la compra no deja comprar. Premite vender si la venta vale mas que la cant de money.
        {
            // impedir la compra
            Debug.Log("Dinero insuficiente");
        } else
        {
            money += amount;  // le suma la cant de money a amount y se guara (actualiza) el valor de la variable money
        }
        
    }
}
