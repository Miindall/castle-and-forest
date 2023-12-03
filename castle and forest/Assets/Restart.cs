using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] private string _tag = "Player";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(_tag))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        Destroy(gameObject);
    }

}
