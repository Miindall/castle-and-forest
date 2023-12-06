using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour

{
public Animator animator;
private void OnTriggerEnter2D(Collider2D collision)
{
if (collision.CompareTag("Player"))
{
PlayerData player = collision.GetComponent<PlayerData>();
if (player.CheckKey())
{
player.RemoveKey();
animator.enabled = true;
}
}
}
}