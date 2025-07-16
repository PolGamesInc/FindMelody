using UnityEngine;
using TMPro;

public class TeamsManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField NameTeam1;
    [SerializeField] private TMP_InputField NameTeam2;
    [SerializeField] private TMP_InputField NameTeam3;
    [SerializeField] private TMP_InputField NameTeam4;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Home))
        {
            NameTeam1.ActivateInputField();
        }

        if (Input.GetKeyDown(KeyCode.PageUp))
        {
            NameTeam2.ActivateInputField();
        }

        if (Input.GetKeyDown(KeyCode.End))
        {
            NameTeam3.ActivateInputField();
        }

        if (Input.GetKeyDown(KeyCode.PageDown))
        {
            NameTeam4.ActivateInputField();
        }
    }
}
