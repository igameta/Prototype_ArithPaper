// GENERATED AUTOMATICALLY FROM 'Assets/PenControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PenControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PenControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PenControl"",
    ""maps"": [
        {
            ""name"": ""Input"",
            ""id"": ""a6553d66-42bc-4cf4-9ad5-6a804d96592f"",
            ""actions"": [
                {
                    ""name"": ""PenTip"",
                    ""type"": ""PassThrough"",
                    ""id"": ""63f5b858-6b41-4f59-bf3b-ffac46d0d61b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""PenEraser"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a7ff1a85-bb1c-47cf-8ff4-1871f67b21ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""PenPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6fbe6db5-941a-4c92-8731-bacb787b2506"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""PenPress"",
                    ""type"": ""Value"",
                    ""id"": ""81d253e6-cebe-44d0-8dcb-80b644e0b1ed"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c9cc760f-4022-42ac-b58d-309158322fa4"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Drawing"",
                    ""action"": ""PenTip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23586f74-39bb-402f-9b02-74dd4f1ba9ba"",
                    ""path"": ""<Pen>/eraser"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Drawing"",
                    ""action"": ""PenEraser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""804ae053-cbe5-4746-9b89-9fde1efdb24d"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Drawing"",
                    ""action"": ""PenPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6a3b889-7a96-4688-afc1-6bab02a0cdf8"",
                    ""path"": ""<Pen>/pressure"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Drawing"",
                    ""action"": ""PenPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""be543064-d67a-4bc5-9e54-d512807449b5"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""94f65ee7-281c-4333-b9ef-b0d6de4b6646"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""089d8e51-5493-41ae-84cc-60ecf38b4ee2"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Drawing"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cceb1202-d23d-4309-96a4-1cca052693a8"",
                    ""path"": ""<Touchscreen>/primaryTouch"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Drawing"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Drawing"",
            ""bindingGroup"": ""Drawing"",
            ""devices"": [
                {
                    ""devicePath"": ""<Pen>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Input
        m_Input = asset.FindActionMap("Input", throwIfNotFound: true);
        m_Input_PenTip = m_Input.FindAction("PenTip", throwIfNotFound: true);
        m_Input_PenEraser = m_Input.FindAction("PenEraser", throwIfNotFound: true);
        m_Input_PenPosition = m_Input.FindAction("PenPosition", throwIfNotFound: true);
        m_Input_PenPress = m_Input.FindAction("PenPress", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
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

    // Input
    private readonly InputActionMap m_Input;
    private IInputActions m_InputActionsCallbackInterface;
    private readonly InputAction m_Input_PenTip;
    private readonly InputAction m_Input_PenEraser;
    private readonly InputAction m_Input_PenPosition;
    private readonly InputAction m_Input_PenPress;
    public struct InputActions
    {
        private @PenControl m_Wrapper;
        public InputActions(@PenControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @PenTip => m_Wrapper.m_Input_PenTip;
        public InputAction @PenEraser => m_Wrapper.m_Input_PenEraser;
        public InputAction @PenPosition => m_Wrapper.m_Input_PenPosition;
        public InputAction @PenPress => m_Wrapper.m_Input_PenPress;
        public InputActionMap Get() { return m_Wrapper.m_Input; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InputActions set) { return set.Get(); }
        public void SetCallbacks(IInputActions instance)
        {
            if (m_Wrapper.m_InputActionsCallbackInterface != null)
            {
                @PenTip.started -= m_Wrapper.m_InputActionsCallbackInterface.OnPenTip;
                @PenTip.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnPenTip;
                @PenTip.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnPenTip;
                @PenEraser.started -= m_Wrapper.m_InputActionsCallbackInterface.OnPenEraser;
                @PenEraser.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnPenEraser;
                @PenEraser.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnPenEraser;
                @PenPosition.started -= m_Wrapper.m_InputActionsCallbackInterface.OnPenPosition;
                @PenPosition.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnPenPosition;
                @PenPosition.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnPenPosition;
                @PenPress.started -= m_Wrapper.m_InputActionsCallbackInterface.OnPenPress;
                @PenPress.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnPenPress;
                @PenPress.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnPenPress;
            }
            m_Wrapper.m_InputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PenTip.started += instance.OnPenTip;
                @PenTip.performed += instance.OnPenTip;
                @PenTip.canceled += instance.OnPenTip;
                @PenEraser.started += instance.OnPenEraser;
                @PenEraser.performed += instance.OnPenEraser;
                @PenEraser.canceled += instance.OnPenEraser;
                @PenPosition.started += instance.OnPenPosition;
                @PenPosition.performed += instance.OnPenPosition;
                @PenPosition.canceled += instance.OnPenPosition;
                @PenPress.started += instance.OnPenPress;
                @PenPress.performed += instance.OnPenPress;
                @PenPress.canceled += instance.OnPenPress;
            }
        }
    }
    public InputActions @Input => new InputActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Click;
    public struct UIActions
    {
        private @PenControl m_Wrapper;
        public UIActions(@PenControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_DrawingSchemeIndex = -1;
    public InputControlScheme DrawingScheme
    {
        get
        {
            if (m_DrawingSchemeIndex == -1) m_DrawingSchemeIndex = asset.FindControlSchemeIndex("Drawing");
            return asset.controlSchemes[m_DrawingSchemeIndex];
        }
    }
    public interface IInputActions
    {
        void OnPenTip(InputAction.CallbackContext context);
        void OnPenEraser(InputAction.CallbackContext context);
        void OnPenPosition(InputAction.CallbackContext context);
        void OnPenPress(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnClick(InputAction.CallbackContext context);
    }
}
