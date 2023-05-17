using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.coins += 1
    }
}
