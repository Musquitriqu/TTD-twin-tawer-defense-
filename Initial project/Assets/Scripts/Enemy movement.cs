using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    public Transform target;
    public float speed;
    public int damage = 10;
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("MainTower"))
        {

            collision.gameObject.GetComponent<MainTower>().GetDamage(damage);
            Destroy(gameObject);
        }
    }



}
