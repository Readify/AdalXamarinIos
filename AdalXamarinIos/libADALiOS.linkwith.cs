using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libADALiOS.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true)]
