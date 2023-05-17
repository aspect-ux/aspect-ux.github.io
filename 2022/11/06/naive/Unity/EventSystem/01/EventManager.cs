using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public interface IEventInfo { }

public class EventInfo<T> : IEventInfo
{
    public UnityAction<T> action;
}

public class EventInfo : IEventInfo
{
    public UnityAction action;
}

public class EventManager
{
    private static EventManager instance;
    
    public static EventManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new EventManager();
            }
            return instance;
        }
    }
    
    public Dictionary<string, IEventInfo> actionDic = new Dictionary<string, IEventInfo>();
    
    public void AddEventListener(string actionName, UnityAction action)
    {
        if (actionDic.ContainsKey(actionName)) 
        {
            (actionDic[actionName] as EventInfo).action += action;
        }
        else 
        {
            actionDic.Add(actionName, new EventInfo() { action = action });
        }
    }

    public void AddEventListener<T>(string actionName, UnityAction<T> action)
    {
        if (actionDic.ContainsKey(actionName))
        {
            (actionDic[actionName] as EventInfo<T>).action += action;
        }
        else
        {
            actionDic.Add(actionName, new EventInfo<T>() { action = action });
        }
    }


    public void RemoveEventListener(string actionName, UnityAction action)
    {

        if (actionDic.ContainsKey(actionName))
        {
            (actionDic[actionName] as EventInfo).action -= action;
        }
    }

    public void RemoveEventListener<T>(string actionName, UnityAction<T> action)
    {
        if (actionDic.ContainsKey(actionName))
        {
            (actionDic[actionName] as EventInfo<T>).action -= action;
        }
    }
    
    public void TriggerEventListener(string actionName)
    {

        if (actionDic.ContainsKey(actionName)) 
        {
            (actionDic[actionName] as EventInfo).action?.Invoke();
        }
    }

    public void TriggerEventListener<T>(string actionName, T par)
    {

        if (actionDic.ContainsKey(actionName))
        {
            (actionDic[actionName] as EventInfo<T>).action?.Invoke(par);
        }
    }


    public void CleanEventListener()
    {
        actionDic.Clear();
    }

}
