using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProWeedLoad : MonoBehaviour
{
    public Button ProWeedPressed;
    // Start is called before the first frame update
    void Start()
    {
        ProWeedPressed.onClick.AddListener(ProWeedIsPressed);
    }

   void ProWeedIsPressed()
    {
        Application.LoadLevel(0);
    }
}
