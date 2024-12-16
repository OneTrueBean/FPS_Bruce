using StarterAssets;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    StarterAssetsInputs starterAssetsInputs;
    [SerializeField] int damageAmount = 1;
    [SerializeField] ParticleSystem muzzelFlash;
    [SerializeField] Animator animator;
    const string SHOOT ="Shoot";
    void  Awake() 
    {
        starterAssetsInputs = GetComponentInParent<StarterAssetsInputs>();
    }
    void Start()
    {
        
    }


    void Update()
    {
        HandleShoot();

    }

    private void HandleShoot()
    {
        if (!starterAssetsInputs.shoot) return;
        muzzelFlash.Play();
        animator.Play(SHOOT, 0 , 0f);
        starterAssetsInputs.ShootInput(false);

        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position,
        Camera.main.transform.forward, out hit, Mathf.Infinity))
        {

            EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();

            if (enemyHealth == null)
            {
                Debug.Log("enemyhealth is Null");
            }

            if (enemyHealth)
            {

                enemyHealth.TakeDamage(damageAmount);
            }
            
        }
    }
}
