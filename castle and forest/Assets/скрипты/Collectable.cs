using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour 
{
public int amount= 1;

private void OnTriggerEnter2D (Collider2D collision)
{
if (collision.CompareTag("Player"))
{
PlayerData player = collision.GetComponent<PlayerData>();
player.AddItem(amount);
Destroy(gameObject);
}
}
}