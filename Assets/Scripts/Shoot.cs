using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    [Header("SHOT")]
    [SerializeField] protected GameObject bulletPrefab;
    [SerializeField] protected Transform shootPoint;
    [SerializeField] public Slider force;

    [Header("OTHER SCRIPTS")]
    CannonMovement cannonMovement;


    void Start()
    {
        cannonMovement = FindAnyObjectByType<CannonMovement>();

        cannonMovement.SetSliderValue(200, 0, force);
    }

    public void shootBullet()
    {
        GameObject clonBala = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
        Rigidbody balaRB = clonBala.GetComponent<Rigidbody>();

        balaRB.AddRelativeForce(transform.up * force.value, ForceMode.Impulse);
    }
    
}
