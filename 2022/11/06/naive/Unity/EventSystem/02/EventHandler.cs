using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventHandler
{
    //�����������UI��ί��
    public static event Action<ItemDetails, int> UpdateUIEvent;

    //public static string test(ItemDetails itemDetails, int index) { return "where"; }
    public static void CallUpdateUIEvent(ItemDetails itemDetails,int index)
    {
        UpdateUIEvent?.Invoke(itemDetails,index);
    }


    //�����л���������ж�ص�ǰ����֮ǰҪ����Ʒ���ݱ��棬���ڼ����³�������Ҫ����Ʒ���ݼ��س���
    public static event Action beforeSceneUnload;
    public static void CallBeforeSceneUload()
    {
        beforeSceneUnload?.Invoke();
    }
    public static event Action afterSceneLoad;
    public static void CallAfterSceneLoad() { afterSceneLoad?.Invoke(); }



    //ѡ���������¼�
    public static event Action<ItemDetails,bool> ItemSelectEvent;

    public static void CallItemSelectEvent(ItemDetails itemDetails,bool isSelected)
    {
        ItemSelectEvent?.Invoke(itemDetails,isSelected);
    }

    //�Ƴ�ʹ�ù�������
    public static event Action<ItemName> itemUsedEvent;

    public static void CallItemUsedEvent(ItemName itemName)
    {
        itemUsedEvent?.Invoke(itemName);
    }


    //�ı�ѡ�еı����е�����
    public static event Action<int> ItemChange;
    public static void CallItemChange(int index)
    {
        ItemChange?.Invoke(index);
    }


    //��ʾ�Ի�UI
    public static event Action<string> ShowDialogueEvent;
    public static void CallShowDialogueEvent(string data)
    {
        ShowDialogueEvent?.Invoke(data);
    }

    //��Ϸ״̬�л�,�����ֹ�Ի�ʱ�л�����
    public static event Action<GameStates> ChangeGameState;
    public static void CallChangeGameState(GameStates gameState)
    {
        ChangeGameState?.Invoke(gameState);
    }

    //���ڼ���H2AС��Ϸ�Ľ����¼�
    public static event Action CheckGameH2AState;
    public static void CallCheckGameH2AState()
    {
        CheckGameH2AState?.Invoke();    
    }


    //���ݳ������֣���������Ϸ���������ģ����Ҫ���ø�������Ϸ��״̬����Ҫ���Ƿ��Ѿ������Ϸ��bool�����ݹ�ȥ
    //������¼

    public static event Action<string> GamePassEvent;
    public static void CallGamePassEvent(string gameName)
    {
        GamePassEvent?.Invoke(gameName);
    }


    public static event Action StartNewGameEvent;
    public static void CallStartNewGameEvent(){
        StartNewGameEvent?.Invoke();
    }



}
