using System;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace FashionStore.Behavior
{
    public class ViewTappedButtonBehavior : Behavior<View>
    {
        public static readonly BindableProperty AnimationTypeProperty =
            BindableProperty.Create(nameof(AnimationType), typeof(AnimationType), typeof(ViewTappedButtonBehavior), AnimationType.Fade);

        public AnimationType AnimationType
        {
            get { return (AnimationType)GetValue(AnimationTypeProperty); }
            set { SetValue(AnimationTypeProperty, value); }
        }

        public static readonly BindableProperty ScaleToProperty =
            BindableProperty.Create(nameof(ScaleTo), typeof(double), typeof(ViewTappedButtonBehavior), 1.2);

        public double ScaleTo
        {
            get { return (double)GetValue(ScaleToProperty); }
            set { SetValue(AnimationTypeProperty, value); }
        }

        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(ViewTappedButtonBehavior), null, defaultBindingMode: BindingMode.TwoWay);


        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly BindableProperty CommandParameterProperty =
            BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(ViewTappedButtonBehavior), null);

        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public View AssociatedObject { get; private set; }

        protected override void OnAttachedTo(View bindable)
        {
            base.OnAttachedTo(bindable);
            AssociatedObject = bindable;
            bindable.BindingContextChanged += OnBindingContextChanged;

            if (bindable is Button myButton)
            {
                myButton.Clicked += View_Tapped;
            }
            else if (bindable is Switch mySwitch)
            {
                mySwitch.Toggled += View_Tapped;
            }
            else
            {
                var tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += View_Tapped;
                bindable.GestureRecognizers.Add(tapGestureRecognizer);
            }

            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(View bindable)
        {
            bindable.BindingContextChanged -= OnBindingContextChanged;
            AssociatedObject = null;

            var exists = bindable.GestureRecognizers.FirstOrDefault() as TapGestureRecognizer;

            if (exists != null)
                exists.Tapped -= View_Tapped;

            base.OnDetachingFrom(bindable);
        }

        bool _isAnimating = false;

        void View_Tapped(object sender, EventArgs e)
        {
            if (_isAnimating)
                return;

            _isAnimating = true;

            var view = (View)sender;

            Device.BeginInvokeOnMainThread(async () =>
            {
                try
                {
                    if (AnimationType == AnimationType.Fade)
                    {
                        await view.FadeTo(0.3, 300);
                        await view.FadeTo(1, 300);
                    }
                    else if (AnimationType == AnimationType.Scale)
                    {
                        await view.ScaleTo(ScaleTo, 170, easing: Easing.Linear);
                        await view.ScaleTo(1, 170, easing: Easing.Linear);
                    }
                    else if (AnimationType == AnimationType.Rotate)
                    {
                        await view.RotateTo(360, 200, easing: Easing.Linear);
                        view.Rotation = 0;
                    }
                    else if (AnimationType == AnimationType.FlipHorizontal)
                    {
                        // Perform half of the flip
                        await view.RotateYTo(90, 200);
                        await view.RotateYTo(0, 200);
                    }
                    else if (AnimationType == AnimationType.FlipVertical)
                    {
                        // Perform half of the flip
                        await view.RotateXTo(90, 200);
                        await view.RotateXTo(0, 200);
                    }
                    else if (AnimationType == AnimationType.Shake)
                    {
                        await view.TranslateTo(-15, 0, 50);
                        await view.TranslateTo(15, 0, 50);
                        await view.TranslateTo(-10, 0, 50);
                        await view.TranslateTo(10, 0, 50);
                        await view.TranslateTo(-5, 0, 50);
                        await view.TranslateTo(5, 0, 50);
                        view.TranslationX = 0;
                    }
                }
                finally
                {
                    if (Command != null)
                    {
                        if (Command.CanExecute(CommandParameter))
                        {
                            Command.Execute(CommandParameter);
                        }
                    }
                    System.Diagnostics.Debug.WriteLine(CommandParameter);

                    _isAnimating = false;
                }
            });
        }

        void OnBindingContextChanged(object sender, EventArgs e)
        {
            OnBindingContextChanged();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            BindingContext = AssociatedObject.BindingContext;
        }
    }

    public enum AnimationType
    {
        Fade,
        FlipHorizontal,
        FlipVertical,
        Rotate,
        Scale,
        Shake
    }
    
}
