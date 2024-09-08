using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [Header("INFORMATION")]
    [SerializeField] Information information;

    [Header("UI")]
    [SerializeField] Text collisionedObjects;
    [SerializeField] Text shots;
    [SerializeField] GameObject panel;

    //[SerializeField] Text lastShotInformaction;

    [Header("LAST SHOT INFORMATION")]
    [SerializeField] int shotNumber;


    void Start()
    {
        panel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            ShowInformation();
        }
        else
            panel.SetActive(false);
    }


    void ShowInformation()
    {
        information.TotalInformation();

        shots.text = "Cantidad de disparos: " + information.shotCounter.ToString();
        collisionedObjects.text = "Objetos colisionados: " + information.collisionedObjectTotal.ToString();

        panel.SetActive(true);
    }

    /*
    public void ShowLastShotInformation()
    {
        lastShotInformaction.text = "Shot number: " + information.shotCounter.ToString() + " Horizontal angle: Vertical angle: Force:";
    }
    */
}
