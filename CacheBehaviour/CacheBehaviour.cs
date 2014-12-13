/*
 * Copyright (c) 2014, Nick Gravelyn.
 *
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 *
 *    1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would be
 *    appreciated but is not required.
 *
 *    2. Altered source versions must be plainly marked as such, and must not be
 *    misrepresented as being the original software.
 *
 *    3. This notice may not be removed or altered from any source
 *    distribution.
 */

using UnityEngine;
using UnityEngine.UI;
using System;

namespace UnityToolbag
{
    /// <summary>
    /// A safe, drop-in replacement for MonoBehaviour as your base class. Each property value is cached
    /// and GetComponent will be called if the instance is null or is destroyed.
    /// </summary>
    public abstract class CacheBehaviour : MonoBehaviour
    {
        [HideInInspector, NonSerialized]
        private Animation _animation;

        /// <summary>
        /// Gets the Animation attached to the object.
        /// </summary>
        public new Animation animation { get { return _animation ? _animation : (_animation = GetComponent<Animation>()); } }

		[HideInInspector, NonSerialized]
		private Animator _animator;

		/// <summary>
		/// Gets the Animation attached to the object.
		/// </summary>
		public Animator animator { get { return _animator ? _animator : ( _animator = GetComponent<Animator>() ); } }

		[HideInInspector, NonSerialized]
        private AudioSource _audio;

        /// <summary>
        /// Gets the AudioSource attached to the object.
        /// </summary>
        public new AudioSource audio { get { return _audio ? _audio : (_audio = GetComponent<AudioSource>()); } }

		[HideInInspector, NonSerialized]
		private Button _button;

		/// <summary>
		/// Gets the Button attached to the object.
		/// </summary>
		public Button button { get { return _button ? _button : ( _button = GetComponent<Button>() ); } }

        [HideInInspector, NonSerialized]
        private Camera _camera;

        /// <summary>
        /// Gets the Camera attached to the object.
        /// </summary>
        public new Camera camera { get { return _camera ? _camera : (_camera = GetComponent<Camera>()); } }

		[HideInInspector, NonSerialized]
		private Canvas _canvas;

		/// <summary>
		/// Gets the Canvas attached to the object.
		/// </summary>
		public Canvas canvas { get { return _canvas ? _canvas : ( _canvas = GetComponent<Canvas>() ); } }

		[HideInInspector, NonSerialized]
		private CanvasRenderer _canvasRenderer;

		/// <summary>
		/// Gets the CanvasRenderer attached to the object.
		/// </summary>
		public CanvasRenderer canvasRenderer { get { return _canvasRenderer ? _canvasRenderer : ( _canvasRenderer = GetComponent<CanvasRenderer>() ); } }

        [HideInInspector, NonSerialized]
        private Collider _collider;

        /// <summary>
        /// Gets the Collider attached to the object.
        /// </summary>
        public new Collider collider { get { return _collider ? _collider : (_collider = GetComponent<Collider>()); } }

        [HideInInspector, NonSerialized]
        private Collider2D _collider2D;

        /// <summary>
        /// Gets the Collider2D attached to the object.
        /// </summary>
        public new Collider2D collider2D { get { return _collider2D ? _collider2D : (_collider2D = GetComponent<Collider2D>()); } }

        [HideInInspector, NonSerialized]
        private ConstantForce _constantForce;

        /// <summary>
        /// Gets the ConstantForce attached to the object.
        /// </summary>
        public new ConstantForce constantForce { get { return _constantForce ? _constantForce : (_constantForce = GetComponent<ConstantForce>()); } }

		[HideInInspector, NonSerialized]
		private GridLayoutGroup _gridLayoutGroup;

		/// <summary>
		/// Gets the GridLayoutGroup attached to the object.
		/// </summary>
		public GridLayoutGroup gridLayoutGroup { get { return _gridLayoutGroup ? _gridLayoutGroup : ( _gridLayoutGroup = GetComponent<GridLayoutGroup>() ); } }

		[HideInInspector, NonSerialized]
		private HorizontalLayoutGroup _horizontalLayoutGroup;

