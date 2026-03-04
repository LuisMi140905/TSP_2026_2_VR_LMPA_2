using NUnit.Framework;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EventUI : MonoBehaviour
{
    public List<GameObject> ListaInstrucciones;
    public int currentIndex=0;
    public List<string> MensajesInstrucciones;
    public TextMeshProUGUI textMeshProUGUI;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        //Actualizar visibilidad de paneles
        UpdateVisibility();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Método para actualizar visibilidad de páneles
    private void UpdateVisibility()
    {
        for (int i = 0; i<ListaInstrucciones.Count;i++)
        {
            //Solo el panel en el índice actual está activo
            ListaInstrucciones[i].SetActive(i== currentIndex);
        }
    }
    //Método para cambiar de escena
    public void ChangeSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    //Método para cambiar de escena por nombre
    public void ChangeSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    //Método para cambiar entre páneles
    public void CycleObjects()
    {
        //Incrementa el índice y vuelve al principio
        currentIndex = (currentIndex+1) % ListaInstrucciones.Count;

        //Actualizar la visibilidad
        UpdateVisibility();
    }
    //Método para actualizar el texto mostrado
    private void UpdateText()
    {
        if(MensajesInstrucciones.Count>0)
        {

        }
    }
    //Método para salir de la app
    public void ExitGame()
    {
        Debug.Log("Va a salir");
        Application.Quit();
        Debug.Log("Ya salió");
    }
}
