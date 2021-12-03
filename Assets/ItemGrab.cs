using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGrab : MonoBehaviour
{

    public int QuantityGrabed = 1;

    void OnTriggerEnter2D(Collider2D Player)
    {
        if(Player.name == "Nave")
        {
            PlayerStat.playerStat.ItemBomb += QuantityGrabed;
            Debug.Log(PlayerStat.playerStat.ItemBomb);
            Destroy(gameObject);
        }
        
    }


}
