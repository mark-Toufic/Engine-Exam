using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public static TutorialManager instance;
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //Tutorial quests
    [SerializeField] public bool wQuest;
    [SerializeField] public bool aQuest;
    [SerializeField] public bool sQuest;
    [SerializeField] public bool dQuest;
    [SerializeField] public bool jumpQuest;
    [SerializeField] public bool clickQuest;
    public Text quest;

    // Start is called before the first frame update
    void Start()
    {
        quest.text = "Press W to walk forward";

    }

    // Update is called once per frame
    void Update()
    {
        if (wQuest)
        {
            quest.text = "Press A to walk left";
            if (aQuest)
            {
                quest.text = "Press S to walk backwards";
                if (sQuest)
                {
                    quest.text = "Press D to walk right";
                    if (dQuest)
                    {
                        quest.text = "Press spacebar to jump";
                        if (jumpQuest)
                        {
                            quest.text = "Left click to shoot";
                            if (clickQuest)
                            {
                                quest.enabled = false;
                            }
                        }
                    }
                }
            }
        }
    }
}
