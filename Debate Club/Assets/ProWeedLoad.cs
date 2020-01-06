using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProWeedLoad : MonoBehaviour
{
    public Button ProWeedPressed;
    public Button AntiWeedPressed;
    public Button ProGunPressed;
    public Button AntiGunPressed;
    // Start is called before the first frame update
    void Start()
    {
        ProWeedPressed.onClick.AddListener(ProWeedIsPressed);
        AntiWeedPressed.onClick.AddListener(AntiWeedIsPressed);
        ProGunPressed.onClick.AddListener(ProGunIsPressed);
        AntiGunPressed.onClick.AddListener(AntiGunIsPressed);
    }

   void ProWeedIsPressed()
    {
       SceneManager.LoadScene(1);
    }
    void AntiWeedIsPressed()
    {
        SceneManager.LoadScene(2);
    }
    void ProGunIsPressed()
    {
        SceneManager.LoadScene(3);
    }
    void AntiGunIsPressed()
    {
        SceneManager.LoadScene(4);
    }
}
