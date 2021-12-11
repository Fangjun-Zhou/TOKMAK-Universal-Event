﻿using System;
using FinTOKMAK.EventSystem.Runtime;
using UnityEngine;

namespace DefaultNamespace
{
    public class LocalEventListener : MonoBehaviour
    {
        #region Public Field

        public LocalEventManager manager;

        [LocalEvent]
        public string targetEvent;

        #endregion

        private void Start()
        {
            manager.RegisterEvent(targetEvent, EventResponse);
        }

        private void OnDestroy()
        {
            manager.UnRegisterEvent(targetEvent, EventResponse);
        }

        private void EventResponse(IEventData data)
        {
            EventData<string> parsedData = (EventData<string>) data;
            Debug.Log(parsedData.data1);
        }
    }
}