		/// <summary>
		/// Gets the HorizontalLayoutGroup attached to the object.
		/// </summary>
		public HorizontalLayoutGroup horizontalLayoutGroup { get { return _horizontalLayoutGroup ? _horizontalLayoutGroup : ( _horizontalLayoutGroup = GetComponent<HorizontalLayoutGroup>() ); } }

        [HideInInspector, NonSerialized]
        private GUIText _guiText;

        /// <summary>
        /// Gets the GUIText attached to the object.
        /// </summary>
        public new GUIText guiText { get { return _guiText ? _guiText : (_guiText = GetComponent<GUIText>()); } }

        [HideInInspector, NonSerialized]
        private GUITexture _guiTexture;

        /// <summary>
        /// Gets the GUITexture attached to the object.
        /// </summary>
        public new GUITexture guiTexture { get { return _guiTexture ? _guiTexture : (_guiTexture = GetComponent<GUITexture>()); } }

        [HideInInspector, NonSerialized]
        private HingeJoint _hingeJoint;

        /// <summary>
        /// Gets the HingeJoint attached to the object.
        /// </summary>
        public new HingeJoint hingeJoint { get { return _hingeJoint ? _hingeJoint : (_hingeJoint = GetComponent<HingeJoint>()); } }

		[HideInInspector, NonSerialized]
		private Image _image;

		/// <summary>
		/// Gets the Image attached to the object.
		/// </summary>
		public Image image { get { return _image ? _image : ( _image = GetComponent<Image>() ); } }

		[HideInInspector, NonSerialized]
		private InputField _inputField;

		/// <summary>
		/// Gets the InputField attached to the object.
		/// </summary>
		public InputField inputField { get { return _inputField ? _inputField : ( _inputField = GetComponent<InputField>() ); } }

		[HideInInspector, NonSerialized]
		private LayoutElement _layoutElement;

		/// <summary>
		/// Gets the LayoutElement attached to the object.
		/// </summary>
		public LayoutElement layoutElement { get { return _layoutElement ? _layoutElement : ( _layoutElement = GetComponent<LayoutElement>() ); } }

		[HideInInspector, NonSerialized]
		private LayoutGroup _layoutGroup;

		/// <summary>
		/// Gets the LayoutGroup attached to the object.
		/// </summary>
		public LayoutGroup layoutGroup { get { return _layoutGroup ? _layoutGroup : ( _layoutGroup = GetComponent<LayoutGroup>() ); } }

        [HideInInspector, NonSerialized]
        private Light _light;

        /// <summary>
        /// Gets the Light attached to the object.
        /// </summary>
        public new Light light { get { return _light ? _light : (_light = GetComponent<Light>()); } }

		[HideInInspector, NonSerialized]
		private Mask _mask;

		/// <summary>
		/// Gets the Mask attached to the object.
		/// </summary>
		public Mask mask { get { return _mask ? _mask : ( _mask = GetComponent<Mask>() ); } }

        [HideInInspector, NonSerialized]
        private NetworkView _networkView;

        /// <summary>
        /// Gets the NetworkView attached to the object.
        /// </summary>
        public new NetworkView networkView { get { return _networkView ? _networkView : (_networkView = GetComponent<NetworkView>()); } }

        [HideInInspector, NonSerialized]
        private ParticleEmitter _particleEmitter;

        /// <summary>
        /// Gets the ParticleEmitter attached to the object.
        /// </summary>
        public new ParticleEmitter particleEmitter { get { return _particleEmitter ? _particleEmitter : (_particleEmitter = GetComponent<ParticleEmitter>()); } }

        [HideInInspector, NonSerialized]
        private ParticleSystem _particleSystem;

        /// <summary>
        /// Gets the ParticleSystem attached to the object.
        /// </summary>
        public new ParticleSystem particleSystem { get { return _particleSystem ? _particleSystem : (_particleSystem = GetComponent<ParticleSystem>()); } }

		[HideInInspector, NonSerialized]
		private RawImage _rawImage;

		/// <summary>
		/// Gets the RawImage attached to the object.
		/// </summary>
		public RawImage rawImage { get { return _rawImage ? _rawImage : ( _rawImage = GetComponent<RawImage>() ); } }

