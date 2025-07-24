using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player touched coin!");
            GameManager.Instance.score += 10;
            Destroy(gameObject);
        }
    }



}
