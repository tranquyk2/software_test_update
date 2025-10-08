using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FT_ShungHo_Test.Properties
{
	// Token: 0x0200000F RID: 15
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.7.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000182B0 File Offset: 0x000164B0
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000182C8 File Offset: 0x000164C8
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000182EA File Offset: 0x000164EA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double OCP_LowerOffset
		{
			get
			{
				return (double)this["OCP_LowerOffset"];
			}
			set
			{
				this["OCP_LowerOffset"] = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00018300 File Offset: 0x00016500
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00018322 File Offset: 0x00016522
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double OCP_HigherOffset
		{
			get
			{
				return (double)this["OCP_HigherOffset"];
			}
			set
			{
				this["OCP_HigherOffset"] = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00018338 File Offset: 0x00016538
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0001835A File Offset: 0x0001655A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double OCP_CurrentStep
		{
			get
			{
				return (double)this["OCP_CurrentStep"];
			}
			set
			{
				this["OCP_CurrentStep"] = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00018370 File Offset: 0x00016570
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00018392 File Offset: 0x00016592
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public long OCP_StepDelay
		{
			get
			{
				return (long)this["OCP_StepDelay"];
			}
			set
			{
				this["OCP_StepDelay"] = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x000183A8 File Offset: 0x000165A8
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x000183CA File Offset: 0x000165CA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double OCP_LowerLimit
		{
			get
			{
				return (double)this["OCP_LowerLimit"];
			}
			set
			{
				this["OCP_LowerLimit"] = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000183E0 File Offset: 0x000165E0
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00018402 File Offset: 0x00016602
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double OCP_UpperLimit
		{
			get
			{
				return (double)this["OCP_UpperLimit"];
			}
			set
			{
				this["OCP_UpperLimit"] = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00018418 File Offset: 0x00016618
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0001843A File Offset: 0x0001663A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double ShortTest_MaximumCurrent
		{
			get
			{
				return (double)this["ShortTest_MaximumCurrent"];
			}
			set
			{
				this["ShortTest_MaximumCurrent"] = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00018450 File Offset: 0x00016650
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00018472 File Offset: 0x00016672
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public long ShortTest_Delay
		{
			get
			{
				return (long)this["ShortTest_Delay"];
			}
			set
			{
				this["ShortTest_Delay"] = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00018488 File Offset: 0x00016688
		// (set) Token: 0x06000100 RID: 256 RVA: 0x000184AA File Offset: 0x000166AA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public double ShortTest_JudgementVoltage
		{
			get
			{
				return (double)this["ShortTest_JudgementVoltage"];
			}
			set
			{
				this["ShortTest_JudgementVoltage"] = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000184C0 File Offset: 0x000166C0
		// (set) Token: 0x06000102 RID: 258 RVA: 0x000184E2 File Offset: 0x000166E2
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool ShortTest_Enable
		{
			get
			{
				return (bool)this["ShortTest_Enable"];
			}
			set
			{
				this["ShortTest_Enable"] = value;
			}
		}

		// Token: 0x0400021B RID: 539
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
