// GENERATED AUTOMATICALLY FROM 'Assets/Canvas.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace PenInput
{
    public class @PenInput : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PenInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Canvas"",
    ""maps"": [
        {
            ""name"": ""Input"",
            ""id"": ""321f8c0d-dbef-44bd-816b-200a1da9f2fe"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8cb6df7f-da88-48bc-89f5-fea01e6412f0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pos"",
                    ""type"": ""PassThrough"",
                    ""id"": ""596cd40d-7ccb-4aaa-adfc-a71e6a42f507"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Press"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3682903d-17b1-4830-9e63-be56424e7965"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a8e5e149-3383-4f55-98dd-94abbad13d1a"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Canvas"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06c8128a-6069-4151-8814-687ede481544"",
                    ""path"": ""<Pen>/eraser"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Canvas"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90611a0a-8eb3-4349-ad0a-11d29f43ad19"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Canvas"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f08e27e-19b2-48cf-9964-159048fa69a0"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Canvas"",
                    ""action"": ""Pos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1642c743-ad4d-4916-b074-1e8c21d6ee0a"",
                    ""path"": ""<Pen>/pressure"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Canvas"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df302fc8-1f48-4a34-b209-c35fdc0b2695"",
                    ""path"": ""<Pen>/tilt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Canvas"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Canvas"",
            ""bindingGroup"": ""Canvas"",
            ""devices"": [
                {
                    ""devicePath"": ""<Pen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Input
            m_Input = asset.FindActionMap("Input", throwIfNotFound: true);
            m_Input_Click = m_Input.FindAction("Click", throwIfNotFound: true);
            m_Input_Pos = m_Input.FindAction("Pos", throwIfNotFound: true);
            m_Input_Press = m_Input.FindAction("Press", throwIfNotFound: true);
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
        private readonly InputAction m_Input_Click;
        private readonly InputAction m_Input_Pos;
        private readonly InputAction m_Input_Press;
        public struct InputActions
        {
            private @PenInput m_Wrapper;
            public InputActions(@PenInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Click => m_Wrapper.m_Input_Click;
            public InputAction @Pos => m_Wrapper.m_Input_Pos;
            public InputAction @Press => m_Wrapper.m_Input_Press;
            public InputActionMap Get() { return m_Wrapper.m_Input; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(InputActions set) { return set.Get(); }
            public void SetCallbacks(IInputActions instance)
            {
                if (m_Wrapper.m_InputActionsCallbackInterface != null)
                {
                    @Click.started -= m_Wrapper.m_InputActionsCallbackInterface.OnClick;
                    @Click.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnClick;
                    @Click.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnClick;
                    @Pos.started -= m_Wrapper.m_InputActionsCallbackInterface.OnPos;
                    @Pos.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnPos;
                    @Pos.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnPos;
                    @Press.started -= m_Wrapper.m_InputActionsCallbackInterface.OnPress;
                    @Press.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnPress;
                    @Press.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnPress;
                }
                m_Wrapper.m_InputActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Click.started += instance.OnClick;
                    @Click.performed += instance.OnClick;
                    @Click.canceled += instance.OnClick;
                    @Pos.started += instance.OnPos;
                    @Pos.performed += instance.OnPos;
                    @Pos.canceled += instance.OnPos;
                    @Press.started += instance.OnPress;
                    @Press.performed += instance.OnPress;
                    @Press.canceled += instance.OnPress;
                }
            }
        }
        public InputActions @Input => new InputActions(this);
        private int m_CanvasSchemeIndex = -1;
        public InputControlScheme CanvasScheme
        {
            get
            {
                if (m_CanvasSchemeIndex == -1) m_CanvasSchemeIndex = asset.FindControlSchemeIndex("Canvas");
                return asset.controlSchemes[m_CanvasSchemeIndex];
            }
        }
        public interface IInputActions
        {
            void OnClick(InputAction.CallbackContext context);
            void OnPos(InputAction.CallbackContext context);
            void OnPress(InputAction.CallbackContext context);
        }
    }
}
