using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonClicked : MonoBehaviour
{


    Button thisButton;
    public GameObject setUp;

    private void Awake()
    {
        thisButton = GetComponent<Button>();
    }

    private void Start()
    {
        switch (transform.name) {
            case "StartButton":
                thisButton.onClick.AddListener(StartButtonClicked);
                break;
            case "RestartButton":
                thisButton.onClick.AddListener(RestartButtonClicked);
                break;
            
            case "ReturnButton":
                thisButton.onClick.AddListener(ReturnButtonClicked);
                break;
            case "CloseButton":
                thisButton.onClick.AddListener(CloseButtonClicked);
                break;
            
            case "QuitButton":
                thisButton.onClick.AddListener(QuitButtonClicked);
                break;
            case "SetUpButton":
                thisButton.onClick.AddListener(SetUpButtonClick);
                break;

        }
    }

    void SetUpButtonClick()
    {

        setUp.SetActive(true);

    }

    void QuitButtonClicked()
    {

        Application.Quit();

    }

    void StartButtonClicked()
    {
        SceneManager.LoadScene("Level1");
    }
    void RestartButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    void ReturnButtonClicked()
    {
        SceneManager.LoadScene("StartScene");

    }
    void CloseButtonClicked()
    {
        transform.parent.gameObject.SetActive(false);
    }

    



















}
