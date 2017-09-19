using System;
using JMFacebookLogin.Droid.Renderers;
using JMFacebookLogin.View;
using Xamarin.Facebook.Login.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(FacebookLoginButton), typeof(FacebookLoginButtonRenderer))]
namespace JMFacebookLogin.Droid.Renderers
{
    /// <summary>
    /// Facebook login button renderer.
    /// </summary>
    public class FacebookLoginButtonRenderer : ViewRenderer<FacebookLoginButton, LoginButton>
    {
        /// <summary>
        /// The facebook login button.
        /// </summary>
		LoginButton facebookLoginButton;

        /// <summary>
        /// Ons the element changed.
        /// </summary>
        /// <param name="e">E.</param>
		protected override void OnElementChanged(ElementChangedEventArgs<FacebookLoginButton> e)
		{
			base.OnElementChanged(e);

			if (Control == null || facebookLoginButton == null)
			{
				facebookLoginButton = new LoginButton(Forms.Context);

				SetNativeControl(facebookLoginButton);
			}
		}
    }
}
