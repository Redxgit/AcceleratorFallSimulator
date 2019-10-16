using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    [SerializeField] private Text fileName;
    [SerializeField] private AccelerometerFromDeltaPosition filesaver;
    [SerializeField] private FromAnimToRagdoll anim;


    public void UISaveToFile() {
        filesaver.WriteInfoToFile(fileName.text);
    }

    public void UIReset() {
        anim.ResetThings();
    }

    public void UIWalk() {
        anim.StartWalking();
    }
}
