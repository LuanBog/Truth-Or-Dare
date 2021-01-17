using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour {

    public Text resultText;

    private Data data;

    private void Start() {
        data = FindObjectOfType<Data>();
    }

    public void Click(string tod) {
        // tod = truth / dare

        string result = data.getData(tod, "child");

        resultText.text = "Your " + tod + " is \"" + result + "\"";
    }

}
