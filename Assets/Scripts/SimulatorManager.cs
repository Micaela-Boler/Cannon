using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static DataTracker;

public class SimulatorManager : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject UIElementsPrefab;
    [SerializeField] Transform elementWrapper;

    List<GameObject> uiElements = new List<GameObject>();

    [SerializeField] Information information;

    [SerializeField] Text[] texts = new Text[4];




    private void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            OpenPanel();
        }
    }


    public void closePanel()
    {
        panel.SetActive(false);
    }

    public void OpenPanel()
    {
        Bullet bullet = FindAnyObjectByType<Bullet>();

        if (bullet == null)
        {
            panel.SetActive(true);
            UpdateUI();
        }
        else
            Debug.Log("ESPERAR A QUE SE ELIMINEN LAS BALAS");
    }


    private void UpdateUI()
    {
        foreach (var shot in information.shotNumber)
        {
            if (shot >= uiElements.Count)
            {
                GameObject inst = Instantiate(UIElementsPrefab, elementWrapper.transform.parent.position, Quaternion.identity);
                //inst.transform.parent = elementWrapper;
                uiElements.Add(inst);
            }


             //texts = uiElements[shot].GetComponentsInChildren<Text>();
            
            //texts[0].text = information.shotNumber[shot].ToString();
            //texts[1].text = information.verticalAngles[shot].ToString();
           // texts[2].text = information.horizontalAngles[shot].ToString();
            //texts[3].text = information.shotForce[shot].ToString();
            //texts[4].text = information.collisionedObstacles[shot].ToString();
        }
        
        foreach (var element in uiElements)
        {
            //var texts = uiElements[element].GetComponentsInChildren<Text>();

            // texts[0].text = information.shotNumber[shot].ToString();
            //texts[1].text = information.verticalAngles[shot].ToString();
            // texts[2].text = information.horizontalAngles[shot].ToString();
            //texts[3].text = information.shotForce[shot].ToString();
            //texts[4].text = information.collisionedObstacles[shot].ToString();
        }



        // CONTAR LA CANTIDAD DE TIROS QUE SE HICIERON
        //EM BASE A ESO CREAR INSTANCIAS DEL PREFAB DE ELEMENTO Y HACER UNA LISTA DE TODOS ELLOS
        //CAMBIAR LA INFORMACION DE TODOS
    }
}
    
