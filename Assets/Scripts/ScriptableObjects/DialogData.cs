using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "DialogData", menuName = "Progra2/DialogData")]
public class DialogData : ScriptableObject
{
    [SerializeField] private TextAsset textJson;
    [SerializeField] private TextAsset optionsJson;

    public TextAsset TextJson { get => textJson; }
    public TextAsset OptionsJson { get => optionsJson; }
}
