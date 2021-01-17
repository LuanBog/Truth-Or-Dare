using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour {

    // Truth
    private string[] childTruth = { 
        "What candy do you like to eat?",
        "How many candy do you eat in a day?",
        "What is your pet's name?",
        "What is the color of your hair?",
        "Do you love your family?"
    };

    // Dare
    private string[] childDare = {
        "Eat your favorite candy",
        "Spin once",
        "Tell your parents you love them",
        "Say \"I'm a big cute baby!\"",
        "Draw a dinosour"
    };

    public string getData(string tod, string intensity) {
        // tod = truth / dare
        // intensity = child / easy / spicy / party

        string[] listChosen = {};

        // This is a very inefficient code, so make this better someday
        if (tod == "truth" && intensity == "child")
            listChosen = childTruth;
        if (tod == "dare" && intensity == "child")
            listChosen = childDare;

        // Checks if listChosen is NOT nothing
        if (listChosen != null) {
            // If it has something, return a truth or dare

            return listChosen[Random.Range(0, listChosen.Length)];
        }

        return null;
    }

}
