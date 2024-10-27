using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [Header("INFORMATION")]
    [SerializeField] GameObject ShotInfomation_Prefab;
    [SerializeField] GameObject[] ShotInfomation_Text;
    //[SerializeField] Text[] text;
    [SerializeField] List<Text> text = new List<Text>();


    [Header("INFORMATION")]
    [SerializeField] Information information;


    Dictionary< int, Dictionary<float, Dictionary<float, Dictionary<int, int>>>> shotInformation;


    /*
    [Header("UI")]
    [SerializeField] Text collisionedObjects;
    [SerializeField] Text shots;
    */
    [SerializeField] GameObject panel;

    //[SerializeField] Text lastShotInformaction;

    //[Header("LAST SHOT INFORMATION")]
    //[SerializeField] int shotNumber;


    //ACCEDER AL PREFAB, TOMAR SUS LINEAS DE TEXTO, REEMPLAZAR VALORES E INSTANCIARLAS COMO HIJAS DEL BOARD INFORMATION




    //METODO PARA CERRAR Y ABRIR PANEL
    //HACER BOTONES PÀRA ACCEDER


    
    void Start()
    {
        shotInformation = new Dictionary<int, Dictionary<float, Dictionary<float, Dictionary<int, int>>>>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            ShowNewInformation();
            Time.timeScale = 0;
        }
        else
        {
            panel.SetActive(false);
            Time.timeScale = 1;
        }
    }


    void GetPrefab()
    {
        //ShotInfomation_Text = new GameObject[ShotInfomation_Prefab.transform.childCount]; //SABEMOS LA CANTIDAD DE HIJOS QUE TIENE EL PREFAB //NO ESTA TOMANDO LOS GAMEOBJECTS
        //OBTENER EL COMPONENTE TEXTO DE CADA GLOBO DE TEXTO
        /*
        for (int i = 0; i < 5/*ShotInfomation_Text.Length; i++)
        {
            //TOMAR EL TEXTO DEL HIJO (I) Y CON FOR TOMAR SU COMPONENTE PARA AGREGARLO
            text[i] = ShotInfomation_Prefab.transform.GetChild(i).gameObject.GetComponent<Text>();
        }
        */
    }


    void ShowNewInformation()
    {
        GetPrefab();

        for (int i = 0; i < information.shotCounter; i++)
        {
            text[0].text = information.shotNumber[i].ToString(); 
            text[1].text = information.verticalAngles[i].ToString();
            text[2].text = information.horizontalAngles[i].ToString();
            text[3].text = information.shotForce[i].ToString();
            text[4].text = information.collisionedObstacles[i].ToString();

            ShotInfomation_Prefab.transform.parent = panel.transform;
            Instantiate(ShotInfomation_Prefab, panel.transform.position, Quaternion.identity); //CAMBIAR PARA QUE SEA HIJO DEL PANEL
        }

        panel.SetActive(true);
    }

    //BOTON GET Y POST EN INTERFAZ


    /*

    void ShowInformation()
    {
        information.TotalInformation();

        shots.text = "Cantidad de disparos: " + information.shotCounter.ToString();
        collisionedObjects.text = "Objetos colisionados: " + information.collisionedObjectTotal.ToString();

        panel.SetActive(true);
    }
    */
}
