using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EmailController : MonoBehaviour
{
    public TextMeshProUGUI subjectTB;
    public TextMeshProUGUI fromEmailTB;
    public TextMeshProUGUI dateTimeTB;
    public TextMeshProUGUI bodyTB;

    public Button[] emailButton;
    public emailButton1 emailData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PopulateEmail(int index)
    {
        emailData = emailButton[index].GetComponent<emailButton1>();
        subjectTB.text = emailData.subject;
        fromEmailTB.text = emailData.fromEmail;
        dateTimeTB.text = emailData.dateTime;
        bodyTB.text = emailData.body;
    }

}
