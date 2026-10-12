using UnityEngine;

public class Client : MonoBehaviour {
    public NPCSpawner npcSpawner;

    void Update() {
        if (Input.GetKeyDown(KeyCode.S)) {
            npcSpawner.SpawnVillagers();
        }
    }
}
