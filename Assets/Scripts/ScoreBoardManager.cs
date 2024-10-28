using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static DataTracker;

public class ScoreBoardManager : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject UIElementPrefab;
    [SerializeField] Transform elementWrapper;

    List<GameObject> uiElements = new List<GameObject>();

    [SerializeField] Information information;

    List<Text> texts = new List<Text>();




    private void Start()
    {
        panel.SetActive(false);
    }


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
            UpdateUI();
            panel.SetActive(true); 
        }
        else
            Debug.Log("ESPERAR A QUE SE ELIMINEN LAS BALAS");
    }


    private void UpdateUI()
    {
        for (int i = 0; i < information.shotNumber.Count; i++)
        {
            texts.Clear();
            

            GameObject inst = Instantiate(UIElementPrefab, elementWrapper.transform.parent.position, Quaternion.identity);
            inst.transform.parent = elementWrapper;

            
            for (int j = 0; i < inst.transform.childCount; i++)
            {
                texts.Add(inst.transform.GetChild(j).GetComponent<Text>());
            }
            
           // texts[0].text = information.shotNumber[i].ToString();
            //texts[1].text = information.verticalAngles[i].ToString();
            //texts[2].text = information.horizontalAngles[i].ToString();
            //texts[3].text = information.shotForce[i].ToString();
           // texts[4].text = information.collisionedObstacles[i].ToString();
        }
    }
}

