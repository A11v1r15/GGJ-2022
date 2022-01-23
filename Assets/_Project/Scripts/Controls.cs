//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/_Project/Scripts/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""MagNet"",
            ""id"": ""02cea319-d7cc-4bd5-a6ca-ee83036c260d"",
            ""actions"": [
                {
                    ""name"": ""MagMove"",
                    ""type"": ""Value"",
                    ""id"": ""f846b176-15bb-4f76-9b5d-55fd2940333a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""NetMove"",
                    ""type"": ""Value"",
                    ""id"": ""99f11bf4-b4fa-4521-9e83-2c35a181c182"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MagChange"",
                    ""type"": ""Button"",
                    ""id"": ""314706a9-d66b-4703-9a3e-8f29f8f35236"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""NetChange"",
                    ""type"": ""Button"",
                    ""id"": ""6cc8afe3-ae47-46a9-9fc6-6495b7f75439"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""7d357e35-61b8-4e63-854e-720e017f100b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MagMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c7d11aa0-4eea-43e3-ba17-99750dbcc282"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MagMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ef0839c0-3903-4ca8-836e-1845b4958699"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MagMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""7105684c-89ee-413d-a374-a53e8851656c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NetMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c760c2b5-9c84-4333-96a0-afb93a54bb47"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NetMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2aad97f3-30bf-47d2-8890-5475156146c2"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NetMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9777b0c4-ff80-456d-b467-bea2a0c42853"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MagChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e62e49a9-3d57-4308-9cba-96933666bd5b"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NetChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MagNet
        m_MagNet = asset.FindActionMap("MagNet", throwIfNotFound: true);
        m_MagNet_MagMove = m_MagNet.FindAction("MagMove", throwIfNotFound: true);
        m_MagNet_NetMove = m_MagNet.FindAction("NetMove", throwIfNotFound: true);
        m_MagNet_MagChange = m_MagNet.FindAction("MagChange", throwIfNotFound: true);
        m_MagNet_NetChange = m_MagNet.FindAction("NetChange", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // MagNet
    private readonly InputActionMap m_MagNet;
    private IMagNetActions m_MagNetActionsCallbackInterface;
    private readonly InputAction m_MagNet_MagMove;
    private readonly InputAction m_MagNet_NetMove;
    private readonly InputAction m_MagNet_MagChange;
    private readonly InputAction m_MagNet_NetChange;
    public struct MagNetActions
    {
        private @Controls m_Wrapper;
        public MagNetActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MagMove => m_Wrapper.m_MagNet_MagMove;
        public InputAction @NetMove => m_Wrapper.m_MagNet_NetMove;
        public InputAction @MagChange => m_Wrapper.m_MagNet_MagChange;
        public InputAction @NetChange => m_Wrapper.m_MagNet_NetChange;
        public InputActionMap Get() { return m_Wrapper.m_MagNet; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MagNetActions set) { return set.Get(); }
        public void SetCallbacks(IMagNetActions instance)
        {
            if (m_Wrapper.m_MagNetActionsCallbackInterface != null)
            {
                @MagMove.started -= m_Wrapper.m_MagNetActionsCallbackInterface.OnMagMove;
                @MagMove.performed -= m_Wrapper.m_MagNetActionsCallbackInterface.OnMagMove;
                @MagMove.canceled -= m_Wrapper.m_MagNetActionsCallbackInterface.OnMagMove;
                @NetMove.started -= m_Wrapper.m_MagNetActionsCallbackInterface.OnNetMove;
                @NetMove.performed -= m_Wrapper.m_MagNetActionsCallbackInterface.OnNetMove;
                @NetMove.canceled -= m_Wrapper.m_MagNetActionsCallbackInterface.OnNetMove;
                @MagChange.started -= m_Wrapper.m_MagNetActionsCallbackInterface.OnMagChange;
                @MagChange.performed -= m_Wrapper.m_MagNetActionsCallbackInterface.OnMagChange;
                @MagChange.canceled -= m_Wrapper.m_MagNetActionsCallbackInterface.OnMagChange;
                @NetChange.started -= m_Wrapper.m_MagNetActionsCallbackInterface.OnNetChange;
                @NetChange.performed -= m_Wrapper.m_MagNetActionsCallbackInterface.OnNetChange;
                @NetChange.canceled -= m_Wrapper.m_MagNetActionsCallbackInterface.OnNetChange;
            }
            m_Wrapper.m_MagNetActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MagMove.started += instance.OnMagMove;
                @MagMove.performed += instance.OnMagMove;
                @MagMove.canceled += instance.OnMagMove;
                @NetMove.started += instance.OnNetMove;
                @NetMove.performed += instance.OnNetMove;
                @NetMove.canceled += instance.OnNetMove;
                @MagChange.started += instance.OnMagChange;
                @MagChange.performed += instance.OnMagChange;
                @MagChange.canceled += instance.OnMagChange;
                @NetChange.started += instance.OnNetChange;
                @NetChange.performed += instance.OnNetChange;
                @NetChange.canceled += instance.OnNetChange;
            }
        }
    }
    public MagNetActions @MagNet => new MagNetActions(this);
    public interface IMagNetActions
    {
        void OnMagMove(InputAction.CallbackContext context);
        void OnNetMove(InputAction.CallbackContext context);
        void OnMagChange(InputAction.CallbackContext context);
        void OnNetChange(InputAction.CallbackContext context);
    }
}
