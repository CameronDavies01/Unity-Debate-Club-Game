using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpponentScript : MonoBehaviour
{
    // Establishes the opponents health
    public int EnemyAudienceApproval = 1000;

    public int PlayerAudienceApproval = 1000;



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

    // Declares the 5 available lies to use against your opponent, these are then assigned to buttons 
    public Button TestLie1;
    public Button TestLie2;
    public Button TestLie3;
    public Button TestLie4;
    public Button TestLie5;


    // Start is called before the first frame update
    void Start()
    {

        // Constantly checks to see if any of the buttons are clicked
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
        TestLie1.onClick.AddListener(TestLie1IsClicked);
        TestLie2.onClick.AddListener(TestLie2IsClicked);
        TestLie3.onClick.AddListener(TestLie3IsClicked);
        TestLie4.onClick.AddListener(TestLie4IsClicked);
        TestLie5.onClick.AddListener(TestLie5IsClicked);

        TestPoint1.onClick.AddListener(EnemyPoint);
        TestPoint2.onClick.AddListener(EnemyPoint);
        TestPoint3.onClick.AddListener(EnemyPoint);
        TestPoint4.onClick.AddListener(EnemyPoint);
        TestPoint5.onClick.AddListener(EnemyPoint);
        TestPoint6.onClick.AddListener(EnemyPoint);
        TestPoint7.onClick.AddListener(EnemyPoint);
        TestPoint8.onClick.AddListener(EnemyPoint);
        TestPoint9.onClick.AddListener(EnemyPoint);
        TestPoint10.onClick.AddListener(EnemyPoint);
        TestPoint11.onClick.AddListener(EnemyPoint);
        TestPoint12.onClick.AddListener(EnemyPoint);
        TestPoint13.onClick.AddListener(EnemyPoint);
        TestPoint14.onClick.AddListener(EnemyPoint);
        TestPoint15.onClick.AddListener(EnemyPoint);
        TestLie1.onClick.AddListener(EnemyPoint);
        TestLie2.onClick.AddListener(EnemyPoint);
        TestLie3.onClick.AddListener(EnemyPoint);
        TestLie4.onClick.AddListener(EnemyPoint);
        TestLie5.onClick.AddListener(EnemyPoint);
    }
    // Update is called once per frame
    void Update()
    {
    }
    // Does a specific ammount of damage to the opponent depending on the argument used
    void TestPoint1IsClicked()
    {
        Button btn = TestPoint1.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 100;
        Debug.Log(EnemyAudienceApproval);
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }
    void TestPoint2IsClicked()
    {
        Button btn = TestPoint2.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 90;
        Debug.Log(EnemyAudienceApproval);
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }
    void TestPoint3IsClicked()
    {
        Button btn = TestPoint3.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 80;
        Debug.Log(EnemyAudienceApproval);
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }
    void TestPoint4IsClicked()
    {
        Button btn = TestPoint4.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 70;
        Debug.Log(EnemyAudienceApproval);
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }
    void TestPoint5IsClicked()
    {
        Button btn = TestPoint5.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 60;
        Debug.Log(EnemyAudienceApproval);
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }
    void TestPoint6IsClicked()
    {
        Button btn = TestPoint6.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 50;
        Debug.Log(EnemyAudienceApproval);
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }
    void TestPoint7IsClicked()
    {
        Button btn = TestPoint7.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 40;
        Debug.Log(EnemyAudienceApproval);
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }
    void TestPoint8IsClicked()
    {
        Button btn = TestPoint8.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 30;
        Debug.Log(EnemyAudienceApproval);
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }
    void TestPoint9IsClicked()
    {
        Button btn = TestPoint9.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 20;
        Debug.Log(EnemyAudienceApproval);
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }
    void TestPoint10IsClicked()
    {
        Button btn = TestPoint10.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 10;
        Debug.Log(EnemyAudienceApproval);
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }
    void TestPoint11IsClicked()
    {
        Button btn = TestPoint11.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 8;
        Debug.Log(EnemyAudienceApproval);
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }
    void TestPoint12IsClicked()
    {
        Button btn = TestPoint12.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 6;
        Debug.Log(EnemyAudienceApproval);
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }
    void TestPoint13IsClicked()
    {
        Button btn = TestPoint13.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 4;
        Debug.Log(EnemyAudienceApproval);
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }
    void TestPoint14IsClicked()
    {
        Button btn = TestPoint14.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 2;
        Debug.Log(EnemyAudienceApproval);
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }
    void TestPoint15IsClicked()
    {
        Button btn = TestPoint15.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 0;
        Debug.Log(EnemyAudienceApproval);
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }

    void TestLie1IsClicked()
    {
        Button btn = TestLie1.GetComponent<Button>();
        if (Random.value < (.5))
        {
            EnemyAudienceApproval = EnemyAudienceApproval - 200;
            Debug.Log(EnemyAudienceApproval);
        }
        else
        {
            Debug.Log("I CAN SEE THROUGH YOUR LIES");
        }
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }

    }
    void TestLie2IsClicked()
    {
        Button btn = TestLie2.GetComponent<Button>();
        if (Random.value < (.5))
        {
            EnemyAudienceApproval = EnemyAudienceApproval - 300;
            Debug.Log(EnemyAudienceApproval);
        }
        else
        {
            Debug.Log("I CAN SEE THROUGH YOUR LIES");
        }
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }

    }
    void TestLie3IsClicked()
    {
        Button btn = TestLie3.GetComponent<Button>();
        if (Random.value < (.5))
        {
            EnemyAudienceApproval = EnemyAudienceApproval - 400;
            Debug.Log(EnemyAudienceApproval);
        }
        else
        {
            Debug.Log("I CAN SEE THROUGH YOUR LIES");
        }
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }
    void TestLie4IsClicked()
    {
        Button btn = TestLie4.GetComponent<Button>();
        if (Random.value < (.5))
        {
            EnemyAudienceApproval = EnemyAudienceApproval - 500;
            Debug.Log(EnemyAudienceApproval);
        }
        else
        {
            Debug.Log("I CAN SEE THROUGH YOUR LIES");
        }
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }
    void TestLie5IsClicked()
    {
        Button btn = TestLie5.GetComponent<Button>();
        if (Random.value < (.5))
        {
            EnemyAudienceApproval = EnemyAudienceApproval - 600;
            Debug.Log(EnemyAudienceApproval);
        }
        else
        {
            Debug.Log("I CAN SEE THROUGH YOUR LIES");
        }
        if (EnemyAudienceApproval < (0))
        {
            Debug.Log("YOU WIN!!!");
        }
    }
    void EnemyPoint()
    {
        float RandomAttackGenerator;
        RandomAttackGenerator = (Mathf.Ceil(Random.Range(1, 15)));
        if (RandomAttackGenerator == 1)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 10;
            Debug.Log("Player E");
            Debug.Log(PlayerAudienceApproval);
        }
        if (RandomAttackGenerator == 2)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 20;
            Debug.Log("Player");
            Debug.Log(PlayerAudienceApproval);
        }
        if (RandomAttackGenerator == 3)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 30;
            Debug.Log("Player");
            Debug.Log(PlayerAudienceApproval);
        }
        if (RandomAttackGenerator == 4)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 40;
            Debug.Log("Player");
            Debug.Log(PlayerAudienceApproval);
        }
        if (RandomAttackGenerator == 5)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 50;
            Debug.Log("Player");
            Debug.Log(PlayerAudienceApproval);
        }
        if (RandomAttackGenerator == 6)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 60;
            Debug.Log("Player");
            Debug.Log(PlayerAudienceApproval);
        }
        if (RandomAttackGenerator == 7)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 70;
            Debug.Log("Player");
            Debug.Log(PlayerAudienceApproval);
        }
        if (RandomAttackGenerator == 8)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 80;
            Debug.Log("Player");
            Debug.Log(PlayerAudienceApproval);
        }
        if (RandomAttackGenerator == 9)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 90;
            Debug.Log("Player");
            Debug.Log(PlayerAudienceApproval);
        }
        if (RandomAttackGenerator == 10)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 100;
            Debug.Log("Player");
            Debug.Log(PlayerAudienceApproval);
        }
        if (RandomAttackGenerator == 11)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 110;
            Debug.Log("Player");
            Debug.Log(PlayerAudienceApproval);
        }
        if (RandomAttackGenerator == 12)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 120;
            Debug.Log("Player");
            Debug.Log(PlayerAudienceApproval);
        }
        if (RandomAttackGenerator == 13)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 130;
            Debug.Log("Player");
            Debug.Log(PlayerAudienceApproval);
        }
        if (RandomAttackGenerator == 14)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 140;
            Debug.Log("Player");
            Debug.Log(PlayerAudienceApproval);
        }
        if (RandomAttackGenerator == 15)
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 150;
            Debug.Log("Player");
            Debug.Log(PlayerAudienceApproval);
        }

    }
}
