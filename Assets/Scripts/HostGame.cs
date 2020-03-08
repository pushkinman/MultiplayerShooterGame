using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class HostGame : NetworkBehaviour
{
    [SerializeField]
    private uint roomSize = 6;

    private string roomName;

    public Text inputText;

    private NetworkManager networkManager;

    private void Start()
    {
        networkManager = NetworkManager.singleton;
        if (networkManager.matchMaker == null)
        {
            networkManager.StartMatchMaker();
        }
    }

    public void SetRoomName()
    {
        roomName = inputText.text;
    }

    public void CreateRoom()
    {
        if(roomName != "" && roomName != null)
        {
            Debug.Log("Creating Room: " + roomName + " with room for " + roomSize + " players");
            //create room
            networkManager.matchMaker.CreateMatch(roomName, roomSize, true, "","","", 0, 0, networkManager.OnMatchCreate);
        }
    }
}
