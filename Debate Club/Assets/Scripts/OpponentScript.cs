using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpponentScript : MonoBehaviour
{
    // Establishes the opponents health
    public int EnemyAudienceApproval = 1000;

    public int PlayerAudienceApproval = 1000;

    float ArgumentType = 2;



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

    public Button BackFromPoint;
    public Button BackFromLie;
    public Text PlayerTakeDamage;
    public Text OpponentTakeDamage;



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
        EnemyAudienceApproval = (EnemyAudienceApproval - 20);
        PlayerTakeDamage.text = ("YOU DEAL 20 DAMAGE!!!").ToString();
        StartCoroutine(PlayerTimer());
        ArgumentType = (1);
    }
    void TestPoint2IsClicked()
    {
        Button btn = TestPoint2.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 200;
        PlayerTakeDamage.text = ("YOU DEAL 200 DAMAGE!!!").ToString();
        StartCoroutine(PlayerTimer());
        ArgumentType = (1);
    }
    void TestPoint3IsClicked()
    {
        Button btn = TestPoint3.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 20;
        PlayerTakeDamage.text = ("YOU DEAL 20 DAMAGE!!!").ToString();
        StartCoroutine(PlayerTimer());
        ArgumentType = (1);
    }
    void TestPoint4IsClicked()
    {
        Button btn = TestPoint4.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 80;
        PlayerTakeDamage.text = ("YOU DEAL 80 DAMAGE!!!").ToString();
        StartCoroutine(PlayerTimer());
        ArgumentType = (1);
    }
    void TestPoint5IsClicked()
    {
        Button btn = TestPoint5.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 150;
        PlayerTakeDamage.text = ("YOU DEAL 150 DAMAGE!!!").ToString();
        StartCoroutine(PlayerTimer());
        ArgumentType = (1);
    }
    void TestPoint6IsClicked()
    {
        Button btn = TestPoint6.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 150;
        PlayerTakeDamage.text = ("YOU DEAL 150 DAMAGE!!!").ToString();
        StartCoroutine(PlayerTimer());
        ArgumentType = (1);
    }
    void TestPoint7IsClicked()
    {
        Button btn = TestPoint7.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 20;
        PlayerTakeDamage.text = ("YOU DEAL 20 DAMAGE!!!").ToString();
        StartCoroutine(PlayerTimer());
        ArgumentType = (1);
    }
    void TestPoint8IsClicked()
    {
        Button btn = TestPoint8.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 20;
        PlayerTakeDamage.text = ("YOU DEAL 20 DAMAGE!!!").ToString();
        StartCoroutine(PlayerTimer());
        ArgumentType = (1);
    }
    void TestPoint9IsClicked()
    {
        Button btn = TestPoint9.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 30;
        PlayerTakeDamage.text = ("YOU DEAL 30 DAMAGE!!!").ToString();
        StartCoroutine(PlayerTimer());
        ArgumentType = (1);
    }
    void TestPoint10IsClicked()
    {
        Button btn = TestPoint10.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 70;
        PlayerTakeDamage.text = ("YOU DEAL 70 DAMAGE!!!").ToString();
        StartCoroutine(PlayerTimer());
        ArgumentType = (1);
    }
    void TestPoint11IsClicked()
    {
        Button btn = TestPoint11.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 40;
        PlayerTakeDamage.text = ("YOU DEAL 40 DAMAGE!!!").ToString();
        StartCoroutine(PlayerTimer());
        ArgumentType = (1);
    }
    void TestPoint12IsClicked()
    {
        Button btn = TestPoint12.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 20;
        PlayerTakeDamage.text = ("YOU DEAL 20 DAMAGE!!!").ToString();
        StartCoroutine(PlayerTimer());
        ArgumentType = (1);
    }
    void TestPoint13IsClicked()
    {
        Button btn = TestPoint13.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 100;
        PlayerTakeDamage.text = ("YOU DEAL 100 DAMAGE!!!").ToString();
        StartCoroutine(PlayerTimer());
        ArgumentType = (1);
    }
    void TestPoint14IsClicked()
    {
        Button btn = TestPoint14.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 50;
        PlayerTakeDamage.text = ("YOU DEAL 50 DAMAGE!!!").ToString();
        StartCoroutine(PlayerTimer());
        ArgumentType = (1);
    }
    void TestPoint15IsClicked()
    {
        Button btn = TestPoint15.GetComponent<Button>();
        EnemyAudienceApproval = EnemyAudienceApproval - 30;
        PlayerTakeDamage.text = ("YOU DEAL 30 DAMAGE!!!").ToString();
        StartCoroutine(PlayerTimer());
        ArgumentType = (1);
    }

    void TestLie1IsClicked()
    {
        Button btn = TestLie1.GetComponent<Button>();
        if (Random.value < (.7))
        {
            EnemyAudienceApproval = EnemyAudienceApproval - 100;
            PlayerTakeDamage.text = ("YOU DEAL 100 DAMAGE!!!").ToString();
            StartCoroutine(PlayerTimer());
            ArgumentType = (3);
        }
        else
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 200;
            PlayerTakeDamage.text = ("I CAN SEE THROUGH YOUR LIES YOU TAKE 200 DAMAGE").ToString();
            StartCoroutine(PlayerTimer());
            ArgumentType = (3);
        }
    }
    void TestLie2IsClicked()
    {
        Button btn = TestLie2.GetComponent<Button>();
        if (Random.value < (.6))
        {
            EnemyAudienceApproval = EnemyAudienceApproval - 200;
            PlayerTakeDamage.text = ("YOU DEAL 200 DAMAGE!!!").ToString();
            StartCoroutine(PlayerTimer());
            ArgumentType = (3);
        }
        else
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 400;
            PlayerTakeDamage.text = ("I CAN SEE THROUGH YOUR LIES YOU TAKE 400 DAMAGE").ToString();
            StartCoroutine(PlayerTimer());
            ArgumentType = (3);
        }
    }
    void TestLie3IsClicked()
    {
        Button btn = TestLie3.GetComponent<Button>();
        if (Random.value < (.5))
        {
            EnemyAudienceApproval = EnemyAudienceApproval - 300;
            PlayerTakeDamage.text = ("YOU DEAL 300 DAMAGE!!!").ToString();
            StartCoroutine(PlayerTimer());
            ArgumentType = (3);
        }
        else
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 600;
            PlayerTakeDamage.text = ("I CAN SEE THROUGH YOUR LIES YOU TAKE 600 DAMAGE").ToString();
            StartCoroutine(PlayerTimer());
            ArgumentType = (3);
        }
    }
    void TestLie4IsClicked()
    {
        Button btn = TestLie4.GetComponent<Button>();
        if (Random.value < (.4))
        {
            EnemyAudienceApproval = EnemyAudienceApproval - 400;
            PlayerTakeDamage.text = ("YOU DEAL 400 DAMAGE!!!").ToString();
            StartCoroutine(PlayerTimer());
            ArgumentType = (3);
        }
        else
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 800;
            PlayerTakeDamage.text = ("I CAN SEE THROUGH YOUR LIES YOU TAKE 800 DAMAGE").ToString();
            StartCoroutine(PlayerTimer());
            ArgumentType = (3);
        }
        
    }
    void TestLie5IsClicked()
    {
        Button btn = TestLie5.GetComponent<Button>();
        if (Random.value < (.3))
        {
            EnemyAudienceApproval = EnemyAudienceApproval - 500;
            PlayerTakeDamage.text = ("YOU DEAL 500 DAMAGE!!!").ToString();
            StartCoroutine(PlayerTimer());
            ArgumentType = (3);
        }
        else
        {
            PlayerAudienceApproval = PlayerAudienceApproval - 1000;
            PlayerTakeDamage.text = ("I CAN SEE THROUGH YOUR LIES YOU TAKE 1000 DAMAGE").ToString();
            StartCoroutine(PlayerTimer());
            ArgumentType = (3);
        }
    }

    void EnemyPoint()
    {
        if (ArgumentType < 2)
        {
            TestPoint1.gameObject.SetActive(false);
            TestPoint2.gameObject.SetActive(false);
            TestPoint3.gameObject.SetActive(false);
            TestPoint4.gameObject.SetActive(false);
            TestPoint5.gameObject.SetActive(false);
            TestPoint6.gameObject.SetActive(false);
            TestPoint7.gameObject.SetActive(false);
            TestPoint8.gameObject.SetActive(false);
            TestPoint9.gameObject.SetActive(false);
            TestPoint10.gameObject.SetActive(false);
            TestPoint11.gameObject.SetActive(false);
            TestPoint12.gameObject.SetActive(false);
            TestPoint13.gameObject.SetActive(false);
            TestPoint14.gameObject.SetActive(false);
            TestPoint15.gameObject.SetActive(false);
            BackFromPoint.gameObject.SetActive(false);
        }
        if  (ArgumentType > 2) {
            TestLie1.gameObject.SetActive(false);
            TestLie2.gameObject.SetActive(false);
            TestLie3.gameObject.SetActive(false);
            TestLie4.gameObject.SetActive(false);
            TestLie5.gameObject.SetActive(false);
            BackFromLie.gameObject.SetActive(false);
        }
       
        OpponentTakeDamage.text = ("").ToString();
        StartCoroutine(OpponentTimer());
        IEnumerator OpponentTimer()
        {
            yield return new WaitForSeconds(2);
            if (ArgumentType < 2)
            {
                TestPoint1.gameObject.SetActive(true);
                TestPoint2.gameObject.SetActive(true);
                TestPoint3.gameObject.SetActive(true);
                TestPoint4.gameObject.SetActive(true);
                TestPoint5.gameObject.SetActive(true);
                TestPoint6.gameObject.SetActive(true);
                TestPoint7.gameObject.SetActive(true);
                TestPoint8.gameObject.SetActive(true);
                TestPoint9.gameObject.SetActive(true);
                TestPoint10.gameObject.SetActive(true);
                TestPoint11.gameObject.SetActive(true);
                TestPoint12.gameObject.SetActive(true);
                TestPoint13.gameObject.SetActive(true);
                TestPoint14.gameObject.SetActive(true);
                TestPoint15.gameObject.SetActive(true);
                BackFromPoint.gameObject.SetActive(true);
            }
            if (ArgumentType > 2)
            {
                TestLie1.gameObject.SetActive(true);
                TestLie2.gameObject.SetActive(true);
                TestLie3.gameObject.SetActive(true);
                TestLie4.gameObject.SetActive(true);
                TestLie5.gameObject.SetActive(true);
                BackFromLie.gameObject.SetActive(true);
            }
            float RandomAttackGenerator;

            RandomAttackGenerator = (Mathf.Ceil(Random.Range(1, 15)));
            if (RandomAttackGenerator == 1)
            {

                PlayerAudienceApproval = PlayerAudienceApproval - 10;
                OpponentTakeDamage.text = ("YOU HAVE TAKEN 10 DAMAGE!!!").ToString();
            }
            if (RandomAttackGenerator == 2)
            {
                PlayerAudienceApproval = PlayerAudienceApproval - 20;
                OpponentTakeDamage.text = ("YOU HAVE TAKEN 20 DAMAGE!!!").ToString();
            }
            if (RandomAttackGenerator == 3)
            {
                PlayerAudienceApproval = PlayerAudienceApproval - 30;
                OpponentTakeDamage.text = ("YOU HAVE TAKEN 30 DAMAGE!!!").ToString();
            }
            if (RandomAttackGenerator == 4)
            {
                PlayerAudienceApproval = PlayerAudienceApproval - 40;
                OpponentTakeDamage.text = ("YOU HAVE TAKEN 40 DAMAGE!!!").ToString();
            }
            if (RandomAttackGenerator == 5)
            {
                PlayerAudienceApproval = PlayerAudienceApproval - 50;
                OpponentTakeDamage.text = ("YOU HAVE TAKEN 50 DAMAGE!!!").ToString();
            }
            if (RandomAttackGenerator == 6)
            {
                PlayerAudienceApproval = PlayerAudienceApproval - 60;
                OpponentTakeDamage.text = ("YOU HAVE TAKEN 60 DAMAGE!!!").ToString();
            }
            if (RandomAttackGenerator == 7)
            {
                PlayerAudienceApproval = PlayerAudienceApproval - 70;
                OpponentTakeDamage.text = ("YOU HAVE TAKEN 70 DAMAGE!!!").ToString();
            }
            if (RandomAttackGenerator == 8)
            {
                PlayerAudienceApproval = PlayerAudienceApproval - 80;
                OpponentTakeDamage.text = ("YOU HAVE TAKEN 80 DAMAGE!!!").ToString();
            }
            if (RandomAttackGenerator == 9)
            {
                PlayerAudienceApproval = PlayerAudienceApproval - 90;
                OpponentTakeDamage.text = ("YOU HAVE TAKEN 90 DAMAGE!!!").ToString();
            }
            if (RandomAttackGenerator == 10)
            {
                PlayerAudienceApproval = PlayerAudienceApproval - 100;
                OpponentTakeDamage.text = ("YOU HAVE TAKEN 100 DAMAGE!!!").ToString();
            }
            if (RandomAttackGenerator == 11)
            {
                PlayerAudienceApproval = PlayerAudienceApproval - 110;
                OpponentTakeDamage.text = ("YOU HAVE TAKEN 110 DAMAGE!!!").ToString();
            }
            if (RandomAttackGenerator == 12)
            {
                PlayerAudienceApproval = PlayerAudienceApproval - 120;
                OpponentTakeDamage.text = ("YOU HAVE TAKEN 120 DAMAGE!!!").ToString();
            }
            if (RandomAttackGenerator == 13)
            {
                PlayerAudienceApproval = PlayerAudienceApproval - 130;
                OpponentTakeDamage.text = ("YOU HAVE TAKEN 130 DAMAGE!!!").ToString();
            }
            if (RandomAttackGenerator == 14)
            {
                PlayerAudienceApproval = PlayerAudienceApproval - 140;
                OpponentTakeDamage.text = ("YOU HAVE TAKEN 140 DAMAGE!!!").ToString();
            }
            if (RandomAttackGenerator == 15)
            {
                PlayerAudienceApproval = PlayerAudienceApproval - 150;
                OpponentTakeDamage.text = ("YOU HAVE TAKEN 150 DAMAGE!!!").ToString();
            }
            if (EnemyAudienceApproval < (0))
            {
                PlayerTakeDamage.text = ("YOU WIN!!!").ToString();
                OpponentTakeDamage.text = ("").ToString();
            }
            if (PlayerAudienceApproval < (0))
            {
                OpponentTakeDamage.text = ("YOU LOSE!!!").ToString();
                PlayerTakeDamage.text = ("").ToString();
            }
        }
    }
    IEnumerator PlayerTimer()
    {
        yield return new WaitForSeconds(2);
        PlayerTakeDamage.text = ("").ToString();
    }
       
}
