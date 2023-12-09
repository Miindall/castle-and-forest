using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open : MonoBehaviour
{
	public float life = 2;

	private float shakeDuration = 0f;

	private float shakeMagnitude = 0.25f;

	// A measure of how quickly the shake effect should evaporate
	private float dampingSpeed = 1f;

	// The initial position of the GameObject
	Vector3 initialPosition;
	// Start is called before the first frame update

	void Awake()
	{
		initialPosition = transform.position;
	}

	void Start()
    {
        
    }

 
    void Update()
    {
		if (life <= 0)
		{
			Destroy(gameObject);
			 GetComponent<Animator>().Play("открыть");
		}
		else if (shakeDuration > 0)
		{
			transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;
 GetComponent<Animator>().Play("открыть");
			shakeDuration -= Time.deltaTime * dampingSpeed;
		}
		else
		{

			shakeDuration = 0f;
			transform.localPosition = initialPosition;
		}
	}

	public void ApplyDamage(float damage)
	{
         GetComponent<Animator>().Play("открыть");
		life -= 1;
		shakeDuration = 0.1f;
	}
}

