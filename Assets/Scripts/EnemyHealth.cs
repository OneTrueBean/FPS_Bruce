using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int startingHealth = 3 ;
    int currenthealth;
    
    void Awake()
    {
        currenthealth = startingHealth;
    }

public void TakeDamage(int amount)
{
    currenthealth -= amount;
    Debug.Log("taking damage currenthealth: " + currenthealth );
    if (currenthealth <= 0)
    {
        Destroy(this.gameObject);
    }
}
        
    
}
