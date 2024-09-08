using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 initialPosition;
    Information information;

    [Header("INFORMACION")]
    public float time;
    public float distance;
    private float currentTime;
    public int collisionedObstaclesCounter;
    public int destroyedObstaclesCounter;


    void Start()
    {
        information = FindAnyObjectByType<Information>();
        initialPosition = transform.position;

        information.TakeShotInformation();
    }
    
    void Update()
    {
        currentTime += Time.deltaTime;
        StartCoroutine(DestroyBullet(20));
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            collisionedObstaclesCounter++;
            time = currentTime;
        }
        else if (collision.gameObject.CompareTag("Limite"))
            StartCoroutine(DestroyBullet(0));
    }


    IEnumerator DestroyBullet(float timeToDestroy) 
    { 
        yield return new WaitForSeconds(timeToDestroy);

        distance = transform.position.z - initialPosition.z;

        information.TakeBulletInformation();
        Destroy(gameObject);
    }
}
