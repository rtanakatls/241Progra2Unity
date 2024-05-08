using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogController : MonoBehaviour
{
    [SerializeField] private DialogData dialogData;
    [SerializeField] private DialogArray dialogArray;
    [SerializeField] private OptionArray optionArray;
    private DialogText currentDialog;
    private List<OptionText> currentOptions;
    void Awake()
    {
        currentOptions = null;
        dialogArray=JsonUtility.FromJson<DialogArray>(dialogData.TextJson.text);
        optionArray=JsonUtility.FromJson<OptionArray>(dialogData.OptionsJson.text);
        if(dialogArray.dialogs.Length>0)
        {
            currentDialog = dialogArray.dialogs[0];
            Debug.Log(currentDialog.text);
        }
    }

    private void Update()
    {
        if (currentOptions != null)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                ShowDialog(currentOptions[0].nextDialog);
                currentOptions = null;
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                ShowDialog(currentOptions[1].nextDialog);
                currentOptions = null;
            }
            else if(Input.GetKeyDown(KeyCode.Alpha3))
            {
                ShowDialog(currentOptions[2].nextDialog); 
                currentOptions = null;

            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentDialog.next == -2)
            {
                ShowOption(currentDialog);
            }
            else
            {
                ShowDialog(currentDialog.next);
            }

            
            
        }
    }

    private void ShowDialog(int id)
    {

        DialogText dialog = SearchDialog(id);
        if (dialog != null)
        {
            Debug.Log(dialog.text);
            currentDialog = dialog;
        }
    }
    private void ShowOption(DialogText dialog)
    {
        foreach(OptionText option in optionArray.options)
        {
            if (option.id == dialog.nextOption)
            {
                Debug.Log(option.text);
                if(currentOptions==null)
                {
                    currentOptions = new List<OptionText>();
                }
                currentOptions.Add(option);
            }
        }
    }
    private DialogText SearchDialog(int id)
    {
        foreach (DialogText dialog in dialogArray.dialogs)
        {
            if (dialog.id == id)
            {
                return dialog;
            }
        }
        
        return null;
    }
}
