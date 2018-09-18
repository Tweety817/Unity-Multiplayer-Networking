using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;

public class Player_Network : NetworkBehaviour {

    public GameObject firstPersonCharacters;
    public GameObject[] charactersModel;

    public override void OnStartLocalPlayer()
    {
        GetComponent<FirstPersonController>().enabled = true;
        firstPersonCharacters.SetActive(true);

        foreach(GameObject go in charactersModel)
        {
            go.SetActive(false);
        }
    }
}
