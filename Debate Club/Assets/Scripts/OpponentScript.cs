using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpponentScript : MonoBehaviour
{
    // Establishes the opponents health
    public int EnemyHealth = 100;

    // Declares the 15 available attacks to use against your opponent, these are then assigned to buttons 
    public Button TestPoint1;
    public Button TestPoint2;
    public Button TestPoint3;
    public Button TestPoint4;
    public Button TestPoint5;
    public Button TestPoint6;
    public Button TestPoint7;
    public Button TestPoint8;
    public Button TestPoint9;
    public Button TestPoint10;
    public Button TestPoint11;
    public Button TestPoint12;
    public Button TestPoint13;
    public Button TestPoint14;
    public Button TestPoint15;

    // Start is called before the first frame update
    void Start()
    {
        TestPoint1.onClick.AddListener(TestPoint1IsClicked);
        TestPoint2.onClick.AddListener(TestPoint2IsClicked);
        TestPoint3.onClick.AddListener(TestPoint3IsClicked);
        TestPoint4.onClick.AddListener(TestPoint4IsClicked);
        TestPoint5.onClick.AddListener(TestPoint5IsClicked);
        TestPoint6.onClick.AddListener(TestPoint6IsClicked);
        TestPoint7.onClick.AddListener(TestPoint7IsClicked);
        TestPoint8.onClick.AddListener(TestPoint8IsClicked);
        TestPoint9.onClick.AddListener(TestPoint9IsClicked);
        TestPoint10.onClick.AddListener(TestPoint10IsClicked);
        TestPoint11.onClick.AddListener(TestPoint11IsClicked);
        TestPoint12.onClick.AddListener(TestPoint12IsClicked);
        TestPoint13.onClick.AddListener(TestPoint13IsClicked);
        TestPoint14.onClick.AddListener(TestPoint14IsClicked);
        TestPoint15.onClick.AddListener(TestPoint15IsClicked);
    }
    // Update is called once per frame
    void Update()
    {
        // If the opponents health reaches 0 you win
        if (EnemyHealth == (0))
        {
            Debug.Log("YOU WIN!!!");

        }
    }
    // does a specific ammount of damage to the opponent depending on the argument used
    void TestPoint1IsClicked()
    {
        Button btn = TestPoint1.GetComponent<Button>();
        EnemyHealth = EnemyHealth - 100;
        Debug.Log(EnemyHealth);
    }
    void TestPoint2IsClicked()
    {
        Button btn = TestPoint2.GetComponent<Button>();
        EnemyHealth = EnemyHealth - 90;
        Debug.Log(EnemyHealth);
    }
    void TestPoint3IsClicked()
    {
        Button btn = TestPoint3.GetComponent<Button>();
        EnemyHealth = EnemyHealth - 80;
        Debug.Log(EnemyHealth);
    }
    void TestPoint4IsClicked()
    {
        Button btn = TestPoint4.GetComponent<Button>();
        EnemyHealth = EnemyHealth - 70;
        Debug.Log(EnemyHealth);
    }
    void TestPoint5IsClicked()
    {
        Button btn = TestPoint5.GetComponent<Button>();
        EnemyHealth = EnemyHealth - 60;
        Debug.Log(EnemyHealth);
    }
    void TestPoint6IsClicked()
    {
        Button btn = TestPoint6.GetComponent<Button>();
        EnemyHealth = EnemyHealth - 50;
        Debug.Log(EnemyHealth);
    }
    void TestPoint7IsClicked()
    {
        Button btn = TestPoint7.GetComponent<Button>();
        EnemyHealth = EnemyHealth - 40;
        Debug.Log(EnemyHealth);
    }
    void TestPoint8IsClicked()
    {
        Button btn = TestPoint8.GetComponent<Button>();
        EnemyHealth = EnemyHealth - 30;
        Debug.Log(EnemyHealth);
    }
    void TestPoint9IsClicked()
    {
        Button btn = TestPoint9.GetComponent<Button>();
        EnemyHealth = EnemyHealth - 20;
        Debug.Log(EnemyHealth);
    }
    void TestPoint10IsClicked()
    {
        Button btn = TestPoint10.GetComponent<Button>();
        EnemyHealth = EnemyHealth - 10;
        Debug.Log(EnemyHealth);
    }
    void TestPoint11IsClicked()
    {
        Button btn = TestPoint11.GetComponent<Button>();
        EnemyHealth = EnemyHealth - 8;
        Debug.Log(EnemyHealth);
    }
    void TestPoint12IsClicked()
    {
        Button btn = TestPoint12.GetComponent<Button>();
        EnemyHealth = EnemyHealth - 6;
        Debug.Log(EnemyHealth);
    }
    void TestPoint13IsClicked()
    {
        Button btn = TestPoint13.GetComponent<Button>();
        EnemyHealth = EnemyHealth - 4;
        Debug.Log(EnemyHealth);
    }
    void TestPoint14IsClicked()
    {
        Button btn = TestPoint14.GetComponent<Button>();
        EnemyHealth = EnemyHealth - 2;
        Debug.Log(EnemyHealth);
    }
    void TestPoint15IsClicked()
    {
        Button btn = TestPoint15.GetComponent<Button>();
        EnemyHealth = EnemyHealth - 0;
        Debug.Log(EnemyHealth);
    }
}
