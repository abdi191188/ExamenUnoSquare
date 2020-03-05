using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.BoomButtons {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/BoomButtons/HamButton", DoNotGenerateAcw=true)]
	public partial class HamButton : global::Com.Nightonke.Boommenu.BoomButtons.BoomButton {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']"
		[global::Android.Runtime.Register ("com/nightonke/boommenu/BoomButtons/HamButton$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/nightonke/boommenu/BoomButtons/HamButton$Builder", typeof (Builder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/constructor[@name='HamButton.Builder' and count(parameter)=0]"
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

			static Delegate cb_getButtonHeight;
#pragma warning disable 0169
			static Delegate GetGetButtonHeightHandler ()
			{
				if (cb_getButtonHeight == null)
					cb_getButtonHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetButtonHeight);
				return cb_getButtonHeight;
			}

			static int n_GetButtonHeight (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ButtonHeight;
			}
#pragma warning restore 0169

			public virtual unsafe int ButtonHeight {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='getButtonHeight' and count(parameter)=0]"
				[Register ("getButtonHeight", "()I", "GetGetButtonHeightHandler")]
				get {
					const string __id = "getButtonHeight.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getButtonWidth;
#pragma warning disable 0169
			static Delegate GetGetButtonWidthHandler ()
			{
				if (cb_getButtonWidth == null)
					cb_getButtonWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetButtonWidth);
				return cb_getButtonWidth;
			}

			static int n_GetButtonWidth (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ButtonWidth;
			}
#pragma warning restore 0169

			public virtual unsafe int ButtonWidth {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='getButtonWidth' and count(parameter)=0]"
				[Register ("getButtonWidth", "()I", "GetGetButtonWidthHandler")]
				get {
					const string __id = "getButtonWidth.()I";
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
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='build' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("build", "(Landroid/content/Context;)Lcom/nightonke/boommenu/BoomButtons/HamButton;", "GetBuild_Landroid_content_Context_Handler")]
			public override unsafe global::Com.Nightonke.Boommenu.BoomButtons.BoomButton Build (global::Android.Content.Context p0)
			{
				const string __id = "build.(Landroid/content/Context;)Lcom/nightonke/boommenu/BoomButtons/HamButton;";
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
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ButtonCornerRadius (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='buttonCornerRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("buttonCornerRadius", "(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetButtonCornerRadius_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder ButtonCornerRadius (int p0)
			{
				const string __id = "buttonCornerRadius.(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_buttonHeight_I;
#pragma warning disable 0169
			static Delegate GetInvokeButtonHeight_IHandler ()
			{
				if (cb_buttonHeight_I == null)
					cb_buttonHeight_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InvokeButtonHeight_I);
				return cb_buttonHeight_I;
			}

			static IntPtr n_InvokeButtonHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.InvokeButtonHeight (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='buttonHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("buttonHeight", "(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetInvokeButtonHeight_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder InvokeButtonHeight (int p0)
			{
				const string __id = "buttonHeight.(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_buttonWidth_I;
#pragma warning disable 0169
			static Delegate GetInvokeButtonWidth_IHandler ()
			{
				if (cb_buttonWidth_I == null)
					cb_buttonWidth_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InvokeButtonWidth_I);
				return cb_buttonWidth_I;
			}

			static IntPtr n_InvokeButtonWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.InvokeButtonWidth (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='buttonWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("buttonWidth", "(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetInvokeButtonWidth_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder InvokeButtonWidth (int p0)
			{
				const string __id = "buttonWidth.(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_containsSubText_Z;
#pragma warning disable 0169
			static Delegate GetContainsSubText_ZHandler ()
			{
				if (cb_containsSubText_Z == null)
					cb_containsSubText_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_ContainsSubText_Z);
				return cb_containsSubText_Z;
			}

			static IntPtr n_ContainsSubText_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ContainsSubText (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='containsSubText' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("containsSubText", "(Z)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetContainsSubText_ZHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder ContainsSubText (bool p0)
			{
				const string __id = "containsSubText.(Z)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_subEllipsize_Landroid_text_TextUtils_TruncateAt_;
#pragma warning disable 0169
			static Delegate GetSubEllipsize_Landroid_text_TextUtils_TruncateAt_Handler ()
			{
				if (cb_subEllipsize_Landroid_text_TextUtils_TruncateAt_ == null)
					cb_subEllipsize_Landroid_text_TextUtils_TruncateAt_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SubEllipsize_Landroid_text_TextUtils_TruncateAt_);
				return cb_subEllipsize_Landroid_text_TextUtils_TruncateAt_;
			}

			static IntPtr n_SubEllipsize_Landroid_text_TextUtils_TruncateAt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Text.TextUtils.TruncateAt p0 = global::Java.Lang.Object.GetObject<global::Android.Text.TextUtils.TruncateAt> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SubEllipsize (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subEllipsize' and count(parameter)=1 and parameter[1][@type='android.text.TextUtils.TruncateAt']]"
			[Register ("subEllipsize", "(Landroid/text/TextUtils$TruncateAt;)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubEllipsize_Landroid_text_TextUtils_TruncateAt_Handler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubEllipsize (global::Android.Text.TextUtils.TruncateAt p0)
			{
				const string __id = "subEllipsize.(Landroid/text/TextUtils$TruncateAt;)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_subHighlightedText_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSubHighlightedText_Ljava_lang_String_Handler ()
			{
				if (cb_subHighlightedText_Ljava_lang_String_ == null)
					cb_subHighlightedText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SubHighlightedText_Ljava_lang_String_);
				return cb_subHighlightedText_Ljava_lang_String_;
			}

			static IntPtr n_SubHighlightedText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SubHighlightedText (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subHighlightedText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("subHighlightedText", "(Ljava/lang/String;)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubHighlightedText_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubHighlightedText (string p0)
			{
				const string __id = "subHighlightedText.(Ljava/lang/String;)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_subHighlightedTextColor_I;
#pragma warning disable 0169
			static Delegate GetSubHighlightedTextColor_IHandler ()
			{
				if (cb_subHighlightedTextColor_I == null)
					cb_subHighlightedTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SubHighlightedTextColor_I);
				return cb_subHighlightedTextColor_I;
			}

			static IntPtr n_SubHighlightedTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SubHighlightedTextColor (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subHighlightedTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("subHighlightedTextColor", "(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubHighlightedTextColor_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubHighlightedTextColor (int p0)
			{
				const string __id = "subHighlightedTextColor.(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_subHighlightedTextColorRes_I;
#pragma warning disable 0169
			static Delegate GetSubHighlightedTextColorRes_IHandler ()
			{
				if (cb_subHighlightedTextColorRes_I == null)
					cb_subHighlightedTextColorRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SubHighlightedTextColorRes_I);
				return cb_subHighlightedTextColorRes_I;
			}

			static IntPtr n_SubHighlightedTextColorRes_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SubHighlightedTextColorRes (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subHighlightedTextColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("subHighlightedTextColorRes", "(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubHighlightedTextColorRes_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubHighlightedTextColorRes (int p0)
			{
				const string __id = "subHighlightedTextColorRes.(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_subHighlightedTextRes_I;
#pragma warning disable 0169
			static Delegate GetSubHighlightedTextRes_IHandler ()
			{
				if (cb_subHighlightedTextRes_I == null)
					cb_subHighlightedTextRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SubHighlightedTextRes_I);
				return cb_subHighlightedTextRes_I;
			}

			static IntPtr n_SubHighlightedTextRes_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SubHighlightedTextRes (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subHighlightedTextRes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("subHighlightedTextRes", "(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubHighlightedTextRes_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubHighlightedTextRes (int p0)
			{
				const string __id = "subHighlightedTextRes.(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_subMaxLines_I;
#pragma warning disable 0169
			static Delegate GetSubMaxLines_IHandler ()
			{
				if (cb_subMaxLines_I == null)
					cb_subMaxLines_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SubMaxLines_I);
				return cb_subMaxLines_I;
			}

			static IntPtr n_SubMaxLines_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SubMaxLines (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subMaxLines' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("subMaxLines", "(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubMaxLines_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubMaxLines (int p0)
			{
				const string __id = "subMaxLines.(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_subNormalText_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSubNormalText_Ljava_lang_String_Handler ()
			{
				if (cb_subNormalText_Ljava_lang_String_ == null)
					cb_subNormalText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SubNormalText_Ljava_lang_String_);
				return cb_subNormalText_Ljava_lang_String_;
			}

			static IntPtr n_SubNormalText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SubNormalText (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subNormalText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("subNormalText", "(Ljava/lang/String;)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubNormalText_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubNormalText (string p0)
			{
				const string __id = "subNormalText.(Ljava/lang/String;)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_subNormalTextColor_I;
#pragma warning disable 0169
			static Delegate GetSubNormalTextColor_IHandler ()
			{
				if (cb_subNormalTextColor_I == null)
					cb_subNormalTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SubNormalTextColor_I);
				return cb_subNormalTextColor_I;
			}

			static IntPtr n_SubNormalTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SubNormalTextColor (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subNormalTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("subNormalTextColor", "(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubNormalTextColor_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubNormalTextColor (int p0)
			{
				const string __id = "subNormalTextColor.(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_subNormalTextColorRes_I;
#pragma warning disable 0169
			static Delegate GetSubNormalTextColorRes_IHandler ()
			{
				if (cb_subNormalTextColorRes_I == null)
					cb_subNormalTextColorRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SubNormalTextColorRes_I);
				return cb_subNormalTextColorRes_I;
			}

			static IntPtr n_SubNormalTextColorRes_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SubNormalTextColorRes (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subNormalTextColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("subNormalTextColorRes", "(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubNormalTextColorRes_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubNormalTextColorRes (int p0)
			{
				const string __id = "subNormalTextColorRes.(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_subNormalTextRes_I;
#pragma warning disable 0169
			static Delegate GetSubNormalTextRes_IHandler ()
			{
				if (cb_subNormalTextRes_I == null)
					cb_subNormalTextRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SubNormalTextRes_I);
				return cb_subNormalTextRes_I;
			}

			static IntPtr n_SubNormalTextRes_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SubNormalTextRes (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subNormalTextRes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("subNormalTextRes", "(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubNormalTextRes_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubNormalTextRes (int p0)
			{
				const string __id = "subNormalTextRes.(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_subTextGravity_I;
#pragma warning disable 0169
			static Delegate GetSubTextGravity_IHandler ()
			{
				if (cb_subTextGravity_I == null)
					cb_subTextGravity_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SubTextGravity_I);
				return cb_subTextGravity_I;
			}

			static IntPtr n_SubTextGravity_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SubTextGravity (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subTextGravity' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("subTextGravity", "(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubTextGravity_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubTextGravity (int p0)
			{
				const string __id = "subTextGravity.(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_subTextPadding_Landroid_graphics_Rect_;
#pragma warning disable 0169
			static Delegate GetSubTextPadding_Landroid_graphics_Rect_Handler ()
			{
				if (cb_subTextPadding_Landroid_graphics_Rect_ == null)
					cb_subTextPadding_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SubTextPadding_Landroid_graphics_Rect_);
				return cb_subTextPadding_Landroid_graphics_Rect_;
			}

			static IntPtr n_SubTextPadding_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Rect p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SubTextPadding (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subTextPadding' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
			[Register ("subTextPadding", "(Landroid/graphics/Rect;)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubTextPadding_Landroid_graphics_Rect_Handler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubTextPadding (global::Android.Graphics.Rect p0)
			{
				const string __id = "subTextPadding.(Landroid/graphics/Rect;)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_subTextRect_Landroid_graphics_Rect_;
#pragma warning disable 0169
			static Delegate GetSubTextRect_Landroid_graphics_Rect_Handler ()
			{
				if (cb_subTextRect_Landroid_graphics_Rect_ == null)
					cb_subTextRect_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SubTextRect_Landroid_graphics_Rect_);
				return cb_subTextRect_Landroid_graphics_Rect_;
			}

			static IntPtr n_SubTextRect_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Rect p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SubTextRect (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subTextRect' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
			[Register ("subTextRect", "(Landroid/graphics/Rect;)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubTextRect_Landroid_graphics_Rect_Handler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubTextRect (global::Android.Graphics.Rect p0)
			{
				const string __id = "subTextRect.(Landroid/graphics/Rect;)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_subTextSize_I;
#pragma warning disable 0169
			static Delegate GetSubTextSize_IHandler ()
			{
				if (cb_subTextSize_I == null)
					cb_subTextSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SubTextSize_I);
				return cb_subTextSize_I;
			}

			static IntPtr n_SubTextSize_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SubTextSize (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subTextSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("subTextSize", "(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubTextSize_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubTextSize (int p0)
			{
				const string __id = "subTextSize.(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_subTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
			static Delegate GetSubTypeface_Landroid_graphics_Typeface_Handler ()
			{
				if (cb_subTypeface_Landroid_graphics_Typeface_ == null)
					cb_subTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SubTypeface_Landroid_graphics_Typeface_);
				return cb_subTypeface_Landroid_graphics_Typeface_;
			}

			static IntPtr n_SubTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SubTypeface (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
			[Register ("subTypeface", "(Landroid/graphics/Typeface;)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubTypeface_Landroid_graphics_Typeface_Handler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubTypeface (global::Android.Graphics.Typeface p0)
			{
				const string __id = "subTypeface.(Landroid/graphics/Typeface;)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_subUnableText_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSubUnableText_Ljava_lang_String_Handler ()
			{
				if (cb_subUnableText_Ljava_lang_String_ == null)
					cb_subUnableText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SubUnableText_Ljava_lang_String_);
				return cb_subUnableText_Ljava_lang_String_;
			}

			static IntPtr n_SubUnableText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SubUnableText (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subUnableText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("subUnableText", "(Ljava/lang/String;)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubUnableText_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubUnableText (string p0)
			{
				const string __id = "subUnableText.(Ljava/lang/String;)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_subUnableTextColor_I;
#pragma warning disable 0169
			static Delegate GetSubUnableTextColor_IHandler ()
			{
				if (cb_subUnableTextColor_I == null)
					cb_subUnableTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SubUnableTextColor_I);
				return cb_subUnableTextColor_I;
			}

			static IntPtr n_SubUnableTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SubUnableTextColor (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subUnableTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("subUnableTextColor", "(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubUnableTextColor_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubUnableTextColor (int p0)
			{
				const string __id = "subUnableTextColor.(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_subUnableTextColorRes_I;
#pragma warning disable 0169
			static Delegate GetSubUnableTextColorRes_IHandler ()
			{
				if (cb_subUnableTextColorRes_I == null)
					cb_subUnableTextColorRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SubUnableTextColorRes_I);
				return cb_subUnableTextColorRes_I;
			}

			static IntPtr n_SubUnableTextColorRes_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SubUnableTextColorRes (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subUnableTextColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("subUnableTextColorRes", "(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubUnableTextColorRes_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubUnableTextColorRes (int p0)
			{
				const string __id = "subUnableTextColorRes.(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_subUnableTextRes_I;
#pragma warning disable 0169
			static Delegate GetSubUnableTextRes_IHandler ()
			{
				if (cb_subUnableTextRes_I == null)
					cb_subUnableTextRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SubUnableTextRes_I);
				return cb_subUnableTextRes_I;
			}

			static IntPtr n_SubUnableTextRes_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SubUnableTextRes (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton.Builder']/method[@name='subUnableTextRes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("subUnableTextRes", "(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;", "GetSubUnableTextRes_IHandler")]
			public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder SubUnableTextRes (int p0)
			{
				const string __id = "subUnableTextRes.(I)Lcom/nightonke/boommenu/BoomButtons/HamButton$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/nightonke/boommenu/BoomButtons/HamButton", typeof (HamButton));
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

		protected HamButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Nightonke.Boommenu.BoomButtons.HamButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentHeight ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton']/method[@name='contentHeight' and count(parameter)=0]"
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
			global::Com.Nightonke.Boommenu.BoomButtons.HamButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentWidth ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton']/method[@name='contentWidth' and count(parameter)=0]"
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
			global::Com.Nightonke.Boommenu.BoomButtons.HamButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Views.View>.ToLocalJniHandle (__this.GoneViews ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton']/method[@name='goneViews' and count(parameter)=0]"
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
			global::Com.Nightonke.Boommenu.BoomButtons.HamButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Views.View>.ToLocalJniHandle (__this.RotateViews ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton']/method[@name='rotateViews' and count(parameter)=0]"
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
			global::Com.Nightonke.Boommenu.BoomButtons.HamButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRotateAnchorPoints ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton']/method[@name='setRotateAnchorPoints' and count(parameter)=0]"
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
			global::Com.Nightonke.Boommenu.BoomButtons.HamButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelfScaleAnchorPoints ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton']/method[@name='setSelfScaleAnchorPoints' and count(parameter)=0]"
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
			global::Com.Nightonke.Boommenu.BoomButtons.HamButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToHighlighted ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton']/method[@name='toHighlighted' and count(parameter)=0]"
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
			global::Com.Nightonke.Boommenu.BoomButtons.HamButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToNormal ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton']/method[@name='toNormal' and count(parameter)=0]"
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
			global::Com.Nightonke.Boommenu.BoomButtons.HamButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrueHeight ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton']/method[@name='trueHeight' and count(parameter)=0]"
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
			global::Com.Nightonke.Boommenu.BoomButtons.HamButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrueWidth ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton']/method[@name='trueWidth' and count(parameter)=0]"
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
			global::Com.Nightonke.Boommenu.BoomButtons.HamButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.HamButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='HamButton']/method[@name='type' and count(parameter)=0]"
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
