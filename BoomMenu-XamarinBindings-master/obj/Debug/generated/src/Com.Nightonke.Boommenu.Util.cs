using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/Util", DoNotGenerateAcw=true)]
	public partial class Util : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/nightonke/boommenu/Util", typeof (Util));
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

		protected Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				const string __id = "getColor.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe global::Com.Nightonke.Boommenu.Util Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/nightonke/boommenu/Util;", "GetGetInstanceHandler")]
			get {
				const string __id = "getInstance.()Lcom/nightonke/boommenu/Util;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Util> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='distance' and count(parameter)=2 and parameter[1][@type='android.graphics.Point'] and parameter[2][@type='android.graphics.Point']]"
		[Register ("distance", "(Landroid/graphics/Point;Landroid/graphics/Point;)F", "")]
		public static unsafe float Distance (global::Android.Graphics.Point p0, global::Android.Graphics.Point p1)
		{
			const string __id = "distance.(Landroid/graphics/Point;Landroid/graphics/Point;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='dp2px' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("dp2px", "(F)I", "")]
		public static unsafe int Dp2px (float p0)
		{
			const string __id = "dp2px.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getBoolean' and count(parameter)=3 and parameter[1][@type='android.content.res.TypedArray'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getBoolean", "(Landroid/content/res/TypedArray;II)Z", "")]
		public static unsafe bool GetBoolean (global::Android.Content.Res.TypedArray p0, int p1, int p2)
		{
			const string __id = "getBoolean.(Landroid/content/res/TypedArray;II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getColor' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getColor", "(Landroid/content/Context;I)I", "")]
		public static unsafe int GetColor (global::Android.Content.Context p0, int p1)
		{
			const string __id = "getColor.(Landroid/content/Context;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getColor' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getColor", "(Landroid/content/Context;II)I", "")]
		public static unsafe int GetColor (global::Android.Content.Context p0, int p1, int p2)
		{
			const string __id = "getColor.(Landroid/content/Context;II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getColor' and count(parameter)=2 and parameter[1][@type='android.content.res.TypedArray'] and parameter[2][@type='int']]"
		[Register ("getColor", "(Landroid/content/res/TypedArray;I)I", "")]
		public static unsafe int GetColor (global::Android.Content.Res.TypedArray p0, int p1)
		{
			const string __id = "getColor.(Landroid/content/res/TypedArray;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getColor' and count(parameter)=3 and parameter[1][@type='android.content.res.TypedArray'] and parameter[2][@type='int'] and parameter[3][@type='android.content.res.Resources.Theme']]"
		[Register ("getColor", "(Landroid/content/res/TypedArray;ILandroid/content/res/Resources$Theme;)I", "")]
		public static unsafe int GetColor (global::Android.Content.Res.TypedArray p0, int p1, global::Android.Content.Res.Resources.Theme p2)
		{
			const string __id = "getColor.(Landroid/content/res/TypedArray;ILandroid/content/res/Resources$Theme;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getColor' and count(parameter)=3 and parameter[1][@type='android.content.res.TypedArray'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getColor", "(Landroid/content/res/TypedArray;II)I", "")]
		public static unsafe int GetColor (global::Android.Content.Res.TypedArray p0, int p1, int p2)
		{
			const string __id = "getColor.(Landroid/content/res/TypedArray;II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getColor' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("getColor", "(Landroid/view/View;I)I", "")]
		public static unsafe int GetColor (global::Android.Views.View p0, int p1)
		{
			const string __id = "getColor.(Landroid/view/View;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getColor' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='android.content.res.Resources.Theme']]"
		[Register ("getColor", "(Landroid/view/View;ILandroid/content/res/Resources$Theme;)I", "")]
		public static unsafe int GetColor (global::Android.Views.View p0, int p1, global::Android.Content.Res.Resources.Theme p2)
		{
			const string __id = "getColor.(Landroid/view/View;ILandroid/content/res/Resources$Theme;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getDarkerColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDarkerColor", "(I)I", "")]
		public static unsafe int GetDarkerColor (int p0)
		{
			const string __id = "getDarkerColor.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getDimenOffset' and count(parameter)=3 and parameter[1][@type='android.content.res.TypedArray'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getDimenOffset", "(Landroid/content/res/TypedArray;II)I", "")]
		public static unsafe int GetDimenOffset (global::Android.Content.Res.TypedArray p0, int p1, int p2)
		{
			const string __id = "getDimenOffset.(Landroid/content/res/TypedArray;II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getDimenSize' and count(parameter)=3 and parameter[1][@type='android.content.res.TypedArray'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getDimenSize", "(Landroid/content/res/TypedArray;II)I", "")]
		public static unsafe int GetDimenSize (global::Android.Content.Res.TypedArray p0, int p1, int p2)
		{
			const string __id = "getDimenSize.(Landroid/content/res/TypedArray;II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getDrawable' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("getDrawable", "(Landroid/view/View;I)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetDrawable (global::Android.Views.View p0, int p1)
		{
			const string __id = "getDrawable.(Landroid/view/View;I)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getDrawable' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='android.content.res.Resources.Theme']]"
		[Register ("getDrawable", "(Landroid/view/View;ILandroid/content/res/Resources$Theme;)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetDrawable (global::Android.Views.View p0, int p1, global::Android.Content.Res.Resources.Theme p2)
		{
			const string __id = "getDrawable.(Landroid/view/View;ILandroid/content/res/Resources$Theme;)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getInt' and count(parameter)=3 and parameter[1][@type='android.content.res.TypedArray'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getInt", "(Landroid/content/res/TypedArray;II)I", "")]
		public static unsafe int GetInt (global::Android.Content.Res.TypedArray p0, int p1, int p2)
		{
			const string __id = "getInt.(Landroid/content/res/TypedArray;II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getLighterColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLighterColor", "(I)I", "")]
		public static unsafe int GetLighterColor (int p0)
		{
			const string __id = "getLighterColor.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getOvalBitmapDrawable' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getOvalBitmapDrawable", "(Landroid/view/View;II)Landroid/graphics/drawable/BitmapDrawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.BitmapDrawable GetOvalBitmapDrawable (global::Android.Views.View p0, int p1, int p2)
		{
			const string __id = "getOvalBitmapDrawable.(Landroid/view/View;II)Landroid/graphics/drawable/BitmapDrawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.BitmapDrawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getOvalDrawable' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("getOvalDrawable", "(Landroid/view/View;I)Landroid/graphics/drawable/GradientDrawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.GradientDrawable GetOvalDrawable (global::Android.Views.View p0, int p1)
		{
			const string __id = "getOvalDrawable.(Landroid/view/View;I)Landroid/graphics/drawable/GradientDrawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.GradientDrawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getOvalStateListBitmapDrawable' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("getOvalStateListBitmapDrawable", "(Landroid/view/View;IIII)Landroid/graphics/drawable/StateListDrawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.StateListDrawable GetOvalStateListBitmapDrawable (global::Android.Views.View p0, int p1, int p2, int p3, int p4)
		{
			const string __id = "getOvalStateListBitmapDrawable.(Landroid/view/View;IIII)Landroid/graphics/drawable/StateListDrawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.StateListDrawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getOvalStateListGradientDrawable' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("getOvalStateListGradientDrawable", "(Landroid/view/View;III)Landroid/graphics/drawable/StateListDrawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.StateListDrawable GetOvalStateListGradientDrawable (global::Android.Views.View p0, int p1, int p2, int p3)
		{
			const string __id = "getOvalStateListGradientDrawable.(Landroid/view/View;III)Landroid/graphics/drawable/StateListDrawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.StateListDrawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getRectangleBitmapDrawable' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("getRectangleBitmapDrawable", "(Landroid/view/View;IIII)Landroid/graphics/drawable/BitmapDrawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.BitmapDrawable GetRectangleBitmapDrawable (global::Android.Views.View p0, int p1, int p2, int p3, int p4)
		{
			const string __id = "getRectangleBitmapDrawable.(Landroid/view/View;IIII)Landroid/graphics/drawable/BitmapDrawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.BitmapDrawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getRectangleDrawable' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getRectangleDrawable", "(Landroid/view/View;II)Landroid/graphics/drawable/GradientDrawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.GradientDrawable GetRectangleDrawable (global::Android.Views.View p0, int p1, int p2)
		{
			const string __id = "getRectangleDrawable.(Landroid/view/View;II)Landroid/graphics/drawable/GradientDrawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.GradientDrawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getRectangleStateListBitmapDrawable' and count(parameter)=7 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("getRectangleStateListBitmapDrawable", "(Landroid/view/View;IIIIII)Landroid/graphics/drawable/StateListDrawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.StateListDrawable GetRectangleStateListBitmapDrawable (global::Android.Views.View p0, int p1, int p2, int p3, int p4, int p5, int p6)
		{
			const string __id = "getRectangleStateListBitmapDrawable.(Landroid/view/View;IIIIII)Landroid/graphics/drawable/StateListDrawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (p6);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.StateListDrawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getRectangleStateListGradientDrawable' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("getRectangleStateListGradientDrawable", "(Landroid/view/View;IIII)Landroid/graphics/drawable/StateListDrawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.StateListDrawable GetRectangleStateListGradientDrawable (global::Android.Views.View p0, int p1, int p2, int p3, int p4)
		{
			const string __id = "getRectangleStateListGradientDrawable.(Landroid/view/View;IIII)Landroid/graphics/drawable/StateListDrawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.StateListDrawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='getSystemDrawable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getSystemDrawable", "(Landroid/content/Context;I)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetSystemDrawable (global::Android.Content.Context p0, int p1)
		{
			const string __id = "getSystemDrawable.(Landroid/content/Context;I)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='pointInView' and count(parameter)=2 and parameter[1][@type='android.graphics.PointF'] and parameter[2][@type='android.view.View']]"
		[Register ("pointInView", "(Landroid/graphics/PointF;Landroid/view/View;)Z", "")]
		public static unsafe bool PointInView (global::Android.Graphics.PointF p0, global::Android.Views.View p1)
		{
			const string __id = "pointInView.(Landroid/graphics/PointF;Landroid/view/View;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='setDrawable' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("setDrawable", "(Landroid/view/View;Landroid/graphics/drawable/Drawable;)V", "")]
		public static unsafe void SetDrawable (global::Android.Views.View p0, global::Android.Graphics.Drawables.Drawable p1)
		{
			const string __id = "setDrawable.(Landroid/view/View;Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='setDrawable' and count(parameter)=3 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.drawable.Drawable']]"
		[Register ("setDrawable", "(Landroid/widget/ImageView;ILandroid/graphics/drawable/Drawable;)V", "")]
		public static unsafe void SetDrawable (global::Android.Widget.ImageView p0, int p1, global::Android.Graphics.Drawables.Drawable p2)
		{
			const string __id = "setDrawable.(Landroid/widget/ImageView;ILandroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='setText' and count(parameter)=3 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("setText", "(Landroid/widget/TextView;ILjava/lang/String;)V", "")]
		public static unsafe void SetText (global::Android.Widget.TextView p0, int p1, string p2)
		{
			const string __id = "setText.(Landroid/widget/TextView;ILjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='Util']/method[@name='setTextColor' and count(parameter)=3 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setTextColor", "(Landroid/widget/TextView;II)V", "")]
		public static unsafe void SetTextColor (global::Android.Widget.TextView p0, int p1, int p2)
		{
			const string __id = "setTextColor.(Landroid/widget/TextView;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
