using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crown : MonoBehaviour

{
    public ParticleSystem firework;
private void OnTriggerEnter2D (Collider2D collision)
{
if (collision.CompareTag("Player"))
{
firework.Play();
Destroy(gameObject);
}
}
}