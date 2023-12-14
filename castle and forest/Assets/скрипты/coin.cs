using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin: MonoBehaviour {

public GameObject TextObject;

Text textComponent;

public AudioClip CoinSound;

public int Coin;

void Start () {

textComponent = TextObject.GetComponent <Text> ();
}


void OnTriggerEnter2D (Collider2D other) {
//проверка, имеет-ли объект тэг Coin
if (other.tag == "Coin") {
//увеличить переменную подсчета монет
Coin = Coin + 1;
//записать в текст результат счета монет, преобразованный в текстовую переменную
textComponent.text = Coin.ToString();
//проиграть звук поднятия монеты на позиции крысы
AudioSource.PlayClipAtPoint (CoinSound, transform.position);
//удалить монету из сцены   
if(other.CompareTag("Player"))
  {
 Destroy(gameObject);
  }

}
}
}