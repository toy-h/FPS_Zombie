using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
// 목적: 게임의 상태

//목적2 : 2초 후 Ready 상태에서 Start 상태로 변경되며 게임이 시작된다. 

//목적3 : 플레이어의 hp가 0보다 작으면 상태 텍스트를 GameOver로 바꿔주고 상태 또한 GameOver로 바꿔준다. 

//목적3 :  Ready 상태일 때는 플레이어, 적이 움직일 수 없도록 한다. 
//필요속성 : hp가 들어 있는 playerMove 
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

    }
    public enum GameState
    {
        Ready,
        Start,
        GameOver

    }

    public GameState state = GameState.Ready;
    public TMP_Text stateText;
    //필요속성 : hp가 들어 있는 playerMove 
    PlayerMove Player;
    // 필요 속성 : 게임상태 열거형 변수
    // Start is called before the first frame update
    void Start()
    {
        stateText.text = "Ready";
        stateText.color = new Color32(255, 185, 0, 255);

        StartCoroutine(GameStart());
        //stateText.ver = new Color32()

        Player = GameObject.Find("Player").GetComponent<PlayerMove>();
    }

    //목적2 : 2초 후 Ready 상태에서 Start 상태로 변경되며 게임이 시작된다. 
    IEnumerator GameStart()
    {
        // 2초를 기다린다. 
        yield return new WaitForSeconds(2);

        stateText.text = "Game Start";
        stateText.color = new Color32(0, 255, 0, 255);
        //0.5초를 기다린다. 
        yield return new WaitForSeconds(0.5f);

        stateText.gameObject.SetActive(false);

        state = GameState.Start;
    }

    //목적3 : 플레이어의 hp가 0보다 작으면 상태 텍스트를 GameOver로 바꿔주고 상태 또한 GameOver로 바꿔준다. 
    void Update()
    {

        CheckGameOver();
    }
    void CheckGameOver()
    {

        if (Player.hp <= 0)
        {
            //상태 텍스트를 On으로 변경
            stateText.gameObject.SetActive(true);

            //상태 텍스트를 GameOver로 변경}
            stateText.text = "Game Over";
            stateText.color = new Color32(255, 0, 0, 255);

            state = GameState.GameOver;
        }
    }
}
