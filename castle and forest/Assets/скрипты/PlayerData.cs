using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData: MonoBehaviour

{

private bool _hasKey = false;

private int _collectableItems;
public Animator _door;

public void AddKey()
{
_hasKey = true;
}

public void RemoveKey()
{
_hasKey = false;
}

public bool CheckKey()

{
return _hasKey;
}

public void AddItem(int amount)
{
    _collectableItems += amount;
    if (CheckItemsAmount (10))
{
    RemoveItems(10);
    _door.enabled = true;
}
}

public bool CheckItemsAmount(int checkAmount)
{
    if (_collectableItems >- checkAmount)
    {
        return true;
    }
    else
    {
return false;
    }
}

public void RemoveItems(int amount)
{
    _collectableItems -= amount;
}

}