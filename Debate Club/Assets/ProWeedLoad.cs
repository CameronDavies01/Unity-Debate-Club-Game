using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProWeedLoad : MonoBehaviour
{
    public Button ProWeedPressed;
    public Button AntiGunPressed;
    // Start is called before the first frame update
    void Start()
    {
        ProWeedPressed.onClick.AddListener(ProWeedIsPressed);
        AntiGunPressed.onClick.AddListener(AntiGunIsPressed);
    }

   void ProWeedIsPressed()
    {
       SceneManager.LoadScene(1);
    }
    void AntiGunIsPressed()
    {
        SceneManager.LoadScene(0);
    }
}
