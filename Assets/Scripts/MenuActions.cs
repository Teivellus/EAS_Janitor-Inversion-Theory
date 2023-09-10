using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuActions : MonoBehaviour
{

    public GameObject menuLink;
    public GameObject settingLink;
    public Slider DaynNight;
    public GameObject Day;
    public GameObject Night;
    // Start is called before the first frame update
    void Start()
    {
        DaynNight.value = 50;
        Night.SetActive(false);
        Day.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (DaynNight.value > 65)
        {
            Night.SetActive(true);
            Day.SetActive(false);
        }
        else if (DaynNight.value < 35)
        {
            Night.SetActive(false);
            Day.SetActive(true);
        }
        else if (DaynNight.value > 35 && DaynNight.value  < 65)
        {
            Night.SetActive(false);
            Day.SetActive(false);
        }


    }



    public void StartGame()
    {
        SceneManager.LoadScene(1);

    }

    public void Exit()
    {
        Application.Quit();
    }
    
    public void Options()
    {
        menuLink.SetActive(false);
        settingLink.SetActive(true);
    }
    public void CloseOptions()
    {
        menuLink.SetActive(true);
        settingLink.SetActive(false);
    }

    public void Credits()
    {

    }

}
