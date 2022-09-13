using Airbnb.Lottie;

namespace Lottie.iOS.Demo;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    public override UIWindow? Window { get; set; }

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        // create a new window instance based on the screen size
        Window = new UIWindow(UIScreen.MainScreen.Bounds);

        // create a UIViewController with a single UILabel
        var vc = new UIViewController();
        LOTAnimationView animation = LOTAnimationView.AnimationNamed("DoneAnimation");
        animation.ContentMode = UIViewContentMode.ScaleAspectFit;
        animation.AnimationSpeed = 0.35f;
        animation.LoopAnimation = true;

        vc.View.AddSubview(animation);


        animation.WidthAnchor.ConstraintEqualTo(vc.View.WidthAnchor).Active = true;
        animation.HeightAnchor.ConstraintEqualTo(vc.View.HeightAnchor).Active = true;

        animation.Play();



        Window.RootViewController = vc;

        // make the window visible
        Window.MakeKeyAndVisible();

        return true;
    }
}