using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData: MonoBehaviour

{

private bool hasKey = false;

public void AddKey()
{
hasKey = true;
}

public void RemoveKey()
{
hasKey = false;
}
public bool CheckKey()
{
return hasKey;
}
}