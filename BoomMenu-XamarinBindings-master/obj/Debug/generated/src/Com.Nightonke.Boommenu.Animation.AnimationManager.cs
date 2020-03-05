using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/Animation/AnimationManager", DoNotGenerateAcw=true)]
	public partial class AnimationManager : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/nightonke/boommenu/Animation/AnimationManager", typeof (AnimationManager));
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

		protected AnimationManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/constructor[@name='AnimationManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnimationManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='animate' and count(parameter)=7 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='android.animation.TimeInterpolator'] and parameter[6][@type='android.animation.AnimatorListenerAdapter'] and parameter[7][@type='float...']]"
		[Register ("animate", "(Ljava/lang/Object;Ljava/lang/String;JJLandroid/animation/TimeInterpolator;Landroid/animation/AnimatorListenerAdapter;[F)Landroid/animation/ObjectAnimator;", "")]
		public static unsafe global::Android.Animation.ObjectAnimator Animate (global::Java.Lang.Object p0, string p1, long p2, long p3, global::Android.Animation.ITimeInterpolator p4, global::Android.Animation.AnimatorListenerAdapter p5, params float[] p6)
		{
			const string __id = "animate.(Ljava/lang/Object;Ljava/lang/String;JJLandroid/animation/TimeInterpolator;Landroid/animation/AnimatorListenerAdapter;[F)Landroid/animation/ObjectAnimator;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				__args [6] = new JniArgumentValue (native_p6);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.ObjectAnimator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='animate' and count(parameter)=6 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='android.animation.TimeInterpolator'] and parameter[6][@type='float...']]"
		[Register ("animate", "(Ljava/lang/Object;Ljava/lang/String;JJLandroid/animation/TimeInterpolator;[F)Landroid/animation/ObjectAnimator;", "")]
		public static unsafe global::Android.Animation.ObjectAnimator Animate (global::Java.Lang.Object p0, string p1, long p2, long p3, global::Android.Animation.ITimeInterpolator p4, params float[] p5)
		{
			const string __id = "animate.(Ljava/lang/Object;Ljava/lang/String;JJLandroid/animation/TimeInterpolator;[F)Landroid/animation/ObjectAnimator;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				__args [5] = new JniArgumentValue (native_p5);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.ObjectAnimator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='animate' and count(parameter)=7 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='android.animation.TypeEvaluator'] and parameter[6][@type='android.animation.AnimatorListenerAdapter'] and parameter[7][@type='int...']]"
		[Register ("animate", "(Ljava/lang/Object;Ljava/lang/String;JJLandroid/animation/TypeEvaluator;Landroid/animation/AnimatorListenerAdapter;[I)Landroid/animation/ObjectAnimator;", "")]
		public static unsafe global::Android.Animation.ObjectAnimator Animate (global::Java.Lang.Object p0, string p1, long p2, long p3, global::Android.Animation.ITypeEvaluator p4, global::Android.Animation.AnimatorListenerAdapter p5, params int[] p6)
		{
			const string __id = "animate.(Ljava/lang/Object;Ljava/lang/String;JJLandroid/animation/TypeEvaluator;Landroid/animation/AnimatorListenerAdapter;[I)Landroid/animation/ObjectAnimator;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				__args [6] = new JniArgumentValue (native_p6);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.ObjectAnimator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='animate' and count(parameter)=6 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='android.animation.TypeEvaluator'] and parameter[6][@type='int...']]"
		[Register ("animate", "(Ljava/lang/Object;Ljava/lang/String;JJLandroid/animation/TypeEvaluator;[I)Landroid/animation/ObjectAnimator;", "")]
		public static unsafe global::Android.Animation.ObjectAnimator Animate (global::Java.Lang.Object p0, string p1, long p2, long p3, global::Android.Animation.ITypeEvaluator p4, params int[] p5)
		{
			const string __id = "animate.(Ljava/lang/Object;Ljava/lang/String;JJLandroid/animation/TypeEvaluator;[I)Landroid/animation/ObjectAnimator;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				__args [5] = new JniArgumentValue (native_p5);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.ObjectAnimator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='animate' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='float[]'] and parameter[5][@type='android.animation.TimeInterpolator'] and parameter[6][@type='java.util.ArrayList&lt;android.view.View&gt;']]"
		[Register ("animate", "(Ljava/lang/String;JJ[FLandroid/animation/TimeInterpolator;Ljava/util/ArrayList;)V", "")]
		public static unsafe void Animate (string p0, long p1, long p2, float[] p3, global::Android.Animation.ITimeInterpolator p4, global::System.Collections.Generic.IList<global::Android.Views.View> p5)
		{
			const string __id = "animate.(Ljava/lang/String;JJ[FLandroid/animation/TimeInterpolator;Ljava/util/ArrayList;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::Android.Views.View>.ToLocalJniHandle (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				__args [5] = new JniArgumentValue (native_p5);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='calculateHideXY' and count(parameter)=8 and parameter[1][@type='com.nightonke.boommenu.Animation.BoomEnum'] and parameter[2][@type='android.graphics.PointF'] and parameter[3][@type='com.nightonke.boommenu.Animation.Ease'] and parameter[4][@type='int'] and parameter[5][@type='android.graphics.PointF'] and parameter[6][@type='android.graphics.PointF'] and parameter[7][@type='float[]'] and parameter[8][@type='float[]']]"
		[Register ("calculateHideXY", "(Lcom/nightonke/boommenu/Animation/BoomEnum;Landroid/graphics/PointF;Lcom/nightonke/boommenu/Animation/Ease;ILandroid/graphics/PointF;Landroid/graphics/PointF;[F[F)V", "")]
		public static unsafe void CalculateHideXY (global::Com.Nightonke.Boommenu.Animation.BoomEnum p0, global::Android.Graphics.PointF p1, global::Com.Nightonke.Boommenu.Animation.Ease p2, int p3, global::Android.Graphics.PointF p4, global::Android.Graphics.PointF p5, float[] p6, float[] p7)
		{
			const string __id = "calculateHideXY.(Lcom/nightonke/boommenu/Animation/BoomEnum;Landroid/graphics/PointF;Lcom/nightonke/boommenu/Animation/Ease;ILandroid/graphics/PointF;Landroid/graphics/PointF;[F[F)V";
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			IntPtr native_p7 = JNIEnv.NewArray (p7);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				__args [6] = new JniArgumentValue (native_p6);
				__args [7] = new JniArgumentValue (native_p7);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
				if (p7 != null) {
					JNIEnv.CopyArray (native_p7, p7);
					JNIEnv.DeleteLocalRef (native_p7);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='calculateShowXY' and count(parameter)=8 and parameter[1][@type='com.nightonke.boommenu.Animation.BoomEnum'] and parameter[2][@type='android.graphics.PointF'] and parameter[3][@type='com.nightonke.boommenu.Animation.Ease'] and parameter[4][@type='int'] and parameter[5][@type='android.graphics.PointF'] and parameter[6][@type='android.graphics.PointF'] and parameter[7][@type='float[]'] and parameter[8][@type='float[]']]"
		[Register ("calculateShowXY", "(Lcom/nightonke/boommenu/Animation/BoomEnum;Landroid/graphics/PointF;Lcom/nightonke/boommenu/Animation/Ease;ILandroid/graphics/PointF;Landroid/graphics/PointF;[F[F)V", "")]
		public static unsafe void CalculateShowXY (global::Com.Nightonke.Boommenu.Animation.BoomEnum p0, global::Android.Graphics.PointF p1, global::Com.Nightonke.Boommenu.Animation.Ease p2, int p3, global::Android.Graphics.PointF p4, global::Android.Graphics.PointF p5, float[] p6, float[] p7)
		{
			const string __id = "calculateShowXY.(Lcom/nightonke/boommenu/Animation/BoomEnum;Landroid/graphics/PointF;Lcom/nightonke/boommenu/Animation/Ease;ILandroid/graphics/PointF;Landroid/graphics/PointF;[F[F)V";
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			IntPtr native_p7 = JNIEnv.NewArray (p7);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				__args [6] = new JniArgumentValue (native_p6);
				__args [7] = new JniArgumentValue (native_p7);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
				if (p7 != null) {
					JNIEnv.CopyArray (native_p7, p7);
					JNIEnv.DeleteLocalRef (native_p7);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='getOrderIndex' and count(parameter)=2 and parameter[1][@type='com.nightonke.boommenu.Animation.OrderEnum'] and parameter[2][@type='int']]"
		[Register ("getOrderIndex", "(Lcom/nightonke/boommenu/Animation/OrderEnum;I)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> GetOrderIndex (global::Com.Nightonke.Boommenu.Animation.OrderEnum p0, int p1)
		{
			const string __id = "getOrderIndex.(Lcom/nightonke/boommenu/Animation/OrderEnum;I)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='getRotate3DAnimation' and count(parameter)=5 and parameter[1][@type='float[]'] and parameter[2][@type='float[]'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='com.nightonke.boommenu.BoomButtons.BoomButton']]"
		[Register ("getRotate3DAnimation", "([F[FJJLcom/nightonke/boommenu/BoomButtons/BoomButton;)Lcom/nightonke/boommenu/Animation/Rotate3DAnimation;", "")]
		public static unsafe global::Com.Nightonke.Boommenu.Animation.Rotate3DAnimation GetRotate3DAnimation (float[] p0, float[] p1, long p2, long p3, global::Com.Nightonke.Boommenu.BoomButtons.BoomButton p4)
		{
			const string __id = "getRotate3DAnimation.([F[FJJLcom/nightonke/boommenu/BoomButtons/BoomButton;)Lcom/nightonke/boommenu/Animation/Rotate3DAnimation;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.Rotate3DAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='rotate' and count(parameter)=5 and parameter[1][@type='com.nightonke.boommenu.BoomButtons.BoomButton'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='android.animation.TimeInterpolator'] and parameter[5][@type='float...']]"
		[Register ("rotate", "(Lcom/nightonke/boommenu/BoomButtons/BoomButton;JJLandroid/animation/TimeInterpolator;[F)V", "")]
		public static unsafe void Rotate (global::Com.Nightonke.Boommenu.BoomButtons.BoomButton p0, long p1, long p2, global::Android.Animation.ITimeInterpolator p3, params float[] p4)
		{
			const string __id = "rotate.(Lcom/nightonke/boommenu/BoomButtons/BoomButton;JJLandroid/animation/TimeInterpolator;[F)V";
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue (native_p4);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

	}
}
