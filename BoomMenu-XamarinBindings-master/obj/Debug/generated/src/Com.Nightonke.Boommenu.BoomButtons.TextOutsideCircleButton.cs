using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.BoomButtons {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/BoomButtons/TextOutsideCircleButton", DoNotGenerateAcw=true)]
	public partial class TextOutsideCircleButton : global::Com.Nightonke.Boommenu.BoomButtons.BoomButton {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton.Builder']"
		[global::Android.Runtime.Register ("com/nightonke/boommenu/BoomButtons/TextOutsideCircleButton$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/nightonke/boommenu/BoomButtons/TextOutsideCircleButton$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton.Builder']/constructor[@name='TextOutsideCircleButton.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			static Delegate cb_getButtonContentHeight;
#pragma warning disable 0169
			static Delegate GetGetButtonContentHeightHandler ()
			{
				if (cb_getButtonContentHeight == null)
					cb_getButtonContentHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetButtonContentHeight);
				return cb_getButtonContentHeight;
			}

			static int n_GetButtonContentHeight (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ButtonContentHeight;
			}
#pragma warning restore 0169

			public virtual unsafe int ButtonContentHeight {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton.Builder']/method[@name='getButtonContentHeight' and count(parameter)=0]"
				[Register ("getButtonContentHeight", "()I", "GetGetButtonContentHeightHandler")]
				get {
					const string __id = "getButtonContentHeight.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getButtonContentWidth;
#pragma warning disable 0169
			static Delegate GetGetButtonContentWidthHandler ()
			{
				if (cb_getButtonContentWidth == null)
					cb_getButtonContentWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetButtonContentWidth);
				return cb_getButtonContentWidth;
			}

			static int n_GetButtonContentWidth (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ButtonContentWidth;
			}
#pragma warning restore 0169

			public virtual unsafe int ButtonContentWidth {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton.Builder']/method[@name='getButtonContentWidth' and count(parameter)=0]"
				[Register ("getButtonContentWidth", "()I", "GetGetButtonContentWidthHandler")]
				get {
					const string __id = "getButtonContentWidth.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getButtonRadius;
#pragma warning disable 0169
			static Delegate GetGetButtonRadiusHandler ()
			{
				if (cb_getButtonRadius == null)
					cb_getButtonRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetButtonRadius);
				return cb_getButtonRadius;
			}

			static int n_GetButtonRadius (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ButtonRadius;
			}
#pragma warning restore 0169

			public virtual unsafe int ButtonRadius {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton.Builder']/method[@name='getButtonRadius' and count(parameter)=0]"
				[Register ("getButtonRadius", "()I", "GetGetButtonRadiusHandler")]
				get {
					const string __id = "getButtonRadius.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_build_Landroid_content_Context_;
#pragma warning disable 0169
			static Delegate GetBuild_Landroid_content_Context_Handler ()
			{
				if (cb_build_Landroid_content_Context_ == null)
					cb_build_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Build_Landroid_content_Context_);
				return cb_build_Landroid_content_Context_;
			}

			static IntPtr n_Build_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton.Builder']/method[@name='build' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("build", "(Landroid/content/Context;)Lcom/nightonke/boommenu/BoomButtons/TextOutsideCircleButton;", "GetBuild_Landroid_content_Context_Handler")]
			public override unsafe global::Com.Nightonke.Boommenu.BoomButtons.BoomButton Build (global::Android.Content.Context p0)
			{
				const string __id = "build.(Landroid/content/Context;)Lcom/nightonke/boommenu/BoomButtons/TextOutsideCircleButton;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_buttonCornerRadius_I;
#pragma warning disable 0169
			static Delegate GetButtonCornerRadius_IHandler ()
			{
				if (cb_buttonCornerRadius_I == null)
					cb_buttonCornerRadius_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ButtonCornerRadius_I);
				return cb_buttonCornerRadius_I;
			}

			static IntPtr n_ButtonCornerRadius_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ButtonCornerRadius (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton.Builder']/method[@name='buttonCornerRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("buttonCornerRadius", "(I)Lcom/nightonke/boommenu/BoomButtons/TextOutsideCircleButton$Builder;", "GetButtonCornerRadius_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder ButtonCornerRadius (int p0)
			{
				const string __id = "buttonCornerRadius.(I)Lcom/nightonke/boommenu/BoomButtons/TextOutsideCircleButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_buttonRadius_I;
#pragma warning disable 0169
			static Delegate GetInvokeButtonRadius_IHandler ()
			{
				if (cb_buttonRadius_I == null)
					cb_buttonRadius_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InvokeButtonRadius_I);
				return cb_buttonRadius_I;
			}

			static IntPtr n_InvokeButtonRadius_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.InvokeButtonRadius (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton.Builder']/method[@name='buttonRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("buttonRadius", "(I)Lcom/nightonke/boommenu/BoomButtons/TextOutsideCircleButton$Builder;", "GetInvokeButtonRadius_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder InvokeButtonRadius (int p0)
			{
				const string __id = "buttonRadius.(I)Lcom/nightonke/boommenu/BoomButtons/TextOutsideCircleButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_isRound_Z;
#pragma warning disable 0169
			static Delegate GetIsRound_ZHandler ()
			{
				if (cb_isRound_Z == null)
					cb_isRound_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_IsRound_Z);
				return cb_isRound_Z;
			}

			static IntPtr n_IsRound_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.IsRound (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton.Builder']/method[@name='isRound' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("isRound", "(Z)Lcom/nightonke/boommenu/BoomButtons/TextOutsideCircleButton$Builder;", "GetIsRound_ZHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder IsRound (bool p0)
			{
				const string __id = "isRound.(Z)Lcom/nightonke/boommenu/BoomButtons/TextOutsideCircleButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_rotateText_Z;
#pragma warning disable 0169
			static Delegate GetRotateText_ZHandler ()
			{
				if (cb_rotateText_Z == null)
					cb_rotateText_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_RotateText_Z);
				return cb_rotateText_Z;
			}

			static IntPtr n_RotateText_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.RotateText (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton.Builder']/method[@name='rotateText' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("rotateText", "(Z)Lcom/nightonke/boommenu/BoomButtons/TextOutsideCircleButton$Builder;", "GetRotateText_ZHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder RotateText (bool p0)
			{
				const string __id = "rotateText.(Z)Lcom/nightonke/boommenu/BoomButtons/TextOutsideCircleButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_textHeight_I;
#pragma warning disable 0169
			static Delegate GetTextHeight_IHandler ()
			{
				if (cb_textHeight_I == null)
					cb_textHeight_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_TextHeight_I);
				return cb_textHeight_I;
			}

			static IntPtr n_TextHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.TextHeight (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton.Builder']/method[@name='textHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("textHeight", "(I)Lcom/nightonke/boommenu/BoomButtons/TextOutsideCircleButton$Builder;", "GetTextHeight_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder TextHeight (int p0)
			{
				const string __id = "textHeight.(I)Lcom/nightonke/boommenu/BoomButtons/TextOutsideCircleButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_textTopMargin_I;
#pragma warning disable 0169
			static Delegate GetTextTopMargin_IHandler ()
			{
				if (cb_textTopMargin_I == null)
					cb_textTopMargin_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_TextTopMargin_I);
				return cb_textTopMargin_I;
			}

			static IntPtr n_TextTopMargin_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.TextTopMargin (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton.Builder']/method[@name='textTopMargin' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("textTopMargin", "(I)Lcom/nightonke/boommenu/BoomButtons/TextOutsideCircleButton$Builder;", "GetTextTopMargin_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder TextTopMargin (int p0)
			{
				const string __id = "textTopMargin.(I)Lcom/nightonke/boommenu/BoomButtons/TextOutsideCircleButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_textWidth_I;
#pragma warning disable 0169
			static Delegate GetTextWidth_IHandler ()
			{
				if (cb_textWidth_I == null)
					cb_textWidth_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_TextWidth_I);
				return cb_textWidth_I;
			}

			static IntPtr n_TextWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.TextWidth (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton.Builder']/method[@name='textWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("textWidth", "(I)Lcom/nightonke/boommenu/BoomButtons/TextOutsideCircleButton$Builder;", "GetTextWidth_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder TextWidth (int p0)
			{
				const string __id = "textWidth.(I)Lcom/nightonke/boommenu/BoomButtons/TextOutsideCircleButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/nightonke/boommenu/BoomButtons/TextOutsideCircleButton", typeof (TextOutsideCircleButton));
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

		protected TextOutsideCircleButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_contentHeight;
#pragma warning disable 0169
		static Delegate GetContentHeightHandler ()
		{
			if (cb_contentHeight == null)
				cb_contentHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ContentHeight);
			return cb_contentHeight;
		}

		static int n_ContentHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentHeight ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton']/method[@name='contentHeight' and count(parameter)=0]"
		[Register ("contentHeight", "()I", "GetContentHeightHandler")]
		public override unsafe int ContentHeight ()
		{
			const string __id = "contentHeight.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_contentWidth;
#pragma warning disable 0169
		static Delegate GetContentWidthHandler ()
		{
			if (cb_contentWidth == null)
				cb_contentWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ContentWidth);
			return cb_contentWidth;
		}

		static int n_ContentWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentWidth ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton']/method[@name='contentWidth' and count(parameter)=0]"
		[Register ("contentWidth", "()I", "GetContentWidthHandler")]
		public override unsafe int ContentWidth ()
		{
			const string __id = "contentWidth.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_goneViews;
#pragma warning disable 0169
		static Delegate GetGoneViewsHandler ()
		{
			if (cb_goneViews == null)
				cb_goneViews = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GoneViews);
			return cb_goneViews;
		}

		static IntPtr n_GoneViews (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Views.View>.ToLocalJniHandle (__this.GoneViews ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton']/method[@name='goneViews' and count(parameter)=0]"
		[Register ("goneViews", "()Ljava/util/ArrayList;", "GetGoneViewsHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Android.Views.View> GoneViews ()
		{
			const string __id = "goneViews.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Android.Views.View>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_rotateViews;
#pragma warning disable 0169
		static Delegate GetRotateViewsHandler ()
		{
			if (cb_rotateViews == null)
				cb_rotateViews = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RotateViews);
			return cb_rotateViews;
		}

		static IntPtr n_RotateViews (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Views.View>.ToLocalJniHandle (__this.RotateViews ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton']/method[@name='rotateViews' and count(parameter)=0]"
		[Register ("rotateViews", "()Ljava/util/ArrayList;", "GetRotateViewsHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Android.Views.View> RotateViews ()
		{
			const string __id = "rotateViews.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Android.Views.View>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRotateAnchorPoints;
#pragma warning disable 0169
		static Delegate GetSetRotateAnchorPointsHandler ()
		{
			if (cb_setRotateAnchorPoints == null)
				cb_setRotateAnchorPoints = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetRotateAnchorPoints);
			return cb_setRotateAnchorPoints;
		}

		static void n_SetRotateAnchorPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRotateAnchorPoints ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton']/method[@name='setRotateAnchorPoints' and count(parameter)=0]"
		[Register ("setRotateAnchorPoints", "()V", "GetSetRotateAnchorPointsHandler")]
		public override unsafe void SetRotateAnchorPoints ()
		{
			const string __id = "setRotateAnchorPoints.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setSelfScaleAnchorPoints;
#pragma warning disable 0169
		static Delegate GetSetSelfScaleAnchorPointsHandler ()
		{
			if (cb_setSelfScaleAnchorPoints == null)
				cb_setSelfScaleAnchorPoints = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetSelfScaleAnchorPoints);
			return cb_setSelfScaleAnchorPoints;
		}

		static void n_SetSelfScaleAnchorPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelfScaleAnchorPoints ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton']/method[@name='setSelfScaleAnchorPoints' and count(parameter)=0]"
		[Register ("setSelfScaleAnchorPoints", "()V", "GetSetSelfScaleAnchorPointsHandler")]
		public override unsafe void SetSelfScaleAnchorPoints ()
		{
			const string __id = "setSelfScaleAnchorPoints.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_toHighlighted;
#pragma warning disable 0169
		static Delegate GetToHighlightedHandler ()
		{
			if (cb_toHighlighted == null)
				cb_toHighlighted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ToHighlighted);
			return cb_toHighlighted;
		}

		static void n_ToHighlighted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToHighlighted ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton']/method[@name='toHighlighted' and count(parameter)=0]"
		[Register ("toHighlighted", "()V", "GetToHighlightedHandler")]
		protected override unsafe void ToHighlighted ()
		{
			const string __id = "toHighlighted.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_toNormal;
#pragma warning disable 0169
		static Delegate GetToNormalHandler ()
		{
			if (cb_toNormal == null)
				cb_toNormal = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ToNormal);
			return cb_toNormal;
		}

		static void n_ToNormal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToNormal ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton']/method[@name='toNormal' and count(parameter)=0]"
		[Register ("toNormal", "()V", "GetToNormalHandler")]
		protected override unsafe void ToNormal ()
		{
			const string __id = "toNormal.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_trueHeight;
#pragma warning disable 0169
		static Delegate GetTrueHeightHandler ()
		{
			if (cb_trueHeight == null)
				cb_trueHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_TrueHeight);
			return cb_trueHeight;
		}

		static int n_TrueHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrueHeight ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton']/method[@name='trueHeight' and count(parameter)=0]"
		[Register ("trueHeight", "()I", "GetTrueHeightHandler")]
		public override unsafe int TrueHeight ()
		{
			const string __id = "trueHeight.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_trueWidth;
#pragma warning disable 0169
		static Delegate GetTrueWidthHandler ()
		{
			if (cb_trueWidth == null)
				cb_trueWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_TrueWidth);
			return cb_trueWidth;
		}

		static int n_TrueWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrueWidth ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton']/method[@name='trueWidth' and count(parameter)=0]"
		[Register ("trueWidth", "()I", "GetTrueWidthHandler")]
		public override unsafe int TrueWidth ()
		{
			const string __id = "trueWidth.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_type;
#pragma warning disable 0169
		static Delegate GetTypeHandler ()
		{
			if (cb_type == null)
				cb_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Type);
			return cb_type;
		}

		static IntPtr n_Type (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextOutsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextOutsideCircleButton']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Lcom/nightonke/boommenu/ButtonEnum;", "GetTypeHandler")]
		public override unsafe global::Com.Nightonke.Boommenu.ButtonEnum Type ()
		{
			const string __id = "type.()Lcom/nightonke/boommenu/ButtonEnum;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.ButtonEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