		[HideInInspector, NonSerialized]
		private RectTransform _rectTransform;

		/// <summary>
		/// Gets the Renderer attached to the object.
		/// </summary>
		public RectTransform rectTransform { get { return _rectTransform ? _rectTransform : ( _rectTransform = GetComponent<RectTransform>() ); } }

        [HideInInspector, NonSerialized]
        private Renderer _renderer;

        /// <summary>
        /// Gets the Renderer attached to the object.
        /// </summary>
        public new Renderer renderer { get { return _renderer ? _renderer : (_renderer = GetComponent<Renderer>()); } }

        [HideInInspector, NonSerialized]
        private Rigidbody _rigidbody;

        /// <summary>
        /// Gets the Rigidbody attached to the object.
        /// </summary>
        public new Rigidbody rigidbody { get { return _rigidbody ? _rigidbody : (_rigidbody = GetComponent<Rigidbody>()); } }

        [HideInInspector, NonSerialized]
        private Rigidbody2D _rigidbody2D;

        /// <summary>
        /// Gets the Rigidbody2D attached to the object.
        /// </summary>
        public new Rigidbody2D rigidbody2D { get { return _rigidbody2D ? _rigidbody2D : (_rigidbody2D = GetComponent<Rigidbody2D>()); } }

		[HideInInspector, NonSerialized]
		private Scrollbar _scrollbar;

		/// <summary>
		/// Gets the Scrollbar attached to the object.
		/// </summary>
		public Scrollbar scrollbar { get { return _scrollbar ? _scrollbar : ( _scrollbar = GetComponent<Scrollbar>() ); } }

		[HideInInspector, NonSerialized]
		private ScrollRect _scrollRect;

		/// <summary>
		/// Gets the ScrollRect attached to the object.
		/// </summary>
		public ScrollRect scrollRect { get { return _scrollRect ? _scrollRect : ( _scrollRect = GetComponent<ScrollRect>() ); } }

		[HideInInspector, NonSerialized]
		private Slider _slider;

		/// <summary>
		/// Gets the Slider attached to the object.
		/// </summary>
		public Slider slider { get { return _slider ? _slider : ( _slider = GetComponent<Slider>() ); } }

		[HideInInspector, NonSerialized]
		private SpriteRenderer _spriteRenderer;

		/// <summary>
		/// Gets the SpriteRenderer attached to the object.
		/// </summary>
		public SpriteRenderer spriteRenderer { get { return _spriteRenderer ? _spriteRenderer : ( _spriteRenderer = GetComponent<SpriteRenderer>() ); } }

		[HideInInspector, NonSerialized]
		private Text _text;

		/// <summary>
		/// Gets the Text attached to the object.
		/// </summary>
		public Text text { get { return _text ? _text : ( _text = GetComponent<Text>() ); } }

		[HideInInspector, NonSerialized]
		private Toggle _toggle;

		/// <summary>
		/// Gets the Toggle attached to the object.
		/// </summary>
		public Toggle toggle { get { return _toggle ? _toggle : ( _toggle = GetComponent<Toggle>() ); } }

		[HideInInspector, NonSerialized]
		private ToggleGroup _toggleGroup;

		/// <summary>
		/// Gets the ToggleGroup attached to the object.
		/// </summary>
		public ToggleGroup toggleGroup { get { return _toggleGroup ? _toggleGroup : ( _toggleGroup = GetComponent<ToggleGroup>() ); } }

        [HideInInspector, NonSerialized]
        private Transform _transform;

        /// <summary>
        /// Gets the Transform attached to the object.
        /// </summary>
        public new Transform transform { get { return _transform ? _transform : (_transform = GetComponent<Transform>()); } }

		[HideInInspector, NonSerialized]
		private VerticalLayoutGroup _verticalLayoutGroup;

		/// <summary>
		/// Gets the VerticalLayoutGroup attached to the object.
		/// </summary>
		public VerticalLayoutGroup verticalLayoutGroup { get { return _verticalLayoutGroup ? _verticalLayoutGroup : ( _verticalLayoutGroup = GetComponent<VerticalLayoutGroup>() ); } }
	}
}
