using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.MLAgents;
using System.IO;
using System.Linq;

public class environmentManager : MonoBehaviour
{
    [Header("Agents")]
    public int numOfAgents;
    public GameObject agentPrefab;
    private GameObject agentParent;


    // Start is called before the first frame update
    void Start()
    {
         // Create Agents
        this.agentParent = GameObject.Find("Agents").gameObject;
        instantiateAgents();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Create agents from "AgentPrefab" prefab
    private void instantiateAgents()
    {

        WaitForSeconds wait = new WaitForSeconds(UnityEngine.Random.Range(3, 6));
        List<int> idList = Enumerable.Range(1, this.numOfAgents).ToList();

        while(idList.Count > 0)
        {
            int randomIndex = UnityEngine.Random.Range(0, idList.Count);
            int tempID = idList[randomIndex];
            idList.RemoveAt(randomIndex);
            GameObject tempAgent = Instantiate(this.agentPrefab, new Vector3(0, tempID, 0), Quaternion.identity, this.agentParent.transform);
        }
    }
}
