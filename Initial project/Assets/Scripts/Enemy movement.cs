using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    public Transform target;
    public float speed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.position += direction.normalized * Time.deltaTime;
        transform.rotation = Quaternion.LookRotation(direction);

            
    
    
    
    }
}
