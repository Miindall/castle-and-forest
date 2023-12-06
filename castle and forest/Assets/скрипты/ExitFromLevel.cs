using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitFromLevel : MonoBehaviour
{
public string замок;
private void OnTriggerEnter2D(Collider2D collision)
{

SceneLoader.LoadScene(замок);
}
}