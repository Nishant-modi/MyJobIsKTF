using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopController : MonoBehaviour
{

    public GameObject weatherWindow;
    public GameObject emailWindow;
    public GameObject phonebookWindow;
    public GameObject newsWindow;
    public GameObject homeWindow;
    public GameObject calendarWindow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenWeatherWindow()
    {
        homeWindow.SetActive(false);
        weatherWindow.SetActive(true);
    }

    public void OpenEmailWindow()
    {
        homeWindow.SetActive(false);
        emailWindow.SetActive(true);
    }

    public void OpenPhonebookWindow()
    {
        homeWindow.SetActive(false);
        phonebookWindow.SetActive(true);
    }

    public void OpenNewsWindow()
    {
        homeWindow.SetActive(false);
        newsWindow.SetActive(true);
    }
    public void OpenCalendarWindow()
    {
        homeWindow.SetActive(false);
        calendarWindow.SetActive(true);
    }

    public void CloseWindow()
    {
        weatherWindow.SetActive(false);
        phonebookWindow.SetActive(false);
        calendarWindow.SetActive(false);
        newsWindow.SetActive(false);
        emailWindow.SetActive(false);
        homeWindow.SetActive(true);
    }
}
