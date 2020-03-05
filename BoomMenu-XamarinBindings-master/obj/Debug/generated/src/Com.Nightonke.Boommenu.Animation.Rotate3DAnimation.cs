using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='Rotate3DAnimation']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/Animation/Rotate3DAnimation", DoNotGenerateAcw=true)]
	public partial class Rotate3DAnimation : global::Android.Views.Animations.Animation {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/nightonke/boommenu/Animation/Rotate3DAnimation", typeof (Rotate3DAnimation));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected Rotate3DAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='Rotate3DAnimation']/constructor[@name='Rotate3DAnimation' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.Float&gt;'] and parameter[4][@type='java.util.ArrayList&lt;java.lang.Float&gt;']]"
		[Register (".ctor", "(FFLjava/util/ArrayList;Ljava/util/ArrayList;)V", "")]
		public unsafe Rotate3DAnimation (float p0, float p1, global::System.Collections.Generic.IList<global::Java.Lang.Float> p2, global::System.Collections.Generic.IList<global::Java.Lang.Float> p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFLjava/util/ArrayList;Ljava/util/ArrayList;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Float>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::Java.Lang.Float>.ToLocalJniHandle (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_set_Landroid_view_View_FF;
#pragma warning disable 0169
		static Delegate GetSet_Landroid_view_View_FFHandler ()
		{
			if (cb_set_Landroid_view_View_FF == null)
				cb_set_Landroid_view_View_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_Set_Landroid_view_View_FF);
			return cb_set_Landroid_view_View_FF;
		}

		static void n_Set_Landroid_view_View_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
		{
			global::Com.Nightonke.Boommenu.Animation.Rotate3DAnimation __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.Rotate3DAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='Rotate3DAnimation']/method[@name='set' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("set", "(Landroid/view/View;FF)V", "GetSet_Landroid_view_View_FFHandler")]
		public virtual unsafe void Set (global::Android.Views.View p0, float p1, float p2)
		{
			const string __id = "set.(Landroid/view/View;FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
